

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DbHelper
{
    /// <summary>
    /// 数据库连接
    /// </summary>
    public static class SqlHelper
    {
        /// <summary>
        /// 连接串
        /// </summary>
        public static readonly string ConStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        /// <summary>
        /// 增删改操作
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="cmdType"></param>
        /// <param name="cmdText"></param>
        /// <param name="parms"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string connectionString, CommandType cmdType, string sqlStr, params SqlParameter[] parms)
        {

            using (var conn = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand(sqlStr,conn))
                {
                    cmd.CommandText = sqlStr;
                    if (parms != null)
                        cmd.Parameters.AddRange(parms);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// 一行一列查询
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="cmdType"></param>
        /// <param name="cmdText"></param>
        /// <param name="parms"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string connectionString, CommandType cmdType, string sqlStr,
            params SqlParameter[] parms)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand(sqlStr,conn))
                {
                    cmd.CommandText = sqlStr;
                    if (parms != null)
                        cmd.Parameters.AddRange(parms);
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }
        /// <summary>
        /// 返回表集合查询
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="cmdType"></param>
        /// <param name="cmdText"></param>
        /// <param name="parms"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string connectionString, CommandType cmdType, string sqlStr,
            params SqlParameter[] parms)
        {
            var ds = new DataSet();
            using (var adapter = new SqlDataAdapter(sqlStr, ConStr))
            {
                adapter.SelectCommand.CommandType = cmdType;
                if (parms != null)
                    adapter.SelectCommand.Parameters.AddRange(parms);
                adapter.Fill(ds);
            }
            return ds;
        }
    }
}
