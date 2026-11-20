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
    public partial class Form1 : Form
    {
        Form2 mainForm;
        Form3 movieForm;
        Form4 customerForm;
        Form5 settlementForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainForm = new Form2();
            mainForm.MdiParent = this;
            mainForm.Show();
        }

        private void 영화상영관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("영화 및 상영 스케줄 관리 화면(Form3) 연결 예정");
            if (movieForm == null || movieForm.IsDisposed)
            {
                movieForm = new Form3();
                movieForm.MdiParent = this;
                movieForm.Show();
            }
        }

        private void 고객관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("고객 및 VIP 관리 화면(Form4) 연결 예정");
        }

        private void 매출정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("일일 매출 및 정산 정보 화면(Form5) 연결 예정");
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
