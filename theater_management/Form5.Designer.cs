namespace theater_management
{
    partial class Form5
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
            this.lblTotalMovies = new System.Windows.Forms.Label();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.lblTotalTickets = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.dgvMethodSales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMethodSales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalMovies
            // 
            this.lblTotalMovies.AutoSize = true;
            this.lblTotalMovies.Location = new System.Drawing.Point(89, 70);
            this.lblTotalMovies.Name = "lblTotalMovies";
            this.lblTotalMovies.Size = new System.Drawing.Size(155, 24);
            this.lblTotalMovies.TabIndex = 0;
            this.lblTotalMovies.Text = "lblTotalMovies";
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.AutoSize = true;
            this.lblTotalCustomers.Location = new System.Drawing.Point(462, 70);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(192, 24);
            this.lblTotalCustomers.TabIndex = 1;
            this.lblTotalCustomers.Text = "lblTotalCustomers";
            // 
            // lblTotalTickets
            // 
            this.lblTotalTickets.AutoSize = true;
            this.lblTotalTickets.Location = new System.Drawing.Point(89, 152);
            this.lblTotalTickets.Name = "lblTotalTickets";
            this.lblTotalTickets.Size = new System.Drawing.Size(157, 24);
            this.lblTotalTickets.TabIndex = 2;
            this.lblTotalTickets.Text = "lblTotalTickets";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Location = new System.Drawing.Point(462, 152);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(138, 24);
            this.lblTotalSales.TabIndex = 3;
            this.lblTotalSales.Text = "lblTotalSales";
            // 
            // dgvMethodSales
            // 
            this.dgvMethodSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMethodSales.Location = new System.Drawing.Point(93, 231);
            this.dgvMethodSales.Name = "dgvMethodSales";
            this.dgvMethodSales.RowHeadersWidth = 82;
            this.dgvMethodSales.RowTemplate.Height = 37;
            this.dgvMethodSales.Size = new System.Drawing.Size(561, 146);
            this.dgvMethodSales.TabIndex = 4;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMethodSales);
            this.Controls.Add(this.lblTotalSales);
            this.Controls.Add(this.lblTotalTickets);
            this.Controls.Add(this.lblTotalCustomers);
            this.Controls.Add(this.lblTotalMovies);
            this.Name = "Form5";
            this.Text = "settlement_info";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMethodSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalMovies;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.Label lblTotalTickets;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.DataGridView dgvMethodSales;
    }
}