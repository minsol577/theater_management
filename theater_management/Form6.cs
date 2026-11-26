using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theater_management
{
    public partial class Form6 : Form
    {
        DBClass db = new DBClass();
        private int scheduleId;
        private int movieId;
        private int theaterId;
        private string ageRating;
        private string startTime;
        private bool isCustVerified = false;
        private int verifiedCustId = 0;
        private int custAge = 0;
        public Form6(int scheduleId)
        {
            InitializeComponent();
            this.scheduleId = scheduleId;
            this.FormClosed += (s, ev) => db.DB_Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            rdoAdult.Checked = true;
            cmbPayMethod.SelectedIndex = 0;

            // 1. 선택한 스케줄 및 영화 정보 로드
            string sql = $@"
                SELECT s.movie_id, s.theater_id, m.movie_name, m.age_rating, t.theater_name, s.start_time
                FROM screening_schedule s
                JOIN movie m ON s.movie_id = m.movie_id
                JOIN theater t ON s.theater_id = t.theater_id
                WHERE s.schedule_id = {scheduleId}";

            DataSet ds = db.DB_Select(sql, "info");
            if (!ds.Tables.Contains("info") || ds.Tables["info"].Rows.Count == 0)
            {
                MessageBox.Show("존재하지 않는 스케줄 번호입니다.");
                this.Close();
                return;
            }

            DataRow row = ds.Tables["info"].Rows[0];
            movieId = Convert.ToInt32(row["movie_id"]);
            theaterId = Convert.ToInt32(row["theater_id"]);
            ageRating = row["age_rating"].ToString();
            startTime = row["start_time"].ToString();

            lblMovieInfo.Text = $"[{row["theater_name"]}] {row["movie_name"]} ({ageRating}) | 시작: {startTime}";

            // 2. 해당 상영관의 '예매 가능한 잔여 좌석'만 불러오기 (중복 예매 방지)
            LoadAvailableSeats();
        }
        private void LoadAvailableSeats()
        {
            string sql = $@"
                SELECT seat_id, seat_row || '열 ' || seat_id || '번 (' || seat_type || ')' AS seat_label
                FROM seat
                WHERE theater_id = {theaterId}
                  AND seat_id NOT IN (
                      SELECT rs.seat_id
                      FROM reservation_seat rs
                      JOIN reservation r ON rs.reservation_id = r.reservation_id
                      WHERE r.schedule_id = {scheduleId} AND r.reservation_status = '예매완료'
                  )
                ORDER BY seat_id ASC";

            DataSet ds = db.DB_Select(sql, "seats");
            cmbSeat.DataSource = ds.Tables["seats"];
            cmbSeat.DisplayMember = "seat_label";
            cmbSeat.ValueMember = "seat_id";
        }

        private void btnCheckCust_Click(object sender, EventArgs e)
        {
            string cid = txtCustId.Text.Trim();
            if (string.IsNullOrEmpty(cid))
            {
                MessageBox.Show("고객 ID 또는 고객명을 입력하세요.");
                return;
            }

            string whereClause = int.TryParse(cid, out int parsedCustId)
                ? $"customer_id = {parsedCustId}"
                : $"customer_name = '{cid.Replace("'", "''")}'";

            string sql = $"SELECT customer_id, customer_name, vip_grade, point, TRUNC(MONTHS_BETWEEN(SYSDATE, birth_date)/12) AS age FROM customer WHERE {whereClause}";
            DataSet ds = db.DB_Select(sql, "cust");

            if (!ds.Tables.Contains("cust") || ds.Tables["cust"].Rows.Count == 0)
            {
                MessageBox.Show("등록되지 않은 고객입니다. (고객 ID 또는 정확한 고객명을 입력하세요)");
                isCustVerified = false;
                verifiedCustId = 0;
                return;
            }

            if (ds.Tables["cust"].Rows.Count > 1)
            {
                MessageBox.Show("동명이인이 여러 명 있습니다. 고객 ID(숫자)로 조회해 주세요.");
                isCustVerified = false;
                verifiedCustId = 0;
                return;
            }

            DataRow r = ds.Tables["cust"].Rows[0];
            verifiedCustId = Convert.ToInt32(r["customer_id"]);
            custAge = Convert.ToInt32(r["age"]);
            isCustVerified = true;
            lblCustInfo.Text = $"[{verifiedCustId}] {r["customer_name"]}님 (만 {custAge}세 / {r["vip_grade"]} / {r["point"]}P)";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!isCustVerified)
            {
                MessageBox.Show("먼저 고객 ID 조회를 진행해 주세요.");
                return;
            }
            if (cmbSeat.SelectedValue == null)
            {
                MessageBox.Show("선택 가능한 좌석이 없습니다.");
                return;
            }

            // [기획서 요구사항 검증 1] 청소년 관람불가 등급 제한
            if (ageRating.Contains("청소년관람불가") && custAge < 19)
            {
                MessageBox.Show("청소년 관람불가 영화는 만 19세 미만 예매가 불가합니다.");
                return;
            }

            // [기획서 요구사항 검증 2] 22시 이후 심야 상영 청소년 제한
            int startHour = 0;
            if (startTime.Contains(":") && !int.TryParse(startTime.Split(':')[0], out startHour))
                startHour = 0;
            if (startHour >= 22 && (custAge < 19 || rdoYouth.Checked))
            {
                MessageBox.Show("22시 이후 심야 상영은 청소년 예매가 제한됩니다.");
                return;
            }

            // 관람유형별 요금 산정
            string audienceType = rdoAdult.Checked ? "성인" : (rdoYouth.Checked ? "청소년" : "경로");
            int price = rdoAdult.Checked ? 14000 : (rdoYouth.Checked ? 11000 : 7000);
            int seatId = Convert.ToInt32(cmbSeat.SelectedValue);
            int custId = verifiedCustId;
            string payMethod = cmbPayMethod.SelectedItem.ToString();
            int earnPoint = (int)(price * 0.05);

            // 모든 INSERT/UPDATE를 하나의 트랜잭션으로 처리 (중간 실패 시 전체 롤백)
            var sqls = new System.Collections.Generic.List<string>
            {
                // 1) 예매 테이블 INSERT
                $@"INSERT INTO reservation VALUES (
                    (SELECT NVL(MAX(reservation_id), 1000) + 1 FROM reservation),
                    {custId}, {scheduleId}, SYSDATE, {price}, '예매완료'
                )",

                // 2) 예매상세좌석 INSERT
                $@"INSERT INTO reservation_seat VALUES (
                    (SELECT MAX(reservation_id) FROM reservation),
                    {theaterId}, {seatId}, '{audienceType}', {price}
                )",

                // 3) 결제 테이블 INSERT
                $@"INSERT INTO payment VALUES (
                    (SELECT NVL(MAX(payment_id), 5000) + 1 FROM payment),
                    (SELECT MAX(reservation_id) FROM reservation),
                    '{payMethod}', {price}, SYSDATE, 'APP-' || TO_CHAR(SYSDATE, 'HH24MISS')
                )",

                // 4) 고객 관람 이력 INSERT
                $@"INSERT INTO customer_history VALUES (
                    (SELECT NVL(MAX(history_id), 0) + 1 FROM customer_history),
                    {custId}, {movieId}, {scheduleId}, SYSDATE, {price}
                )",

                // 5) 포인트 적립(5%) + VIP 등급 자동 갱신 (Form4 기준과 통일)
                $@"UPDATE customer
                   SET point = point + {earnPoint},
                       vip_grade = CASE
                           WHEN point + {earnPoint} >= 3000 THEN 'VIP'
                           WHEN point + {earnPoint} >= 2000 THEN 'GOLD'
                           WHEN point + {earnPoint} >= 1000 THEN 'SILVER'
                           ELSE '일반'
                       END
                   WHERE customer_id = {custId}"
            };

            if (db.DB_ExecuteTransaction(sqls))
            {
                MessageBox.Show($"예매 및 결제가 완료되었습니다! (적립 포인트: {earnPoint}P)");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}
