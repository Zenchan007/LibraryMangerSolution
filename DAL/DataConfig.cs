using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DAL
{
    public class DataConfig
    {

        private string strConnection = @"Data Source=DESKTOP-Q5AEVAH\SQLEXPRESS;Initial Catalog=LibraryManage;Integrated Security=True";
        private SqlConnection con = null;
        private SqlCommand cmd = new SqlCommand();
        private SqlDataAdapter adap = null;

        public DataConfig()
        {
            //if (checkConnection() == false)
            //    return;
        }

        private bool checkConnection()
        {
            try
            {
                con = new SqlConnection(strConnection);
                con.Open();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private async Task OpenConnectionAsync()
        {
            try
            {
                await OpenConnectionAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<DataTable> getData(string strSQL)
        {
            DataTable tb = new DataTable();
            await OpenConnectionAsync();
            adap = new SqlDataAdapter(strSQL, con);
            adap.Fill(tb);
            con.Close();
            adap.Dispose();
            return tb;
        }

        public void addParameter(SqlParameter param)
        {
            cmd.Parameters.Add(param);
        }

        public async Task<int> ExecuteNonQuery(string strSQL)
        {
            cmd.CommandText = strSQL;
            cmd.Connection = con;
            await OpenConnectionAsync();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
            return result;
        }

        public async Task<object> selectValue(string strSQL, string columnName)
        {
            cmd = new SqlCommand(strSQL, con);
            await OpenConnectionAsync();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            object result = reader[columnName];
            reader.Close();
            con.Close();
            return result;
        }



    }
}
