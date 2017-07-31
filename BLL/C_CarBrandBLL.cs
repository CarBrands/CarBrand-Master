#region Version Info
/*******************************************************
 * 作者 : yyj
 *
 * 时间 : 2017/7/31 11:46:27
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
    public class C_CarBrandBLL
    {
        private readonly C_CarBrandBLL _objCarbrand=AbstractFactory.CreateDaoInstance<C_CarBrandBLL>("C_CarBrandBLL");

        /// <summary>
        /// 获取车品牌信息分页
        /// </summary>
        /// <param name="currentIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public DataSet GetDataSet(int currentIndex, int pageSize)
        {
            return _objCarbrand.GetDataSet(currentIndex, pageSize);
        }
    }
}
