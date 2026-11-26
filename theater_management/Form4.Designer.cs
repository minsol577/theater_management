namespace theater_management
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.cmbFilterGrade = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();

            this.groupBoxHistory = new System.Windows.Forms.GroupBox();
            this.dgvHistory = new System.Windows.Forms.DataGridView();

            this.groupBoxDetail = new System.Windows.Forms.GroupBox();
            this.lblCustId = new System.Windows.Forms.Label();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblVipGrade = new System.Windows.Forms.Label();
            this.cmbVipGrade = new System.Windows.Forms.ComboBox();
            this.lblPoint = new System.Windows.Forms.Label();
            this.txtPoint = new System.Windows.Forms.TextBox();

            this.groupBoxPoint = new System.Windows.Forms.GroupBox();
            this.lblPointDelta = new System.Windows.Forms.Label();
            this.txtPointDelta = new System.Windows.Forms.TextBox();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.btnUsePoint = new System.Windows.Forms.Button();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.groupBoxHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.groupBoxDetail.SuspendLayout();
            this.groupBoxPoint.SuspendLayout();
            this.SuspendLayout();

            // groupBoxSearch
            this.groupBoxSearch.Controls.Add(this.lblTotalCount);
            this.groupBoxSearch.Controls.Add(this.btnReset);
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Controls.Add(this.cmbFilterGrade);
            this.groupBoxSearch.Controls.Add(this.txtSearchName);
            this.groupBoxSearch.Controls.Add(this.lblSearch);
            this.groupBoxSearch.Controls.Add(this.dgvCustomer);
            this.groupBoxSearch.Location = new System.Drawing.Point(20, 20);
            this.groupBoxSearch.Size = new System.Drawing.Size(960, 480);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "고객 및 VIP 목록 조회";

            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 45);
            this.lblSearch.Text = "고객명 / 등급";

            this.txtSearchName.Location = new System.Drawing.Point(165, 40);
            this.txtSearchName.Size = new System.Drawing.Size(220, 30);

            this.cmbFilterGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterGrade.Items.AddRange(new object[] { "전체", "일반", "SILVER", "GOLD", "VIP" });
            this.cmbFilterGrade.Location = new System.Drawing.Point(400, 40);
            this.cmbFilterGrade.Size = new System.Drawing.Size(150, 32);

            this.btnSearch.Location = new System.Drawing.Point(570, 36);
            this.btnSearch.Size = new System.Drawing.Size(100, 38);
            this.btnSearch.Text = "검색";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.btnReset.Location = new System.Drawing.Point(680, 36);
            this.btnReset.Size = new System.Drawing.Size(100, 38);
            this.btnReset.Text = "초기화";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.ForeColor = System.Drawing.Color.Red;
            this.lblTotalCount.Location = new System.Drawing.Point(840, 45);
            this.lblTotalCount.Text = "총 0명";

            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(20, 90);
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(920, 370);
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);

            // groupBoxHistory (선택 고객 관람 이력 조회)
            this.groupBoxHistory.Controls.Add(this.dgvHistory);
            this.groupBoxHistory.Location = new System.Drawing.Point(20, 515);
            this.groupBoxHistory.Size = new System.Drawing.Size(960, 290);
            this.groupBoxHistory.TabIndex = 1;
            this.groupBoxHistory.TabStop = false;
            this.groupBoxHistory.Text = "선택 고객 관람 이력 (customer_history)";

            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(20, 35);
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(920, 235);

            // groupBoxDetail
            this.groupBoxDetail.Controls.Add(this.btnClear);
            this.groupBoxDetail.Controls.Add(this.btnDelete);
            this.groupBoxDetail.Controls.Add(this.btnUpdate);
            this.groupBoxDetail.Controls.Add(this.btnAdd);
            this.groupBoxDetail.Controls.Add(this.groupBoxPoint);
            this.groupBoxDetail.Controls.Add(this.txtPoint);
            this.groupBoxDetail.Controls.Add(this.lblPoint);
            this.groupBoxDetail.Controls.Add(this.cmbVipGrade);
            this.groupBoxDetail.Controls.Add(this.lblVipGrade);
            this.groupBoxDetail.Controls.Add(this.dtpBirthDate);
            this.groupBoxDetail.Controls.Add(this.lblBirthDate);
            this.groupBoxDetail.Controls.Add(this.txtPhone);
            this.groupBoxDetail.Controls.Add(this.lblPhone);
            this.groupBoxDetail.Controls.Add(this.txtCustName);
            this.groupBoxDetail.Controls.Add(this.lblCustName);
            this.groupBoxDetail.Controls.Add(this.txtPassword);
            this.groupBoxDetail.Controls.Add(this.lblPassword);
            this.groupBoxDetail.Controls.Add(this.txtCustId);
            this.groupBoxDetail.Controls.Add(this.lblCustId);
            this.groupBoxDetail.Location = new System.Drawing.Point(1000, 20);
            this.groupBoxDetail.Size = new System.Drawing.Size(640, 785);
            this.groupBoxDetail.TabIndex = 2;
            this.groupBoxDetail.TabStop = false;
            this.groupBoxDetail.Text = "고객 상세 정보 및 등급 관리 (customer)";

            this.lblCustId.AutoSize = true;
            this.lblCustId.Location = new System.Drawing.Point(30, 55);
            this.lblCustId.Text = "고객 ID*";

            this.txtCustId.Location = new System.Drawing.Point(175, 50);
            this.txtCustId.Size = new System.Drawing.Size(220, 30);

            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(30, 105);
            this.lblPassword.Text = "비밀번호*";

            this.txtPassword.Location = new System.Drawing.Point(175, 100);
            this.txtPassword.Size = new System.Drawing.Size(220, 30);

            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(30, 155);
            this.lblCustName.Text = "고객명*";

            this.txtCustName.Location = new System.Drawing.Point(175, 150);
            this.txtCustName.Size = new System.Drawing.Size(280, 30);

            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(30, 205);
            this.lblPhone.Text = "연락처";

            this.txtPhone.Location = new System.Drawing.Point(175, 200);
            this.txtPhone.Size = new System.Drawing.Size(280, 30);

            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(30, 255);
            this.lblBirthDate.Text = "생년월일";

            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(175, 250);
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 30);

            this.lblVipGrade.AutoSize = true;
            this.lblVipGrade.Location = new System.Drawing.Point(30, 305);
            this.lblVipGrade.Text = "VIP 등급";

            this.cmbVipGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVipGrade.Items.AddRange(new object[] { "일반", "SILVER", "GOLD", "VIP" });
            this.cmbVipGrade.Location = new System.Drawing.Point(175, 300);
            this.cmbVipGrade.Size = new System.Drawing.Size(220, 32);

            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(30, 355);
            this.lblPoint.Text = "보유 포인트";

            this.txtPoint.Location = new System.Drawing.Point(175, 350);
            this.txtPoint.Size = new System.Drawing.Size(220, 30);
            this.txtPoint.Text = "0";

            // groupBoxPoint
            this.groupBoxPoint.Controls.Add(this.btnUsePoint);
            this.groupBoxPoint.Controls.Add(this.btnAddPoint);
            this.groupBoxPoint.Controls.Add(this.txtPointDelta);
            this.groupBoxPoint.Controls.Add(this.lblPointDelta);
            this.groupBoxPoint.Location = new System.Drawing.Point(30, 420);
            this.groupBoxPoint.Size = new System.Drawing.Size(580, 130);
            this.groupBoxPoint.TabStop = false;
            this.groupBoxPoint.Text = "포인트 적립 / 차감 (포인트 기준 등급 자동 반영)";

            this.lblPointDelta.AutoSize = true;
            this.lblPointDelta.Location = new System.Drawing.Point(20, 55);
            this.lblPointDelta.Text = "변동 포인트";

            this.txtPointDelta.Location = new System.Drawing.Point(155, 50);
            this.txtPointDelta.Size = new System.Drawing.Size(180, 30);

            this.btnAddPoint.Location = new System.Drawing.Point(355, 45);
            this.btnAddPoint.Size = new System.Drawing.Size(95, 40);
            this.btnAddPoint.Text = "적립(+)";
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);

            this.btnUsePoint.Location = new System.Drawing.Point(460, 45);
            this.btnUsePoint.Size = new System.Drawing.Size(95, 40);
            this.btnUsePoint.Text = "차감(-)";
            this.btnUsePoint.Click += new System.EventHandler(this.btnUsePoint_Click);

            // CRUD 버튼
            this.btnAdd.Location = new System.Drawing.Point(30, 620);
            this.btnAdd.Size = new System.Drawing.Size(130, 50);
            this.btnAdd.Text = "신규등록";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Location = new System.Drawing.Point(180, 620);
            this.btnUpdate.Size = new System.Drawing.Size(130, 50);
            this.btnUpdate.Text = "정보수정";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Location = new System.Drawing.Point(330, 620);
            this.btnDelete.Size = new System.Drawing.Size(130, 50);
            this.btnDelete.Text = "회원삭제";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Location = new System.Drawing.Point(480, 620);
            this.btnClear.Size = new System.Drawing.Size(130, 50);
            this.btnClear.Text = "초기화";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // Form4
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1665, 830);
            this.Controls.Add(this.groupBoxDetail);
            this.Controls.Add(this.groupBoxHistory);
            this.Controls.Add(this.groupBoxSearch);
            this.Name = "Form4";
            this.Text = "고객 및 VIP 관리";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.groupBoxHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.groupBoxDetail.ResumeLayout(false);
            this.groupBoxDetail.PerformLayout();
            this.groupBoxPoint.ResumeLayout(false);
            this.groupBoxPoint.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.ComboBox cmbFilterGrade;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.DataGridView dgvCustomer;

        private System.Windows.Forms.GroupBox groupBoxHistory;
        private System.Windows.Forms.DataGridView dgvHistory;

        private System.Windows.Forms.GroupBox groupBoxDetail;
        private System.Windows.Forms.Label lblCustId;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblVipGrade;
        private System.Windows.Forms.ComboBox cmbVipGrade;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.TextBox txtPoint;

        private System.Windows.Forms.GroupBox groupBoxPoint;
        private System.Windows.Forms.Label lblPointDelta;
        private System.Windows.Forms.TextBox txtPointDelta;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Button btnUsePoint;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}