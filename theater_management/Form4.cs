using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace theater_management
{
    public partial class Form4 : Form
    {
        DBClass db = new DBClass();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cmbFilterGrade.SelectedIndex = 0;
            cmbVipGrade.SelectedIndex = 0;
            LoadCustomers("", "전체");
        }

        private void LoadCustomers(string nameKeyword, string gradeFilter)
        {
            string sql = @"
                SELECT customer_id AS 고객ID,
                       customer_name AS 고객명,
                       password AS 비밀번호,
                       phone AS 연락처,
                       TO_CHAR(birth_date, 'YYYY-MM-DD') AS 생년월일,
                       vip_grade AS 등급,
                       point AS 보유포인트
                FROM customer
                WHERE 1=1 ";

            if (!string.IsNullOrWhiteSpace(nameKeyword))
                sql += $" AND customer_name LIKE '%{nameKeyword}%' ";

            if (!string.IsNullOrEmpty(gradeFilter) && gradeFilter != "전체")
                sql += $" AND vip_grade = '{gradeFilter}' ";

            sql += " ORDER BY point DESC, customer_id ASC";

            DataSet ds = db.DB_Select(sql, "customer");
            if (ds.Tables.Contains("customer"))
            {
                dgvCustomer.DataSource = ds.Tables["customer"];
                lblTotalCount.Text = $"총 {ds.Tables["customer"].Rows.Count}명";
            }
        }

        private void LoadCustomerHistory(string customerId)
        {
            string sql = $@"
                SELECT h.history_id AS 이력ID,
                       m.movie_name AS 관람영화,
                       TO_CHAR(h.viewing_date, 'YYYY-MM-DD') AS 관람일,
                       h.accumulated_payment AS 결제금액
                FROM customer_history h
                JOIN movie m ON h.movie_id = m.movie_id
                WHERE h.customer_id = {customerId}
                ORDER BY h.viewing_date DESC";

            DataSet ds = db.DB_Select(sql, "history");
            if (ds.Tables.Contains("history"))
            {
                dgvHistory.DataSource = ds.Tables["history"];
            }
        }

        // 시드 데이터(3500P -> VIP, 500P -> 일반) 기준 등급 산정
        private string CalculateGrade(int point)
        {
            if (point >= 3000) return "VIP";
            if (point >= 2000) return "GOLD";
            if (point >= 1000) return "SILVER";
            return "일반";
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];
            string custId = row.Cells["고객ID"].Value.ToString();

            txtCustId.Text = custId;
            txtCustName.Text = row.Cells["고객명"].Value.ToString();
            txtPassword.Text = row.Cells["비밀번호"].Value.ToString();
            txtPhone.Text = row.Cells["연락처"].Value?.ToString() ?? "";

            if (DateTime.TryParse(row.Cells["생년월일"].Value?.ToString(), out DateTime bDate))
                dtpBirthDate.Value = bDate;

            cmbVipGrade.Text = row.Cells["등급"].Value?.ToString().Trim() ?? "일반";
            txtPoint.Text = row.Cells["보유포인트"].Value.ToString();
            txtCustId.ReadOnly = true;

            LoadCustomerHistory(custId);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCustomers(txtSearchName.Text.Trim(), cmbFilterGrade.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearchName.Clear();
            cmbFilterGrade.SelectedIndex = 0;
            LoadCustomers("", "전체");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustId.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtCustName.Text))
            {
                MessageBox.Show("필수 항목(고객 ID, 비밀번호, 고객명)을 입력하세요.");
                return;
            }

            if (!int.TryParse(txtPoint.Text.Trim(), out int point)) point = 0;
            string birthStr = dtpBirthDate.Value.ToString("yyyy-MM-dd");

            string sql = $@"
                INSERT INTO customer (customer_id, password, customer_name, phone, birth_date, point, vip_grade)
                VALUES ({txtCustId.Text.Trim()}, '{txtPassword.Text.Trim()}', '{txtCustName.Text.Trim()}', '{txtPhone.Text.Trim()}', TO_DATE('{birthStr}', 'YYYY-MM-DD'), {point}, '{cmbVipGrade.Text}')";

            if (db.DB_Execute(sql) > 0)
            {
                MessageBox.Show("신규 고객이 등록되었습니다.");
                ClearInputs();
                LoadCustomers("", "전체");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustId.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("수정할 고객을 선택하고 비밀번호를 입력하세요.");
                return;
            }

            if (!int.TryParse(txtPoint.Text.Trim(), out int point))
            {
                MessageBox.Show("포인트는 숫자로 입력하세요.");
                return;
            }

            string birthStr = dtpBirthDate.Value.ToString("yyyy-MM-dd");
            string sql = $@"
                UPDATE customer
                SET password = '{txtPassword.Text.Trim()}',
                    customer_name = '{txtCustName.Text.Trim()}',
                    phone = '{txtPhone.Text.Trim()}',
                    birth_date = TO_DATE('{birthStr}', 'YYYY-MM-DD'),
                    vip_grade = '{cmbVipGrade.Text}',
                    point = {point}
                WHERE customer_id = {txtCustId.Text.Trim()}";

            if (db.DB_Execute(sql) > 0)
            {
                MessageBox.Show("고객 정보가 수정되었습니다.");
                ClearInputs();
                LoadCustomers(txtSearchName.Text.Trim(), cmbFilterGrade.Text);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustId.Text))
            {
                MessageBox.Show("삭제할 고객을 선택하세요.");
                return;
            }

            if (MessageBox.Show("선택한 고객 정보를 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = $"DELETE FROM customer WHERE customer_id = {txtCustId.Text.Trim()}";
                if (db.DB_Execute(sql) > 0)
                {
                    MessageBox.Show("고객 정보가 삭제되었습니다.");
                    ClearInputs();
                    LoadCustomers(txtSearchName.Text.Trim(), cmbFilterGrade.Text);
                }
            }
        }

        private void btnAddPoint_Click(object sender, EventArgs e) => UpdateCustomerPoint(true);
        private void btnUsePoint_Click(object sender, EventArgs e) => UpdateCustomerPoint(false);

        private void UpdateCustomerPoint(bool isAdd)
        {
            if (string.IsNullOrWhiteSpace(txtCustId.Text))
            {
                MessageBox.Show("먼저 고객을 선택하세요.");
                return;
            }

            if (!int.TryParse(txtPoint.Text.Trim(), out int currentPoint) ||
                !int.TryParse(txtPointDelta.Text.Trim(), out int delta) || delta <= 0)
            {
                MessageBox.Show("변동 포인트에 0보다 큰 숫자를 입력하세요.");
                return;
            }

            int newPoint = isAdd ? currentPoint + delta : currentPoint - delta;
            if (newPoint < 0)
            {
                MessageBox.Show("보유 포인트가 부족합니다.");
                return;
            }

            string newGrade = CalculateGrade(newPoint);
            string sql = $"UPDATE customer SET point = {newPoint}, vip_grade = '{newGrade}' WHERE customer_id = {txtCustId.Text.Trim()}";

            if (db.DB_Execute(sql) > 0)
            {
                txtPoint.Text = newPoint.ToString();
                cmbVipGrade.Text = newGrade;
                txtPointDelta.Clear();
                MessageBox.Show($"포인트가 반영되었습니다. (현재: {newPoint}P / 등급: {newGrade})");
                LoadCustomers(txtSearchName.Text.Trim(), cmbFilterGrade.Text);
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearInputs();

        private void ClearInputs()
        {
            txtCustId.Clear();
            txtPassword.Clear();
            txtCustName.Clear();
            txtPhone.Clear();
            dtpBirthDate.Value = DateTime.Today;
            cmbVipGrade.SelectedIndex = 0;
            txtPoint.Text = "0";
            txtPointDelta.Clear();
            txtCustId.ReadOnly = false;
            dgvHistory.DataSource = null;
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 mainForm = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            mainForm?.LoadVipCustomerList();
        }
    }
}