using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace theater_management
{
    public partial class Form3 : Form
    {
        DBClass db = new DBClass();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmbAgeRating.SelectedIndex = 0;
            LoadMovies();
            LoadTheaters();
            LoadAdmins();
            LoadSchedules();
        }

        private void LoadMovies()
        {
            string sql = @"
                SELECT movie_id AS 영화ID,
                       movie_name AS 영화제목,
                       genre AS 장르,
                       running_time AS 상영시간,
                       age_rating AS 관람등급,
                       TO_CHAR(release_date, 'YYYY-MM-DD') AS 개봉일,
                       director AS 감독
                FROM movie
                ORDER BY movie_id ASC";

            DataSet ds = db.DB_Select(sql, "movie");
            if (ds.Tables.Contains("movie"))
            {
                dgvMovie.DataSource = ds.Tables["movie"];

                DataTable dtCombo = ds.Tables["movie"].Copy();
                cmbMovie.DataSource = dtCombo;
                cmbMovie.DisplayMember = "영화제목";
                cmbMovie.ValueMember = "영화ID";
            }
        }

        private void LoadTheaters()
        {
            string sql = "SELECT theater_id, theater_name FROM theater ORDER BY theater_id ASC";
            DataSet ds = db.DB_Select(sql, "theater");
            if (ds.Tables.Contains("theater"))
            {
                cmbTheater.DataSource = ds.Tables["theater"];
                cmbTheater.DisplayMember = "theater_name";
                cmbTheater.ValueMember = "theater_id";
            }
        }

        private void LoadAdmins()
        {
            string sql = "SELECT admin_id, name || ' (' || position || ')' AS admin_info FROM admin ORDER BY admin_id ASC";
            DataSet ds = db.DB_Select(sql, "admin");
            if (ds.Tables.Contains("admin"))
            {
                cmbAdmin.DataSource = ds.Tables["admin"];
                cmbAdmin.DisplayMember = "admin_info";
                cmbAdmin.ValueMember = "admin_id";
            }
        }

        private void LoadSchedules()
        {
            string sql = @"
                SELECT s.schedule_id AS 스케줄ID,
                       s.movie_id AS 영화ID,
                       m.movie_name AS 영화제목,
                       s.theater_id AS 상영관ID,
                       t.theater_name AS 상영관,
                       s.admin_id AS 관리자ID,
                       a.name AS 담당자,
                       TO_CHAR(s.screening_date, 'YYYY-MM-DD') AS 상영일자,
                       s.screening_round AS 회차,
                       s.start_time AS 시작시간,
                       s.end_time AS 종료시간
                FROM screening_schedule s
                JOIN movie m ON s.movie_id = m.movie_id
                JOIN theater t ON s.theater_id = t.theater_id
                LEFT JOIN admin a ON s.admin_id = a.admin_id
                ORDER BY s.screening_date DESC, s.schedule_id ASC";

            DataSet ds = db.DB_Select(sql, "schedule");
            if (ds.Tables.Contains("schedule"))
            {
                dgvSchedule.DataSource = ds.Tables["schedule"];
            }
        }

        // 영화 선택 및 시작시간(HH:mm) 입력 시 러닝타임을 더해 종료시간 자동 계산
        private void AutoCalculateEndTime(object sender, EventArgs e)
        {
            if (cmbMovie.SelectedItem is DataRowView drv &&
                TimeSpan.TryParseExact(txtStartTime.Text.Trim(), @"hh\:mm", CultureInfo.InvariantCulture, out TimeSpan start))
            {
                if (int.TryParse(drv["상영시간"].ToString(), out int runMinutes))
                {
                    TimeSpan end = start.Add(TimeSpan.FromMinutes(runMinutes));
                    txtEndTime.Text = $"{end.Hours:D2}:{end.Minutes:D2}";
                }
            }
        }

        // ================= [영화 CRUD] =================
        private void dgvMovie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvMovie.Rows[e.RowIndex];
            txtMovieId.Text = row.Cells["영화ID"].Value.ToString();
            txtMovieName.Text = row.Cells["영화제목"].Value.ToString();
            txtGenre.Text = row.Cells["장르"].Value.ToString();
            txtRunningTime.Text = row.Cells["상영시간"].Value.ToString();
            cmbAgeRating.Text = row.Cells["관람등급"].Value?.ToString() ?? "전체관람가";
            txtDirector.Text = row.Cells["감독"].Value?.ToString() ?? "";

            if (DateTime.TryParse(row.Cells["개봉일"].Value?.ToString(), out DateTime relDate))
                dtpReleaseDate.Value = relDate;

            txtMovieId.ReadOnly = true;
        }

        private void btnMovieAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMovieId.Text) ||
                string.IsNullOrWhiteSpace(txtMovieName.Text) ||
                string.IsNullOrWhiteSpace(txtGenre.Text) ||
                !int.TryParse(txtRunningTime.Text.Trim(), out int runTime))
            {
                MessageBox.Show("필수 항목(영화ID, 영화제목, 장르, 상영시간 숫자)을 정확히 입력하세요.");
                return;
            }

            string relDateStr = dtpReleaseDate.Value.ToString("yyyy-MM-dd");
            string sql = $@"
                INSERT INTO movie (movie_id, movie_name, genre, running_time, age_rating, release_date, director)
                VALUES ({txtMovieId.Text.Trim()}, '{txtMovieName.Text.Trim()}', '{txtGenre.Text.Trim()}', {runTime}, '{cmbAgeRating.Text}', TO_DATE('{relDateStr}', 'YYYY-MM-DD'), '{txtDirector.Text.Trim()}')";

            if (db.DB_Execute(sql) > 0)
            {
                MessageBox.Show("영화가 등록되었습니다.");
                ClearMovieInputs();
                LoadMovies();
            }
        }

        private void btnMovieUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMovieId.Text) || !int.TryParse(txtRunningTime.Text.Trim(), out int runTime))
            {
                MessageBox.Show("수정할 영화를 선택하고 상영시간을 숫자로 입력하세요.");
                return;
            }

            string relDateStr = dtpReleaseDate.Value.ToString("yyyy-MM-dd");
            string sql = $@"
                UPDATE movie
                SET movie_name = '{txtMovieName.Text.Trim()}',
                    genre = '{txtGenre.Text.Trim()}',
                    running_time = {runTime},
                    age_rating = '{cmbAgeRating.Text}',
                    release_date = TO_DATE('{relDateStr}', 'YYYY-MM-DD'),
                    director = '{txtDirector.Text.Trim()}'
                WHERE movie_id = {txtMovieId.Text.Trim()}";

            if (db.DB_Execute(sql) > 0)
            {
                MessageBox.Show("영화 정보가 수정되었습니다.");
                ClearMovieInputs();
                LoadMovies();
                LoadSchedules();
            }
        }

        private void btnMovieDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMovieId.Text))
            {
                MessageBox.Show("삭제할 영화를 선택하세요.");
                return;
            }

            if (MessageBox.Show("선택한 영화를 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = $"DELETE FROM movie WHERE movie_id = {txtMovieId.Text.Trim()}";
                if (db.DB_Execute(sql) > 0)
                {
                    MessageBox.Show("영화가 삭제되었습니다.");
                    ClearMovieInputs();
                    LoadMovies();
                }
            }
        }

        private void btnMovieClear_Click(object sender, EventArgs e) => ClearMovieInputs();

        private void ClearMovieInputs()
        {
            txtMovieId.Clear();
            txtMovieName.Clear();
            txtGenre.Clear();
            txtRunningTime.Clear();
            cmbAgeRating.SelectedIndex = 0;
            dtpReleaseDate.Value = DateTime.Today;
            txtDirector.Clear();
            txtMovieId.ReadOnly = false;
        }

        // ================= [상영 스케줄 CRUD] =================
        private void dgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvSchedule.Rows[e.RowIndex];
            txtScheduleId.Text = row.Cells["스케줄ID"].Value.ToString();
            cmbMovie.SelectedValue = row.Cells["영화ID"].Value;
            cmbTheater.SelectedValue = row.Cells["상영관ID"].Value;
            if (row.Cells["관리자ID"].Value != DBNull.Value)
                cmbAdmin.SelectedValue = row.Cells["관리자ID"].Value;

            if (DateTime.TryParse(row.Cells["상영일자"].Value?.ToString(), out DateTime sDate))
                dtpScreeningDate.Value = sDate;

            txtRound.Text = row.Cells["회차"].Value.ToString();
            txtStartTime.Text = row.Cells["시작시간"].Value.ToString();
            txtEndTime.Text = row.Cells["종료시간"].Value.ToString();
            txtScheduleId.ReadOnly = true;
        }

        private bool TryNormalizeTimeRange(string startText, string endText, out TimeSpan start, out TimeSpan end, out string errorMessage)
        {
            start = TimeSpan.Zero;
            end = TimeSpan.Zero;
            errorMessage = null;

            string[] formats = { @"hh\:mm", @"h\:mm" };
            if (!TimeSpan.TryParseExact(startText, formats, CultureInfo.InvariantCulture, out start) ||
                !TimeSpan.TryParseExact(endText, formats, CultureInfo.InvariantCulture, out end))
            {
                errorMessage = "시작시간과 종료시간은 HH:mm 형식으로 입력하세요. (예: 09:30, 14:00)";
                return false;
            }

            if (end == start)
            {
                errorMessage = "시작시간과 종료시간이 같을 수 없습니다.";
                return false;
            }

            if (end < start)
            {
                // 20시 이후 시작 ~ 익일 06시 이전 종료는 심야 상영(자정 넘김)으로 허용
                if (start.Hours >= 20 && end.Hours < 6)
                {
                    end = end.Add(TimeSpan.FromHours(24));
                }
                else
                {
                    errorMessage = "종료시간은 시작시간보다 늦어야 합니다.";
                    return false;
                }
            }

            return true;
        }

        // 같은 상영관의 겹치는 상영 시간대 존재 여부 검사 (자정 넘김 심야 상영 포함)
        private bool HasScheduleConflict(int theaterId, DateTime screeningDate, TimeSpan start, TimeSpan end, int? excludeScheduleId, out string errorMessage)
        {
            errorMessage = null;

            DateTime reqStart = screeningDate.Date.Add(start);
            DateTime reqEnd = screeningDate.Date.Add(end);

            string prevDateStr = screeningDate.AddDays(-1).ToString("yyyy-MM-dd");
            string nextDateStr = screeningDate.AddDays(1).ToString("yyyy-MM-dd");
            string excludeClause = excludeScheduleId.HasValue ? $" AND s.schedule_id <> {excludeScheduleId.Value}" : "";

            string sql = $@"
                SELECT s.schedule_id,
                       m.movie_name,
                       TO_CHAR(s.screening_date, 'YYYY-MM-DD') AS screening_date,
                       s.screening_round,
                       s.start_time,
                       s.end_time
                FROM screening_schedule s
                JOIN movie m ON s.movie_id = m.movie_id
                WHERE s.theater_id = {theaterId}
                  AND TRUNC(s.screening_date) BETWEEN TO_DATE('{prevDateStr}', 'YYYY-MM-DD') AND TO_DATE('{nextDateStr}', 'YYYY-MM-DD')
                  {excludeClause}";

            DataSet ds = db.DB_Select(sql, "conflict");
            if (!ds.Tables.Contains("conflict"))
            {
                errorMessage = "기존 상영 스케줄 중복 여부를 확인하지 못했습니다.";
                return true;
            }

            string[] formats = { @"hh\:mm", @"h\:mm" };
            foreach (DataRow row in ds.Tables["conflict"].Rows)
            {
                string exDateStr = row["screening_date"]?.ToString();
                string exStartStr = row["start_time"]?.ToString()?.Trim();
                string exEndStr = row["end_time"]?.ToString()?.Trim();

                if (!DateTime.TryParse(exDateStr, out DateTime exDate) ||
                    !TimeSpan.TryParseExact(exStartStr, formats, CultureInfo.InvariantCulture, out TimeSpan exStart) ||
                    !TimeSpan.TryParseExact(exEndStr, formats, CultureInfo.InvariantCulture, out TimeSpan exEnd))
                {
                    continue;
                }

                if (exEnd <= exStart)
                    exEnd = exEnd.Add(TimeSpan.FromHours(24));

                DateTime existStart = exDate.Date.Add(exStart);
                DateTime existEnd = exDate.Date.Add(exEnd);

                // 두 구간 [reqStart, reqEnd)와 [existStart, existEnd) 겹침 판정
                if (reqStart < existEnd && existStart < reqEnd)
                {
                    errorMessage =
                        "같은 상영관에 겹치는 시간대의 상영 스케줄이 이미 존재합니다.\n\n" +
                        $"- 기존 스케줄ID: {row["schedule_id"]}\n" +
                        $"- 영화제목: {row["movie_name"]}\n" +
                        $"- 상영일시: {exDateStr} {exStartStr} ~ {exEndStr} ({row["screening_round"]}회차)";
                    return true;
                }
            }

            return false;
        }

        private void btnSchedAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtScheduleId.Text.Trim(), out int scheduleId) ||
                cmbMovie.SelectedValue == null ||
                cmbTheater.SelectedValue == null ||
                !int.TryParse(txtRound.Text.Trim(), out int round) ||
                string.IsNullOrWhiteSpace(txtStartTime.Text) ||
                string.IsNullOrWhiteSpace(txtEndTime.Text))
            {
                MessageBox.Show("스케줄 필수 항목(스케줄ID 숫자, 영화, 상영관, 회차 숫자, 시작/종료시간)을 입력하세요.");
                return;
            }

            if (!TryNormalizeTimeRange(txtStartTime.Text.Trim(), txtEndTime.Text.Trim(), out TimeSpan start, out TimeSpan end, out string timeErr))
            {
                MessageBox.Show(timeErr, "시간 입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int theaterId = Convert.ToInt32(cmbTheater.SelectedValue);
            if (HasScheduleConflict(theaterId, dtpScreeningDate.Value, start, end, null, out string conflictMsg))
            {
                MessageBox.Show(conflictMsg, "상영 시간 중복", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string adminVal = cmbAdmin.SelectedValue != null ? cmbAdmin.SelectedValue.ToString() : "NULL";
            string sDateStr = dtpScreeningDate.Value.ToString("yyyy-MM-dd");
            string startStr = $"{start.Hours:D2}:{start.Minutes:D2}";
            string endStr = $"{end.Hours:D2}:{end.Minutes:D2}";

            string sql = $@"
                INSERT INTO screening_schedule (schedule_id, movie_id, theater_id, admin_id, screening_date, screening_round, start_time, end_time)
                VALUES ({scheduleId}, {cmbMovie.SelectedValue}, {theaterId}, {adminVal}, TO_DATE('{sDateStr}', 'YYYY-MM-DD'), {round}, '{startStr}', '{endStr}')";

            if (db.DB_Execute(sql) > 0)
            {
                MessageBox.Show("상영 스케줄이 등록되었습니다.");
                ClearScheduleInputs();
                LoadSchedules();
            }
        }

        private void btnSchedUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtScheduleId.Text.Trim(), out int scheduleId) ||
                cmbMovie.SelectedValue == null ||
                cmbTheater.SelectedValue == null ||
                !int.TryParse(txtRound.Text.Trim(), out int round) ||
                string.IsNullOrWhiteSpace(txtStartTime.Text) ||
                string.IsNullOrWhiteSpace(txtEndTime.Text))
            {
                MessageBox.Show("수정할 스케줄을 선택하고 필수 항목(회차 숫자, 시작/종료시간)을 입력하세요.");
                return;
            }

            if (!TryNormalizeTimeRange(txtStartTime.Text.Trim(), txtEndTime.Text.Trim(), out TimeSpan start, out TimeSpan end, out string timeErr))
            {
                MessageBox.Show(timeErr, "시간 입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int theaterId = Convert.ToInt32(cmbTheater.SelectedValue);
            if (HasScheduleConflict(theaterId, dtpScreeningDate.Value, start, end, scheduleId, out string conflictMsg))
            {
                MessageBox.Show(conflictMsg, "상영 시간 중복", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string adminVal = cmbAdmin.SelectedValue != null ? cmbAdmin.SelectedValue.ToString() : "NULL";
            string sDateStr = dtpScreeningDate.Value.ToString("yyyy-MM-dd");
            string startStr = $"{start.Hours:D2}:{start.Minutes:D2}";
            string endStr = $"{end.Hours:D2}:{end.Minutes:D2}";

            string sql = $@"
                UPDATE screening_schedule
                SET movie_id = {cmbMovie.SelectedValue},
                    theater_id = {theaterId},
                    admin_id = {adminVal},
                    screening_date = TO_DATE('{sDateStr}', 'YYYY-MM-DD'),
                    screening_round = {round},
                    start_time = '{startStr}',
                    end_time = '{endStr}'
                WHERE schedule_id = {scheduleId}";

            if (db.DB_Execute(sql) > 0)
            {
                MessageBox.Show("상영 스케줄이 수정되었습니다.");
                ClearScheduleInputs();
                LoadSchedules();
            }
        }

        private void btnSchedDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtScheduleId.Text))
            {
                MessageBox.Show("삭제할 스케줄을 선택하세요.");
                return;
            }

            if (MessageBox.Show("선택한 상영 스케줄을 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = $"DELETE FROM screening_schedule WHERE schedule_id = {txtScheduleId.Text.Trim()}";
                if (db.DB_Execute(sql) > 0)
                {
                    MessageBox.Show("상영 스케줄이 삭제되었습니다.");
                    ClearScheduleInputs();
                    LoadSchedules();
                }
            }
        }

        private void btnSchedClear_Click(object sender, EventArgs e) => ClearScheduleInputs();

        private void ClearScheduleInputs()
        {
            txtScheduleId.Clear();
            dtpScreeningDate.Value = DateTime.Today;
            txtRound.Clear();
            txtStartTime.Clear();
            txtEndTime.Clear();
            txtScheduleId.ReadOnly = false;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.DB_Close();
            Form2 mainForm = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            mainForm?.LoadScheduleList("", "");
        }
    }
}