using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;//ADO.Net 개체 참조
using System.Data;  //DataSet 개체 참조
using System.Windows.Forms; //MessageBox 개체 참조

namespace theater_management
{
    public partial class DBClass
    {
        // 본인 Oracle 계정 및 포트/SID(xe 또는 orcl)에 맞게 수정하세요
        private string connStr = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)));";
        public OracleConnection Con { get; set; }
        public OracleCommand DCom { get; set; }
        public OracleDataAdapter DA { get; set; }
        public DataSet DS { get; set; }

        public void DB_Open()
        {
            try
            {
                Con = new OracleConnection(connStr);
                Con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB 연결 실패: " + ex.Message);
            }
        }

        // SELECT 조회 결과를 DataSet으로 반환
        public DataSet DB_Select(string sql, string tableName)
        {
            DS = new DataSet();
            try
            {
                if (Con == null || Con.State != ConnectionState.Open)
                    DB_Open();

                DA = new OracleDataAdapter(sql, Con);
                DA.Fill(DS, tableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("조회 오류: " + ex.Message);
            }
            return DS;
        }

        // INSERT, UPDATE, DELETE 실행
        public int DB_Execute(string sql)
        {
            int result = 0;
            try
            {
                if (Con == null || Con.State != ConnectionState.Open)
                    DB_Open();

                DCom = new OracleCommand(sql, Con);
                result = DCom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("실행 오류: " + ex.Message);
            }
            return result;
        }
    }
}
