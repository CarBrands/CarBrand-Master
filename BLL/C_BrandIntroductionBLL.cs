#region Version Info
/*******************************************************
 * 作者 : yyj
 *
 * 时间 : 2017/7/31 11:31:38
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

namespace BLL
{
    /// <summary>
    /// 品牌介绍
    /// </summary>
    public class C_BrandIntroductionBLL
    {
        //创建对象
        private readonly C_BrandIntroductionDAL _dalBrandIntr = AbstractFactory.CreateDaoInstance<C_BrandIntroductionDAL>("C_BrandIntroductionDAL");
        /// <summary>
        /// 获取主品牌介绍分页列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetDataSet(int currentIndex, int pageSize)
        {
            return _dalBrandIntr.GetDataSet(currentIndex, pageSize);
        }
    }
}
