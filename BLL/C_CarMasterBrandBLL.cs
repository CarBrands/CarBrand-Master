#region Version Info
/*******************************************************
 * 作者 : yyj
 *
 * 时间 : 2017/7/26 11:26:15
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using DAL;
using Models;

namespace BLL
{
    public class C_CarMasterBrandBLL
    {
        //创建对象
        private readonly C_CarMasterBrandDAL _dalMasterBrand = AbstractFactory.CreateDaoInstance<C_CarMasterBrandDAL>("C_CarMasterBrandDAL");

        /// <summary>
        /// 获取主品牌分页列表
        /// </summary>
        /// <param name="currentIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public DataSet GetDataSet(int currentIndex, int pageSize)
        {
            return _dalMasterBrand.GetDataSet(currentIndex,pageSize);
        }

        /// <summary>
        /// 新增主品牌
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertMasterBrand(C_CarMasterBrandEntity model)
        {
            return _dalMasterBrand.InsertMasterBrand(model);
        }

        /// <summary>
        /// 修改主品牌信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool EditMasterBrand(C_CarMasterBrandEntity model)
        {
            return _dalMasterBrand.EditMasterBrand(model);
        }
    }
}
