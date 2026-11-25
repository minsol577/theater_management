namespace theater_management
{
    partial class Form6
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
            this.btnCheckCust = new System.Windows.Forms.Button();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.lblCustInfo = new System.Windows.Forms.Label();
            this.lblMovieInfo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSeat = new System.Windows.Forms.ComboBox();
            this.rdoAdult = new System.Windows.Forms.RadioButton();
            this.rdoYouth = new System.Windows.Forms.RadioButton();
            this.rdoSenior = new System.Windows.Forms.RadioButton();
            this.cmbPayMethod = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMovieInfo);
            this.groupBox1.Controls.Add(this.lblCustInfo);
            this.groupBox1.Controls.Add(this.btnCheckCust);
            this.groupBox1.Controls.Add(this.txtCustId);
            this.groupBox1.Location = new System.Drawing.Point(40, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "고객 조회";
            // 
            // btnCheckCust
            // 
            this.btnCheckCust.Location = new System.Drawing.Point(400, 34);
            this.btnCheckCust.Name = "btnCheckCust";
            this.btnCheckCust.Size = new System.Drawing.Size(105, 41);
            this.btnCheckCust.TabIndex = 3;
            this.btnCheckCust.Text = "조회";
            this.btnCheckCust.UseVisualStyleBackColor = true;
            this.btnCheckCust.Click += new System.EventHandler(this.btnCheckCust_Click);
            // 
            // txtCustId
            // 
            this.txtCustId.Location = new System.Drawing.Point(6, 34);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(388, 35);
            this.txtCustId.TabIndex = 2;
            // 
            // lblCustInfo
            // 
            this.lblCustInfo.AutoSize = true;
            this.lblCustInfo.Location = new System.Drawing.Point(6, 89);
            this.lblCustInfo.Name = "lblCustInfo";
            this.lblCustInfo.Size = new System.Drawing.Size(168, 24);
            this.lblCustInfo.TabIndex = 4;
            this.lblCustInfo.Text = "이름/나이/등급";
            // 
            // lblMovieInfo
            // 
            this.lblMovieInfo.AutoSize = true;
            this.lblMovieInfo.Location = new System.Drawing.Point(6, 133);
            this.lblMovieInfo.Name = "lblMovieInfo";
            this.lblMovieInfo.Size = new System.Drawing.Size(114, 24);
            this.lblMovieInfo.TabIndex = 5;
            this.lblMovieInfo.Text = "상영 정보";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbPayMethod);
            this.groupBox2.Controls.Add(this.rdoSenior);
            this.groupBox2.Controls.Add(this.rdoYouth);
            this.groupBox2.Controls.Add(this.rdoAdult);
            this.groupBox2.Controls.Add(this.cmbSeat);
            this.groupBox2.Location = new System.Drawing.Point(590, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 178);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "좌석 선택";
            // 
            // cmbSeat
            // 
            this.cmbSeat.FormattingEnabled = true;
            this.cmbSeat.Location = new System.Drawing.Point(6, 34);
            this.cmbSeat.Name = "cmbSeat";
            this.cmbSeat.Size = new System.Drawing.Size(388, 32);
            this.cmbSeat.TabIndex = 0;
            // 
            // rdoAdult
            // 
            this.rdoAdult.AutoSize = true;
            this.rdoAdult.Location = new System.Drawing.Point(6, 85);
            this.rdoAdult.Name = "rdoAdult";
            this.rdoAdult.Size = new System.Drawing.Size(89, 28);
            this.rdoAdult.TabIndex = 1;
            this.rdoAdult.TabStop = true;
            this.rdoAdult.Text = "성인";
            this.rdoAdult.UseVisualStyleBackColor = true;
            // 
            // rdoYouth
            // 
            this.rdoYouth.AutoSize = true;
            this.rdoYouth.Location = new System.Drawing.Point(119, 85);
            this.rdoYouth.Name = "rdoYouth";
            this.rdoYouth.Size = new System.Drawing.Size(113, 28);
            this.rdoYouth.TabIndex = 2;
            this.rdoYouth.TabStop = true;
            this.rdoYouth.Text = "청소년";
            this.rdoYouth.UseVisualStyleBackColor = true;
            // 
            // rdoSenior
            // 
            this.rdoSenior.AutoSize = true;
            this.rdoSenior.Location = new System.Drawing.Point(256, 87);
            this.rdoSenior.Name = "rdoSenior";
            this.rdoSenior.Size = new System.Drawing.Size(137, 28);
            this.rdoSenior.TabIndex = 3;
            this.rdoSenior.TabStop = true;
            this.rdoSenior.Text = "경로우대";
            this.rdoSenior.UseVisualStyleBackColor = true;
            // 
            // cmbPayMethod
            // 
            this.cmbPayMethod.FormattingEnabled = true;
            this.cmbPayMethod.Items.AddRange(new object[] {
            "신용카드",
            "모바일페이",
            "포인트"});
            this.cmbPayMethod.Location = new System.Drawing.Point(5, 130);
            this.cmbPayMethod.Name = "cmbPayMethod";
            this.cmbPayMethod.Size = new System.Drawing.Size(388, 32);
            this.cmbPayMethod.TabIndex = 4;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(40, 248);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(192, 41);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "결제/예매 확정";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(263, 248);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(192, 41);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "닫기";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1174, 649);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.Text = "seat_select";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheckCust;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.Label lblMovieInfo;
        private System.Windows.Forms.Label lblCustInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoAdult;
        private System.Windows.Forms.ComboBox cmbSeat;
        private System.Windows.Forms.ComboBox cmbPayMethod;
        private System.Windows.Forms.RadioButton rdoSenior;
        private System.Windows.Forms.RadioButton rdoYouth;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}