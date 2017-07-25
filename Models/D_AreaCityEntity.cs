#region Version Info
/*******************************************************
 * 作者 : yyj
 *
 * 时间 : 2017/7/3 15:29:35
 *
 * 版本 : V1.0.0
 *******************************************************
 * 修改者:
 * 说明 :
 *******************************************************/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    ///D_AreaCity数据实体
    /// </summary>
    public class D_AreaCityEntity
    {
        #region 变量定义
        ///<summary>
        ///
        ///</summary>
        private long _iD;
        ///<summary>
        ///
        ///</summary>
        private string _cityName = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _zipCode = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private long _provinceID;
        #endregion

        #region 构造函数

        ///<summary>
        ///
        ///</summary>
        public D_AreaCityEntity()
        {
        }
        ///<summary>
        ///
        ///</summary>
        public D_AreaCityEntity
        (
            long iD,
            string cityName,
            string zipCode,
            long provinceID
        )
        {
            _iD = iD;
            _cityName = cityName;
            _zipCode = zipCode;
            _provinceID = provinceID;

        }
        #endregion

        #region 公共属性


        ///<summary>
        ///
        ///</summary>
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string CityName
        {
            get { return _cityName; }
            set { _cityName = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public long ProvinceID
        {
            get { return _provinceID; }
            set { _provinceID = value; }
        }

        #endregion

    }
}
