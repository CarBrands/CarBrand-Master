#region Version Info
/*******************************************************
 * 作者 : yyj
 *
 * 时间 : 2017/7/3 15:30:23
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
    ///D_AreaDistrict数据实体
    /// </summary>
    public class D_AreaDistrictEntity
    {
        #region 变量定义
        ///<summary>
        ///
        ///</summary>
        private long _iD;
        ///<summary>
        ///
        ///</summary>
        private string _districtName = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private long _cityID;
        #endregion

        #region 构造函数

        ///<summary>
        ///
        ///</summary>
        public D_AreaDistrictEntity()
        {
        }
        ///<summary>
        ///
        ///</summary>
        public D_AreaDistrictEntity
        (
            long iD,
            string districtName,
            long cityID
        )
        {
            _iD = iD;
            _districtName = districtName;
            _cityID = cityID;

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
        public string DistrictName
        {
            get { return _districtName; }
            set { _districtName = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public long CityID
        {
            get { return _cityID; }
            set { _cityID = value; }
        }

        #endregion

    }
}
