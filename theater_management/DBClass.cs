using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace theater_management
{
    public partial class DBClass
    {
        // App.config의 connectionStrings에서 연결 문자열을 읽어옵니다
        private string connStr = ConfigurationManager.ConnectionStrings["OracleDB"].ConnectionString;

        public OracleConnection Con { get; set; }
        public OracleCommand DCom { get; set; }
        public OracleDataAdapter DA { get; set; }
        public DataSet DS { get; set; }

        public void DB_Open()
        {
            try
            {
                if (Con == null)
                    Con = new OracleConnection(connStr);
                if (Con.State != ConnectionState.Open)
                    Con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB 연결 실패: " + ex.Message);
            }
        }

        // 연결 해제
        public void DB_Close()
        {
            try
            {
                if (Con != null && Con.State == ConnectionState.Open)
                    Con.Close();
            }
            catch { }
        }

        // SELECT 조회 결과를 DataSet으로 반환
        public DataSet DB_Select(string sql, string tableName)
        {
            DS = new DataSet();
            try
            {
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

        // INSERT, UPDATE, DELETE 단일 실행
        public int DB_Execute(string sql)
        {
            int result = 0;
            try
            {
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

        // 여러 SQL을 하나의 트랜잭션으로 실행 (중간 실패 시 전체 롤백)
        public bool DB_ExecuteTransaction(List<string> sqlList)
        {
            DB_Open();
            if (Con == null || Con.State != ConnectionState.Open)
                return false;

            OracleTransaction tx = null;
            try
            {
                tx = Con.BeginTransaction();
                foreach (string sql in sqlList)
                {
                    OracleCommand cmd = new OracleCommand(sql, Con);
                    cmd.Transaction = tx;
                    cmd.ExecuteNonQuery();
                }
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tx?.Rollback();
                MessageBox.Show("처리 중 오류가 발생했습니다. 전체 작업이 취소됩니다.\n" + ex.Message);
                return false;
            }
        }
    }
}
