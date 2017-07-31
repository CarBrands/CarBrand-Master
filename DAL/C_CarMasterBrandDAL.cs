#region Version Info
/*******************************************************
 * 作者 : yyj
 *
 * 时间 : 2017/7/26 11:27:24
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
    public class C_CarMasterBrandDAL
    {
        /// <summary>
        /// 获取主品牌分页列表
        /// </summary>
        /// <param name="currentIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public DataSet GetDataSet(int currentIndex, int pageSize)
        {
            string strSql = @"SELECT * FROM (SELECT *,ROW_NUMBER() OVER(ORDER BY MasterBrandID) AS ID FROM dbo.C_CarMasterBrand) AS
MasterBrand WHERE ID BETWEEN (@PageIndex-1)*@PageSize+1 AND @PageIndex*@PageSize;SELECT COUNT(*) FROM dbo.C_CarMasterBrand";
            var parms = new SqlParameter[]
            {
                new SqlParameter("@PageIndex",SqlDbType.Int){ Value=currentIndex },
                new SqlParameter("@PageSize",SqlDbType.Int){ Value=pageSize },
            };
            var dt = SqlHelper.GetDataSet(SqlHelper.ConStr, CommandType.Text, strSql, parms);
            return dt;
        }
        /// <summary>
        /// 修改主品牌信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool EditMasterBrand(C_CarMasterBrandEntity model)
        {
            string strSql = @"UPDATE [dbo].[C_CarMasterBrand]
   SET [MasterBrandName] = @MasterBrandName
      ,[MasterBrandOtherName] = @MasterBrandOtherName
      ,[BrandEnName] = @BrandEnName
      ,[MasterBrandLogo] = @MasterBrandLogo
      ,[AllSpells] = @AllSpells
      ,[CountryID] = @CountryID
      ,[CreateTime] = @CreateTime
      ,[UpdateTime] = @UpdateTime
 WHERE MasterBrandID=@MasterBrandID";
            var parms = new SqlParameter[]
            {
                new SqlParameter("@MasterBrandName",model.MasterBrandName),
                new SqlParameter("@MasterBrandOtherName",model.MasterBrandOtherName),
                new SqlParameter("@BrandEnName",model.BrandEnName),
                new SqlParameter("@MasterBrandLogo",model.MasterBrandLogo),
                new SqlParameter("@AllSpells",model.AllSpells),
                new SqlParameter("@CountryID",model.CountryID),
                new SqlParameter("@CreateTime",model.CreateTime),
                new SqlParameter("@UpdateTime",model.UpdateTime),
                new SqlParameter("@MasterBrandID",model.MasterBrandID)
            };
            var val = SqlHelper.ExecuteNonQuery(SqlHelper.ConStr, CommandType.Text, strSql, parms);
            return val>0?true:false;
        }
        /// <summary>
        /// 新增主品牌
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertMasterBrand(C_CarMasterBrandEntity model)
        {
            string strSql = @"INSERT INTO [dbo].[C_CarMasterBrand]
           ([MasterBrandName]
           ,[MasterBrandOtherName]
           ,[BrandEnName]
           ,[MasterBrandLogo]
           ,[AllSpells]
           ,[CountryID]
           ,[CreateTime]
           ,[UpdateTime])
     VALUES
           (@MasterBrandName
           ,@MasterBrandOtherName
           ,@BrandEnName
           ,@MasterBrandLogo
           ,@AllSpells
           ,@CountryID
           ,@CreateTime
           ,@UpdateTime)";
            var parms = new SqlParameter[]
            {
                new SqlParameter("@MasterBrandName",model.MasterBrandName),
                new SqlParameter("@MasterBrandOtherName",model.MasterBrandOtherName),
                new SqlParameter("@BrandEnName",model.BrandEnName),
                new SqlParameter("@MasterBrandLogo",model.MasterBrandLogo),
                new SqlParameter("@AllSpells",model.AllSpells),
                new SqlParameter("@CountryID",model.CountryID),
                new SqlParameter("@CreateTime",model.CreateTime),
                new SqlParameter("@UpdateTime",model.UpdateTime),
            };
            var val = SqlHelper.ExecuteNonQuery(SqlHelper.ConStr, CommandType.Text, strSql, parms);
            return val>0?true:false;
        }
    }
}
