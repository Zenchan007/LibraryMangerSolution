using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class DataAccessDAL
    {
        protected SqlConnection conn;
        protected string strCon = @"Data Source=DESKTOP-Q5AEVAH\SQLEXPRESS;Initial Catalog=LibraryManage;Integrated Security=True";
        public DataAccessDAL()
        {
            conn = new SqlConnection(strCon);
        }
        public async Task<SqlConnection> openConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken || conn == null)
            {
                await conn.OpenAsync();
            }
            return conn;
        }

        public SqlConnection closeConnection()
        {
            if (conn != null || conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return conn;
        }
        public void Dispose_Connection()
        {
            conn.Dispose();
        }
    }
}
