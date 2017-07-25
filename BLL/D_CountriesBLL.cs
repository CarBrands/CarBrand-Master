#region Version Info
/*******************************************************
 * 作者 : yyj
 *
 * 时间 : 2017/7/3 15:42:26
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
    public class D_CountriesBLL
    {
        //创建对象
        private readonly D_CountriesDAL _dalCountries =
            AbstractFactory.CreateDaoInstance<D_CountriesDAL>("D_CountriesDAL");
        public DataSet GetDateSet(int currentIndex, int pageSize)
        {
            return _dalCountries.GetDataSet(currentIndex,pageSize);
        }

        public DataTable GetCountryBycId(int cId)
        {
            return _dalCountries.GetCountryBycId(cId);
        }
    }
}
