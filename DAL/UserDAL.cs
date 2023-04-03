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
        public async Task<SqlDataReader> UserHaveExist(string eMail)
        {
            eMail = eMail.ToLower();
            using (SqlCommand myCommand = new SqlCommand())
            {
                myCommand.Connection = await openConnection();
                myCommand.CommandText = $"SELECT u.Mail, u.Pass FROM [USER] AS u WHERE u.Mail = '{eMail}'";
                var reader = await myCommand.ExecuteReaderAsync();
                if (reader.HasRows)
                {
                    return reader;
                }
                closeConnection();
                return null;
            }
        }

        //public async Task<bool> CheckAccount(string eMail, string Pass, CancellationToken cancellationToken)
        //{
        //    try
        //    {
        //        Thread.Sleep(5000);
        //        if (cancellationToken.IsCancellationRequested)
        //        {
        //            cancellationToken.ThrowIfCancellationRequested();
                    
        //        }
        //        var reader = await UserHaveExist(eMail);
        //        if (reader != null)
        //        {
        //            while (await reader.ReadAsync())
        //            {
        //                if (Pass == reader.GetString(1))
        //                {
        //                    return true;
        //                }
        //                else
        //                {
        //                    throw new Exception("Incorrect password");
        //                };
        //            }
        //        }
        //        else
        //        {
        //            throw new Exception("Please check your account information");
        //        }
                
        //    }
        //    catch (Exception e)
        //    {

        //        throw e;
        //    }
        //    finally
        //    {
        //        closeConnection();
        //    }
        //    return false;
        //}
        public async Task<bool> CheckAccount(string eMail, string Pass)
        {
            try
            {
                var reader = await UserHaveExist(eMail);
                if (reader != null)
                {
                    while (await reader.ReadAsync())
                    {
                        if (Pass == reader.GetString(1))
                        {
                            return true;
                        }
                        else
                        {
                            throw new Exception("Incorrect password");
                        };
                    }
                }
                else
                {
                    throw new Exception("Please check your account information");
                }

            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                closeConnection();
            }
            return false;
        }
        public async Task InsertUserDAL(string userName, string eMail, string passWord)
        {
            using (SqlCommand myCommand = new SqlCommand())
            {
                myCommand.Connection = await openConnection();
                myCommand.CommandType = CommandType.Text;
                myCommand.CommandText = String.Format($"Insert into [USER] (Mail, Name, Pass) values ('{eMail}', '{userName}', '{passWord}')");
                myCommand.Connection = conn;
                await myCommand.ExecuteNonQueryAsync();
                closeConnection();
            }
        }
    }

}
