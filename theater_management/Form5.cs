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
    public partial class Form5 : Form
    {
        DBClass db = new DBClass();
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            string sqlSummary = @"
                SELECT
                    (SELECT COUNT(*) FROM movie) AS movie_cnt,
                    (SELECT COUNT(*) FROM customer) AS cust_cnt,
                    (SELECT COUNT(*) FROM reservation WHERE reservation_status = '예매완료') AS ticket_cnt,
                    (SELECT NVL(SUM(total_payment), 0) FROM reservation WHERE reservation_status = '예매완료') AS total_sales
                FROM DUAL";

            DataRow r = db.DB_Select(sqlSummary, "sum").Tables["sum"].Rows[0];
            lblTotalMovies.Text = $"등록 영화: {r["movie_cnt"]}편";
            lblTotalCustomers.Text = $"총 회원 수: {r["cust_cnt"]}명";
            lblTotalTickets.Text = $"누적 예매 건수: {r["ticket_cnt"]}건";
            lblTotalSales.Text = $"총 티켓 매출: {Convert.ToInt32(r["total_sales"]):N0}원";

            // 결제수단별 매출 통계 그리드
            string sqlMethod = @"
                SELECT payment_method AS 결제수단, COUNT(*) AS 건수, SUM(payment_amount) AS 매출합계
                FROM payment
                GROUP BY payment_method";
            dgvMethodSales.DataSource = db.DB_Select(sqlMethod, "method").Tables["method"];
        }
    }
}
