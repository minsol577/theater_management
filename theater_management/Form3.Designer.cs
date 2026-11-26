namespace theater_management
{
    partial class Form3
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
            this.groupBoxMovie = new System.Windows.Forms.GroupBox();
            this.dgvMovie = new System.Windows.Forms.DataGridView();
            this.lblMovieId = new System.Windows.Forms.Label();
            this.txtMovieId = new System.Windows.Forms.TextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblRunningTime = new System.Windows.Forms.Label();
            this.txtRunningTime = new System.Windows.Forms.TextBox();
            this.lblAgeRating = new System.Windows.Forms.Label();
            this.cmbAgeRating = new System.Windows.Forms.ComboBox();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.lblDirector = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.btnMovieAdd = new System.Windows.Forms.Button();
            this.btnMovieUpdate = new System.Windows.Forms.Button();
            this.btnMovieDelete = new System.Windows.Forms.Button();
            this.btnMovieClear = new System.Windows.Forms.Button();

            this.groupBoxSchedule = new System.Windows.Forms.GroupBox();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.lblScheduleId = new System.Windows.Forms.Label();
            this.txtScheduleId = new System.Windows.Forms.TextBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.cmbAdmin = new System.Windows.Forms.ComboBox();
            this.lblSelMovie = new System.Windows.Forms.Label();
            this.cmbMovie = new System.Windows.Forms.ComboBox();
            this.lblSelTheater = new System.Windows.Forms.Label();
            this.cmbTheater = new System.Windows.Forms.ComboBox();
            this.lblScreeningDate = new System.Windows.Forms.Label();
            this.dtpScreeningDate = new System.Windows.Forms.DateTimePicker();
            this.lblRound = new System.Windows.Forms.Label();
            this.txtRound = new System.Windows.Forms.TextBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.btnSchedAdd = new System.Windows.Forms.Button();
            this.btnSchedUpdate = new System.Windows.Forms.Button();
            this.btnSchedDelete = new System.Windows.Forms.Button();
            this.btnSchedClear = new System.Windows.Forms.Button();

            this.groupBoxMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).BeginInit();
            this.groupBoxSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.SuspendLayout();

            // groupBoxMovie
            this.groupBoxMovie.Controls.Add(this.btnMovieClear);
            this.groupBoxMovie.Controls.Add(this.btnMovieDelete);
            this.groupBoxMovie.Controls.Add(this.btnMovieUpdate);
            this.groupBoxMovie.Controls.Add(this.btnMovieAdd);
            this.groupBoxMovie.Controls.Add(this.txtDirector);
            this.groupBoxMovie.Controls.Add(this.lblDirector);
            this.groupBoxMovie.Controls.Add(this.dtpReleaseDate);
            this.groupBoxMovie.Controls.Add(this.lblReleaseDate);
            this.groupBoxMovie.Controls.Add(this.cmbAgeRating);
            this.groupBoxMovie.Controls.Add(this.lblAgeRating);
            this.groupBoxMovie.Controls.Add(this.txtRunningTime);
            this.groupBoxMovie.Controls.Add(this.lblRunningTime);
            this.groupBoxMovie.Controls.Add(this.txtGenre);
            this.groupBoxMovie.Controls.Add(this.lblGenre);
            this.groupBoxMovie.Controls.Add(this.txtMovieName);
            this.groupBoxMovie.Controls.Add(this.lblMovieName);
            this.groupBoxMovie.Controls.Add(this.txtMovieId);
            this.groupBoxMovie.Controls.Add(this.lblMovieId);
            this.groupBoxMovie.Controls.Add(this.dgvMovie);
            this.groupBoxMovie.Location = new System.Drawing.Point(20, 20);
            this.groupBoxMovie.Name = "groupBoxMovie";
            this.groupBoxMovie.Size = new System.Drawing.Size(720, 810);
            this.groupBoxMovie.TabIndex = 0;
            this.groupBoxMovie.TabStop = false;
            this.groupBoxMovie.Text = "영화 정보 관리 (movie)";

            // dgvMovie
            this.dgvMovie.AllowUserToAddRows = false;
            this.dgvMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovie.Location = new System.Drawing.Point(15, 35);
            this.dgvMovie.ReadOnly = true;
            this.dgvMovie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovie.Size = new System.Drawing.Size(690, 410);
            this.dgvMovie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovie_CellClick);

            // 영화 입력 컨트롤
            this.lblMovieId.AutoSize = true;
            this.lblMovieId.Location = new System.Drawing.Point(20, 470);
            this.lblMovieId.Text = "영화ID*";

            this.txtMovieId.Location = new System.Drawing.Point(130, 465);
            this.txtMovieId.Size = new System.Drawing.Size(160, 30);

            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(340, 470);
            this.lblGenre.Text = "장르*";

            this.txtGenre.Location = new System.Drawing.Point(450, 465);
            this.txtGenre.Size = new System.Drawing.Size(220, 30);

            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Location = new System.Drawing.Point(20, 520);
            this.lblMovieName.Text = "영화제목*";

            this.txtMovieName.Location = new System.Drawing.Point(130, 515);
            this.txtMovieName.Size = new System.Drawing.Size(540, 30);

            this.lblRunningTime.AutoSize = true;
            this.lblRunningTime.Location = new System.Drawing.Point(20, 570);
            this.lblRunningTime.Text = "상영시간(분)*";

            this.txtRunningTime.Location = new System.Drawing.Point(155, 565);
            this.txtRunningTime.Size = new System.Drawing.Size(135, 30);

            this.lblAgeRating.AutoSize = true;
            this.lblAgeRating.Location = new System.Drawing.Point(340, 570);
            this.lblAgeRating.Text = "관람등급";

            this.cmbAgeRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgeRating.Items.AddRange(new object[] { "전체관람가", "12세이상관람가", "15세이상관람가", "청소년관람불가" });
            this.cmbAgeRating.Location = new System.Drawing.Point(450, 565);
            this.cmbAgeRating.Size = new System.Drawing.Size(220, 32);

            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Location = new System.Drawing.Point(20, 620);
            this.lblReleaseDate.Text = "개봉일";

            this.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReleaseDate.Location = new System.Drawing.Point(130, 615);
            this.dtpReleaseDate.Size = new System.Drawing.Size(180, 30);

            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(340, 620);
            this.lblDirector.Text = "감독";

            this.txtDirector.Location = new System.Drawing.Point(450, 615);
            this.txtDirector.Size = new System.Drawing.Size(220, 30);

            // 영화 CRUD 버튼
            this.btnMovieAdd.Location = new System.Drawing.Point(20, 720);
            this.btnMovieAdd.Size = new System.Drawing.Size(150, 45);
            this.btnMovieAdd.Text = "영화 등록";
            this.btnMovieAdd.Click += new System.EventHandler(this.btnMovieAdd_Click);

            this.btnMovieUpdate.Location = new System.Drawing.Point(190, 720);
            this.btnMovieUpdate.Size = new System.Drawing.Size(150, 45);
            this.btnMovieUpdate.Text = "영화 수정";
            this.btnMovieUpdate.Click += new System.EventHandler(this.btnMovieUpdate_Click);

            this.btnMovieDelete.Location = new System.Drawing.Point(360, 720);
            this.btnMovieDelete.Size = new System.Drawing.Size(150, 45);
            this.btnMovieDelete.Text = "영화 삭제";
            this.btnMovieDelete.Click += new System.EventHandler(this.btnMovieDelete_Click);

            this.btnMovieClear.Location = new System.Drawing.Point(530, 720);
            this.btnMovieClear.Size = new System.Drawing.Size(150, 45);
            this.btnMovieClear.Text = "입력초기화";
            this.btnMovieClear.Click += new System.EventHandler(this.btnMovieClear_Click);

            // groupBoxSchedule
            this.groupBoxSchedule.Controls.Add(this.btnSchedClear);
            this.groupBoxSchedule.Controls.Add(this.btnSchedDelete);
            this.groupBoxSchedule.Controls.Add(this.btnSchedUpdate);
            this.groupBoxSchedule.Controls.Add(this.btnSchedAdd);
            this.groupBoxSchedule.Controls.Add(this.txtEndTime);
            this.groupBoxSchedule.Controls.Add(this.lblEndTime);
            this.groupBoxSchedule.Controls.Add(this.txtStartTime);
            this.groupBoxSchedule.Controls.Add(this.lblStartTime);
            this.groupBoxSchedule.Controls.Add(this.txtRound);
            this.groupBoxSchedule.Controls.Add(this.lblRound);
            this.groupBoxSchedule.Controls.Add(this.dtpScreeningDate);
            this.groupBoxSchedule.Controls.Add(this.lblScreeningDate);
            this.groupBoxSchedule.Controls.Add(this.cmbTheater);
            this.groupBoxSchedule.Controls.Add(this.lblSelTheater);
            this.groupBoxSchedule.Controls.Add(this.cmbMovie);
            this.groupBoxSchedule.Controls.Add(this.lblSelMovie);
            this.groupBoxSchedule.Controls.Add(this.cmbAdmin);
            this.groupBoxSchedule.Controls.Add(this.lblAdmin);
            this.groupBoxSchedule.Controls.Add(this.txtScheduleId);
            this.groupBoxSchedule.Controls.Add(this.lblScheduleId);
            this.groupBoxSchedule.Controls.Add(this.dgvSchedule);
            this.groupBoxSchedule.Location = new System.Drawing.Point(760, 20);
            this.groupBoxSchedule.Name = "groupBoxSchedule";
            this.groupBoxSchedule.Size = new System.Drawing.Size(960, 810);
            this.groupBoxSchedule.TabIndex = 1;
            this.groupBoxSchedule.TabStop = false;
            this.groupBoxSchedule.Text = "상영 스케줄 관리 (screening_schedule)";

            // dgvSchedule
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Location = new System.Drawing.Point(15, 35);
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedule.Size = new System.Drawing.Size(930, 410);
            this.dgvSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedule_CellClick);

            // 스케줄 입력 컨트롤
            this.lblScheduleId.AutoSize = true;
            this.lblScheduleId.Location = new System.Drawing.Point(20, 470);
            this.lblScheduleId.Text = "스케줄ID*";

            this.txtScheduleId.Location = new System.Drawing.Point(145, 465);
            this.txtScheduleId.Size = new System.Drawing.Size(160, 30);

            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(360, 470);
            this.lblAdmin.Text = "담당관리자";

            this.cmbAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdmin.Location = new System.Drawing.Point(490, 465);
            this.cmbAdmin.Size = new System.Drawing.Size(220, 32);

            this.lblSelMovie.AutoSize = true;
            this.lblSelMovie.Location = new System.Drawing.Point(20, 520);
            this.lblSelMovie.Text = "상영영화*";

            this.cmbMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMovie.Location = new System.Drawing.Point(145, 515);
            this.cmbMovie.Size = new System.Drawing.Size(420, 32);
            this.cmbMovie.SelectedIndexChanged += new System.EventHandler(this.AutoCalculateEndTime);

            this.lblSelTheater.AutoSize = true;
            this.lblSelTheater.Location = new System.Drawing.Point(590, 520);
            this.lblSelTheater.Text = "상영관*";

            this.cmbTheater.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTheater.Location = new System.Drawing.Point(690, 515);
            this.cmbTheater.Size = new System.Drawing.Size(220, 32);

            this.lblScreeningDate.AutoSize = true;
            this.lblScreeningDate.Location = new System.Drawing.Point(20, 570);
            this.lblScreeningDate.Text = "상영일자*";

            this.dtpScreeningDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpScreeningDate.Location = new System.Drawing.Point(145, 565);
            this.dtpScreeningDate.Size = new System.Drawing.Size(200, 30);

            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(390, 570);
            this.lblRound.Text = "상영회차*";

            this.txtRound.Location = new System.Drawing.Point(510, 565);
            this.txtRound.Size = new System.Drawing.Size(120, 30);

            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(20, 620);
            this.lblStartTime.Text = "시작(HH:mm)*";

            this.txtStartTime.Location = new System.Drawing.Point(175, 615);
            this.txtStartTime.Size = new System.Drawing.Size(170, 30);
            this.txtStartTime.TextChanged += new System.EventHandler(this.AutoCalculateEndTime);

            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(390, 620);
            this.lblEndTime.Text = "종료(HH:mm)*";

            this.txtEndTime.Location = new System.Drawing.Point(545, 615);
            this.txtEndTime.Size = new System.Drawing.Size(170, 30);

            // 스케줄 CRUD 버튼
            this.btnSchedAdd.Location = new System.Drawing.Point(20, 720);
            this.btnSchedAdd.Size = new System.Drawing.Size(165, 45);
            this.btnSchedAdd.Text = "스케줄 등록";
            this.btnSchedAdd.Click += new System.EventHandler(this.btnSchedAdd_Click);

            this.btnSchedUpdate.Location = new System.Drawing.Point(205, 720);
            this.btnSchedUpdate.Size = new System.Drawing.Size(165, 45);
            this.btnSchedUpdate.Text = "스케줄 수정";
            this.btnSchedUpdate.Click += new System.EventHandler(this.btnSchedUpdate_Click);

            this.btnSchedDelete.Location = new System.Drawing.Point(390, 720);
            this.btnSchedDelete.Size = new System.Drawing.Size(165, 45);
            this.btnSchedDelete.Text = "스케줄 삭제";
            this.btnSchedDelete.Click += new System.EventHandler(this.btnSchedDelete_Click);

            this.btnSchedClear.Location = new System.Drawing.Point(575, 720);
            this.btnSchedClear.Size = new System.Drawing.Size(165, 45);
            this.btnSchedClear.Text = "입력초기화";
            this.btnSchedClear.Click += new System.EventHandler(this.btnSchedClear_Click);

            // Form3
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1745, 855);
            this.Controls.Add(this.groupBoxSchedule);
            this.Controls.Add(this.groupBoxMovie);
            this.Name = "Form3";
            this.Text = "영화 및 상영 스케줄 관리";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.groupBoxMovie.ResumeLayout(false);
            this.groupBoxMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).EndInit();
            this.groupBoxSchedule.ResumeLayout(false);
            this.groupBoxSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMovie;
        private System.Windows.Forms.DataGridView dgvMovie;
        private System.Windows.Forms.Label lblMovieId;
        private System.Windows.Forms.TextBox txtMovieId;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblRunningTime;
        private System.Windows.Forms.TextBox txtRunningTime;
        private System.Windows.Forms.Label lblAgeRating;
        private System.Windows.Forms.ComboBox cmbAgeRating;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Button btnMovieAdd;
        private System.Windows.Forms.Button btnMovieUpdate;
        private System.Windows.Forms.Button btnMovieDelete;
        private System.Windows.Forms.Button btnMovieClear;

        private System.Windows.Forms.GroupBox groupBoxSchedule;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.Label lblScheduleId;
        private System.Windows.Forms.TextBox txtScheduleId;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.ComboBox cmbAdmin;
        private System.Windows.Forms.Label lblSelMovie;
        private System.Windows.Forms.ComboBox cmbMovie;
        private System.Windows.Forms.Label lblSelTheater;
        private System.Windows.Forms.ComboBox cmbTheater;
        private System.Windows.Forms.Label lblScreeningDate;
        private System.Windows.Forms.DateTimePicker dtpScreeningDate;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.TextBox txtRound;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Button btnSchedAdd;
        private System.Windows.Forms.Button btnSchedUpdate;
        private System.Windows.Forms.Button btnSchedDelete;
        private System.Windows.Forms.Button btnSchedClear;
    }
}