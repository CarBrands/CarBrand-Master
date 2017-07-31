#region Version Info
/*******************************************************
 * 作者 : yyj
 *
 * 时间 : 2017/7/31 11:43:48
 *
 * 版本 : V1.0.0
 *******************************************************
 * 修改者:
 * 说明 :
 *******************************************************/
#endregion

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DbHelper;

namespace DAL
{
    public class C_CarBrandDAL
    {
        /// <summary>
        /// 获取车品牌信息分页
        /// </summary>
        /// <param name="currentIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public DataSet GetDataSet(int currentIndex, int pageSize)
        {
            string strSql = @"SELECT  *
FROM    ( SELECT    * ,
                    ROW_NUMBER() OVER ( ORDER BY BrandID ) AS ID
          FROM      dbo.C_CarBrand
        ) AS CarBrand
WHERE   ID BETWEEN ( @PageIndex - 1 ) * @PageSize + 1
            AND     @PageIndex * @PageSize;
SELECT  COUNT(*)
FROM    dbo.C_CarBrand";
            var parms = new SqlParameter[]
            {
                new SqlParameter("@PageIndex",SqlDbType.Int){ Value=currentIndex },
                new SqlParameter("@PageSize",SqlDbType.Int){ Value=pageSize },
            };
            var dt = SqlHelper.GetDataSet(SqlHelper.ConStr, CommandType.Text, strSql, parms);
            return dt;
        }
    }
}
