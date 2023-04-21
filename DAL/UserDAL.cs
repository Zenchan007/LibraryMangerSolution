using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace DAL
{
    public class UserDAL : DataAccessDAL
    {
        public async Task<SqlDataReader> GetUserReader(string eMail, CancellationToken cts = default) 
        {
            if (cts.IsCancellationRequested)
            {
                cts.ThrowIfCancellationRequested();
            }
            eMail = eMail.ToLower();
            using (SqlCommand myCommand = new SqlCommand())
            {
                myCommand.Connection = await ConnectionAsync(cts);
                myCommand.CommandText = $"SELECT u.Mail, u.Pass FROM [USER] AS u WHERE u.Mail = '{eMail}'";
                var reader = await myCommand.ExecuteReaderAsync();
                if (reader.HasRows)
                {
                  return reader;
                }
                return null;
            }
        }

        public async Task<bool> CheckAccountHaveExist(string eMail, CancellationToken cts = default)
        {
            var reader = await GetUserReader(eMail, cts);
            if(reader == null)
            {
                return false;
            }
            return true;
        }
        
        
        public async Task<bool> CheckAccounInfomationt(string eMail, string Pass, CancellationToken cts = default)
        {
            if (cts.IsCancellationRequested)
            {
                cts.ThrowIfCancellationRequested();
            }
            var reader = await GetUserReader(eMail, cts);
            if (reader != null)
            {
                while (await reader.ReadAsync())
                {
                    if (Pass == reader.GetString(1))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public async Task InsertUserDAL(string userName, string eMail, string passWord, CancellationToken cts = default)
        {
            using (SqlCommand myCommand = new SqlCommand())
            {
                myCommand.Connection = await ConnectionAsync(cts);  
                myCommand.CommandType = CommandType.Text;
                myCommand.CommandText = String.Format($"Insert into [USER] (Mail, Name, Pass) values ('{eMail}', '{userName}', '{passWord}')");
                await myCommand.ExecuteNonQueryAsync();
                closeConnection();
            }
        }
    }

}
