#region Version Info
/*******************************************************
 * 作者 : yyj
 *
 * 时间 : 2017/7/3 15:36:14
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
using Models;

namespace DAL
{
    public class D_CountriesDAL
    {
        public DataSet GetDataSet(int currentIndex, int pageSize)
        {
            string strSql = @"SELECT * FROM (SELECT *,ROW_NUMBER() OVER(ORDER BY CountryID) AS ID FROM dbo.D_Countries) AS
Countrys WHERE ID BETWEEN (@PageIndex-1)*@PageSize+1 AND @PageIndex*@PageSize;SELECT COUNT(*) FROM dbo.D_Countries";
            var parms = new SqlParameter[]
            {
                new SqlParameter("@PageIndex",SqlDbType.Int){ Value=currentIndex },
                new SqlParameter("@PageSize",SqlDbType.Int){ Value=pageSize },
            };
            var dt = SqlHelper.GetDataSet(SqlHelper.ConStr, CommandType.Text, strSql, parms);
            return dt;
        }

        public DataTable GetCountryBycId(int cId)
        {
            string strSql = @"SELECT * FROM dbo.D_Countries WHERE CountryID=@CountryID";
            var parms = new SqlParameter[]
            {
                new SqlParameter("@CountryID",SqlDbType.Int){ Value=cId }
            };
            var obj = SqlHelper.GetDataSet(SqlHelper.ConStr, CommandType.Text, strSql, parms).Tables[0];
            if (obj != null && obj.Rows.Count > 0)
                return obj;
            return null;
        }

        public bool EditCountryBycId(D_CountriesEntity model)
        {
            string strSql = @"
UPDATE [dbo].[D_Countries]
   SET [Name] = @cName
      ,[Code] = @cCode
      ,[OtherName] = @cOtherName
      ,[LogoUrl] = @cLogoUrl
      ,[Area] = @cArea
 WHERE CountryID=@CountryID";
            var parms = new SqlParameter[]
            {
                new SqlParameter("@cName",SqlDbType.VarChar){ Value=model.Name }
                ,new SqlParameter("@cCode",SqlDbType.VarChar){ Value=model.Code }
                ,new SqlParameter("@cOtherName",SqlDbType.VarChar){ Value=model.OtherName }
                ,new SqlParameter("@cLogoUrl",SqlDbType.VarChar){ Value=model.LogoUrl }
                ,new SqlParameter("@cArea",SqlDbType.VarChar){ Value=model.Area }
                ,new SqlParameter("@CountryID",SqlDbType.Int){ Value=model.CountryID }
            };
            var val = SqlHelper.ExecuteNonQuery(SqlHelper.ConStr, CommandType.Text, strSql, parms);
            return val>0?true:false;
        }
    }
}
