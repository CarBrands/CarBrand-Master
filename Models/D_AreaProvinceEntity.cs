#region Version Info
/*******************************************************
 * 作者 : yyj
 *
 * 时间 : 2017/7/3 15:31:28
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
    ///D_AreaProvince数据实体
    /// </summary>
    public class D_AreaProvinceEntity
    {
        #region 变量定义
        ///<summary>
        ///
        ///</summary>
        private long _iD;
        ///<summary>
        ///
        ///</summary>
        private string _provinceName = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private int _countryID;
        #endregion

        #region 构造函数

        ///<summary>
        ///
        ///</summary>
        public D_AreaProvinceEntity()
        {
        }
        ///<summary>
        ///
        ///</summary>
        public D_AreaProvinceEntity
        (
            long iD,
            string provinceName,
            int countryID
        )
        {
            _iD = iD;
            _provinceName = provinceName;
            _countryID = countryID;

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
        public string ProvinceName
        {
            get { return _provinceName; }
            set { _provinceName = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public int CountryID
        {
            get { return _countryID; }
            set { _countryID = value; }
        }

        #endregion

    }
}
