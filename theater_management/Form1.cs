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
            if (movieForm == null || movieForm.IsDisposed)
            {
                movieForm = new Form3();
                movieForm.MdiParent = this;
                movieForm.Show();
            }
            else
            {
                movieForm.Activate();
            }
        }

        private void 고객관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customerForm == null || customerForm.IsDisposed)
            {
                customerForm = new Form4();
                customerForm.MdiParent = this;
                customerForm.Show();
            }
            else
            {
                customerForm.Activate();
            }
        }

        private void 매출정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settlementForm == null || settlementForm.IsDisposed)
            {
                settlementForm = new Form5 { MdiParent = this };
                settlementForm.Show();
            }
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
