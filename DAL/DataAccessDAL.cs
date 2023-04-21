using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Threading;
using System.Diagnostics;

namespace DAL
{
    public class DataAccessDAL
    {
        protected SqlConnection conn;
 
        public DataAccessDAL()
        {
        }
        public async Task<SqlConnection> ConnectionAsync(CancellationToken cts = default)
        {
            if (cts.IsCancellationRequested)
            {
                cts.ThrowIfCancellationRequested();
            }
            try
            {
                await Connect();
                await OpenConAsync(cts);
            }
            catch(Exception ex)
            {
                throw ex;
                Trace.WriteLine(ex.StackTrace); 
            }
            return conn;
        }
        public async Task<SqlConnection> Connect()
        {
            string strConn = @"Data Source=DESKTOP-Q5AEVAH\SQLEXPRESS;Initial Catalog=LibraryManage;Integrated Security=True";
            conn = new SqlConnection(strConn);
            return conn;
        }
        public async Task<SqlConnection> OpenConAsync(CancellationToken cts = default)
        {
            await Task.Delay(3000);
            if (cts.IsCancellationRequested)
            {
                cts.ThrowIfCancellationRequested();
            }
            if(conn!= null && (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken))
            {
                await conn.OpenAsync(cts);
            }
            return conn;
        }
        public SqlConnection closeConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
            return conn;
        }
        public void Dispose_Connection()
        {
            conn?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
