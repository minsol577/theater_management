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
    public partial class Form2 : Form
    {
        DBClass db = new DBClass();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            rdoMovieName.Checked = true;
            rdoReserve.Checked = true;

            // DataGridView 기본 속성 (샘플 가이드 반영)
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView3.AllowUserToAddRows = false;

            LoadScheduleList("", "");
            LoadReservationList();
            LoadVipCustomerList();
        }

        // 1. 상영 스케줄 조회 및 검색/정렬 (좌하단 dataGridView1)
        public void LoadScheduleList(string keyword, string sortBy)
        {
            string sql = @"
                SELECT s.schedule_id AS 스케줄번호,
                       m.movie_name AS 영화명,
                       m.age_rating AS 관람등급,
                       t.theater_name AS 상영관,
                       s.screening_round AS 회차,
                       s.start_time AS 시작시간,
                       s.end_time AS 종료시간,
                       (t.total_seats - (
                           SELECT COUNT(*) FROM reservation_seat rs
                           JOIN reservation r ON rs.reservation_id = r.reservation_id
                           WHERE r.schedule_id = s.schedule_id AND r.reservation_status = '예매완료'
                       )) AS 잔여좌석
                FROM screening_schedule s
                JOIN movie m ON s.movie_id = m.movie_id
                JOIN theater t ON s.theater_id = t.theater_id
                WHERE 1=1 ";

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                if (rdoMovieName.Checked)
                    sql += $" AND m.movie_name LIKE '%{keyword}%' ";
                else
                    sql += $" AND t.theater_name LIKE '%{keyword}%' ";
            }

            if (sortBy == "TIME") sql += " ORDER BY s.start_time ASC";
            else if (sortBy == "TITLE") sql += " ORDER BY m.movie_name ASC";
            else if (sortBy == "THEATER") sql += " ORDER BY t.theater_id ASC";
            else sql += " ORDER BY s.schedule_id ASC";

            DataSet ds = db.DB_Select(sql, "schedule");
            if (ds.Tables.Contains("schedule"))
            {
                dataGridView1.DataSource = ds.Tables["schedule"];
                lblScheduleCount.Text = $"총 {ds.Tables["schedule"].Rows.Count}건";
            }
        }

        // 2. 예매 현황 조회 (우상단 dataGridView2)
        public void LoadReservationList()
        {
            string sql = @"
                SELECT r.reservation_id AS 예매번호,
                       c.customer_name AS 고객명,
                       m.movie_name AS 영화명,
                       r.total_payment AS 결제금액,
                       r.reservation_status AS 상태
                FROM reservation r
                JOIN customer c ON r.customer_id = c.customer_id
                JOIN screening_schedule s ON r.schedule_id = s.schedule_id
                JOIN movie m ON s.movie_id = m.movie_id
                ORDER BY r.reservation_id DESC";

            DataSet ds = db.DB_Select(sql, "reservation");
            if (ds.Tables.Contains("reservation"))
            {
                dataGridView2.DataSource = ds.Tables["reservation"];
                lblReserveCount.Text = $"총 {ds.Tables["reservation"].Rows.Count}건";
            }
        }

        // 3. VIP 및 고객 포인트 현황 (우하단 dataGridView3)
        public void LoadVipCustomerList()
        {
            string sql = @"
                SELECT customer_id AS 고객ID,
                       customer_name AS 고객명,
                       vip_grade AS 등급,
                       point AS 보유포인트
                FROM customer
                ORDER BY point DESC";

            DataSet ds = db.DB_Select(sql, "customer");
            if (ds.Tables.Contains("customer"))
            {
                dataGridView3.DataSource = ds.Tables["customer"];
                lblVipCount.Text = $"총 {ds.Tables["customer"].Rows.Count}명";
            }
        }

        // 검색 버튼
        private void btnFind_Click(object sender, EventArgs e)
        {
            LoadScheduleList(txtFind1.Text.Trim(), "");
        }

        // 초기화(이전) 버튼
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFind1.Clear();
            LoadScheduleList("", "");
        }

        // 정렬 버튼 3종
        private void btnSortTime_Click(object sender, EventArgs e) => LoadScheduleList(txtFind1.Text.Trim(), "TIME");
        private void btnSortTitle_Click(object sender, EventArgs e) => LoadScheduleList(txtFind1.Text.Trim(), "TITLE");
        private void btnSortTheater_Click(object sender, EventArgs e) => LoadScheduleList(txtFind1.Text.Trim(), "THEATER");

        // 예매 / 취소 실행 버튼
        private void btnReserveOrCancel_Click(object sender, EventArgs e)
        {
            string inputId = txtFind2.Text.Trim();
            if (string.IsNullOrEmpty(inputId))
            {
                MessageBox.Show("스케줄번호(예매 시) 또는 예매번호(취소 시)를 입력하세요.");
                return;
            }

            if (rdoReserve.Checked)
            {
                using (Form6 popup = new Form6(int.Parse(inputId)))
                {
                    if (popup.ShowDialog() == DialogResult.OK)
                    {
                        LoadScheduleList("", "");
                        LoadReservationList();
                        LoadVipCustomerList();
                    }
                }
            }
            else
            {
                // 예매 취소 처리
                string sql = $"UPDATE reservation SET reservation_status = '취소' WHERE reservation_id = {inputId}";
                int res = db.DB_Execute(sql);
                if (res > 0)
                {
                    MessageBox.Show("예매가 취소되었습니다.");
                    LoadScheduleList("", "");
                    LoadReservationList();
                }
            }
        }
    }
}
