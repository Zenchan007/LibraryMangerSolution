using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace DAL
{
    public class BookDAL : DataAccessDAL
    {
        
        public static int maxPage;
        public async Task<DataSet> getDataBook(string bookName, string author, string category, string status, int pageIndex, int pageSize)
        {
            int countSize = 0;
            try
            {
                using (SqlCommand myCommand = new SqlCommand())
                {
                    myCommand.Connection = await ConnectionAsync();
                    myCommand.CommandText = "FilterBookPaging";
                    myCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    myCommand.Parameters.Add("@PageIndex", SqlDbType.Int);
                    myCommand.Parameters.Add("@PageSize", SqlDbType.Int);
                    myCommand.Parameters.Add("@BookName", SqlDbType.NVarChar);
                    myCommand.Parameters.Add("@Author", SqlDbType.NVarChar);
                    myCommand.Parameters.Add("@Category", SqlDbType.NVarChar);
                    myCommand.Parameters.Add("@Status", SqlDbType.NVarChar);
                    myCommand.Parameters.Add("@RecordCount", SqlDbType.Int).Direction = ParameterDirection.Output;
                    myCommand.Parameters["@PageIndex"].Value = pageIndex + 1;
                    myCommand.Parameters["@PageSize"].Value = pageSize;
                    myCommand.Parameters["@BookName"].Value = bookName;
                    myCommand.Parameters["@Author"].Value = author;
                    myCommand.Parameters["@Category"].Value = category;
                    myCommand.Parameters["@Status"].Value = status;
                    await myCommand.ExecuteNonQueryAsync();
                    countSize = Convert.ToInt32(myCommand.Parameters["@RecordCount"].Value);
                    if(countSize % pageSize == 0)
                    {
                        maxPage = (int)countSize / pageSize;
                    }
                    else
                    {
                        maxPage = countSize / pageSize + 1;
                    }
                    using (var myAdapter = new SqlDataAdapter())
                    {
                        myAdapter.SelectCommand = myCommand;
                        DataSet dts = new DataSet();
                        myAdapter.Fill(dts);
                        closeConnection();
                        return dts;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
