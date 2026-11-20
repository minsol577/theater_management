namespace theater_management
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind1 = new System.Windows.Forms.TextBox();
            this.rdoTheater = new System.Windows.Forms.RadioButton();
            this.rdoMovieName = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReserveOrCancel = new System.Windows.Forms.Button();
            this.txtFind2 = new System.Windows.Forms.TextBox();
            this.rdoCancel = new System.Windows.Forms.RadioButton();
            this.rdoReserve = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSortTheater = new System.Windows.Forms.Button();
            this.btnSortTitle = new System.Windows.Forms.Button();
            this.btnSortTime = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblScheduleCount = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblReserveCount = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblVipCount = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.txtFind1);
            this.groupBox1.Controls.Add(this.rdoTheater);
            this.groupBox1.Controls.Add(this.rdoMovieName);
            this.groupBox1.Location = new System.Drawing.Point(36, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "스케줄 검색";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(408, 80);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 41);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(297, 80);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(105, 41);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "검색";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFind1
            // 
            this.txtFind1.Location = new System.Drawing.Point(6, 80);
            this.txtFind1.Name = "txtFind1";
            this.txtFind1.Size = new System.Drawing.Size(285, 35);
            this.txtFind1.TabIndex = 2;
            // 
            // rdoTheater
            // 
            this.rdoTheater.AutoSize = true;
            this.rdoTheater.Location = new System.Drawing.Point(140, 34);
            this.rdoTheater.Name = "rdoTheater";
            this.rdoTheater.Size = new System.Drawing.Size(113, 28);
            this.rdoTheater.TabIndex = 1;
            this.rdoTheater.TabStop = true;
            this.rdoTheater.Text = "상영관";
            this.rdoTheater.UseVisualStyleBackColor = true;
            // 
            // rdoMovieName
            // 
            this.rdoMovieName.AutoSize = true;
            this.rdoMovieName.Location = new System.Drawing.Point(6, 34);
            this.rdoMovieName.Name = "rdoMovieName";
            this.rdoMovieName.Size = new System.Drawing.Size(113, 28);
            this.rdoMovieName.TabIndex = 0;
            this.rdoMovieName.TabStop = true;
            this.rdoMovieName.Text = "영화명";
            this.rdoMovieName.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnReserveOrCancel);
            this.groupBox2.Controls.Add(this.txtFind2);
            this.groupBox2.Controls.Add(this.rdoCancel);
            this.groupBox2.Controls.Add(this.rdoReserve);
            this.groupBox2.Location = new System.Drawing.Point(596, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "빠른 예매/취소";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(321, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "예매번호 입력";
            // 
            // btnReserveOrCancel
            // 
            this.btnReserveOrCancel.Location = new System.Drawing.Point(297, 80);
            this.btnReserveOrCancel.Name = "btnReserveOrCancel";
            this.btnReserveOrCancel.Size = new System.Drawing.Size(105, 41);
            this.btnReserveOrCancel.TabIndex = 3;
            this.btnReserveOrCancel.Text = "실행";
            this.btnReserveOrCancel.UseVisualStyleBackColor = true;
            this.btnReserveOrCancel.Click += new System.EventHandler(this.btnReserveOrCancel_Click);
            // 
            // txtFind2
            // 
            this.txtFind2.Location = new System.Drawing.Point(6, 80);
            this.txtFind2.Name = "txtFind2";
            this.txtFind2.Size = new System.Drawing.Size(285, 35);
            this.txtFind2.TabIndex = 2;
            // 
            // rdoCancel
            // 
            this.rdoCancel.AutoSize = true;
            this.rdoCancel.Location = new System.Drawing.Point(154, 34);
            this.rdoCancel.Name = "rdoCancel";
            this.rdoCancel.Size = new System.Drawing.Size(137, 28);
            this.rdoCancel.TabIndex = 1;
            this.rdoCancel.TabStop = true;
            this.rdoCancel.Text = "예매취소";
            this.rdoCancel.UseVisualStyleBackColor = true;
            // 
            // rdoReserve
            // 
            this.rdoReserve.AutoSize = true;
            this.rdoReserve.Location = new System.Drawing.Point(6, 34);
            this.rdoReserve.Name = "rdoReserve";
            this.rdoReserve.Size = new System.Drawing.Size(137, 28);
            this.rdoReserve.TabIndex = 0;
            this.rdoReserve.TabStop = true;
            this.rdoReserve.Text = "예매진행";
            this.rdoReserve.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSortTheater);
            this.groupBox3.Controls.Add(this.btnSortTitle);
            this.groupBox3.Controls.Add(this.btnSortTime);
            this.groupBox3.Location = new System.Drawing.Point(36, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(526, 96);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "스케줄 검색";
            // 
            // btnSortTheater
            // 
            this.btnSortTheater.Location = new System.Drawing.Point(344, 34);
            this.btnSortTheater.Name = "btnSortTheater";
            this.btnSortTheater.Size = new System.Drawing.Size(147, 46);
            this.btnSortTheater.TabIndex = 6;
            this.btnSortTheater.Text = "상영관순";
            this.btnSortTheater.UseVisualStyleBackColor = true;
            this.btnSortTheater.Click += new System.EventHandler(this.btnSortTheater_Click);
            // 
            // btnSortTitle
            // 
            this.btnSortTitle.Location = new System.Drawing.Point(179, 34);
            this.btnSortTitle.Name = "btnSortTitle";
            this.btnSortTitle.Size = new System.Drawing.Size(147, 46);
            this.btnSortTitle.TabIndex = 5;
            this.btnSortTitle.Text = "영화명순";
            this.btnSortTitle.UseVisualStyleBackColor = true;
            this.btnSortTitle.Click += new System.EventHandler(this.btnSortTitle_Click);
            // 
            // btnSortTime
            // 
            this.btnSortTime.Location = new System.Drawing.Point(14, 34);
            this.btnSortTime.Name = "btnSortTime";
            this.btnSortTime.Size = new System.Drawing.Size(147, 46);
            this.btnSortTime.TabIndex = 3;
            this.btnSortTime.Text = "시작시간순";
            this.btnSortTime.UseVisualStyleBackColor = true;
            this.btnSortTime.Click += new System.EventHandler(this.btnSortTime_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblScheduleCount);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(36, 327);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1060, 516);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "상영 스케줄 목록";
            // 
            // lblScheduleCount
            // 
            this.lblScheduleCount.AutoSize = true;
            this.lblScheduleCount.ForeColor = System.Drawing.Color.Red;
            this.lblScheduleCount.Location = new System.Drawing.Point(964, 31);
            this.lblScheduleCount.Name = "lblScheduleCount";
            this.lblScheduleCount.Size = new System.Drawing.Size(79, 24);
            this.lblScheduleCount.TabIndex = 8;
            this.lblScheduleCount.Text = "총 0건";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1029, 428);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblReserveCount);
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(1121, 54);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(570, 342);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "당일 예매 현황";
            // 
            // lblReserveCount
            // 
            this.lblReserveCount.AutoSize = true;
            this.lblReserveCount.ForeColor = System.Drawing.Color.Red;
            this.lblReserveCount.Location = new System.Drawing.Point(473, 22);
            this.lblReserveCount.Name = "lblReserveCount";
            this.lblReserveCount.Size = new System.Drawing.Size(79, 24);
            this.lblReserveCount.TabIndex = 9;
            this.lblReserveCount.Text = "총 0건";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 49);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 37;
            this.dataGridView2.Size = new System.Drawing.Size(536, 273);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblVipCount);
            this.groupBox6.Controls.Add(this.dataGridView3);
            this.groupBox6.Location = new System.Drawing.Point(1121, 501);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(570, 342);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "VIP / 주요 고객 현황";
            // 
            // lblVipCount
            // 
            this.lblVipCount.AutoSize = true;
            this.lblVipCount.ForeColor = System.Drawing.Color.Red;
            this.lblVipCount.Location = new System.Drawing.Point(473, 19);
            this.lblVipCount.Name = "lblVipCount";
            this.lblVipCount.Size = new System.Drawing.Size(79, 24);
            this.lblVipCount.TabIndex = 10;
            this.lblVipCount.Text = "총 0명";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(16, 46);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 82;
            this.dataGridView3.RowTemplate.Height = 37;
            this.dataGridView3.Size = new System.Drawing.Size(536, 276);
            this.dataGridView3.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1739, 883);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "main";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind1;
        private System.Windows.Forms.RadioButton rdoTheater;
        private System.Windows.Forms.RadioButton rdoMovieName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReserveOrCancel;
        private System.Windows.Forms.TextBox txtFind2;
        private System.Windows.Forms.RadioButton rdoCancel;
        private System.Windows.Forms.RadioButton rdoReserve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSortTheater;
        private System.Windows.Forms.Button btnSortTitle;
        private System.Windows.Forms.Button btnSortTime;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lblScheduleCount;
        private System.Windows.Forms.Label lblReserveCount;
        private System.Windows.Forms.Label lblVipCount;
    }
}