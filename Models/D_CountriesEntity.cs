#region Version Info
/*******************************************************
 * 作者 : yyj
 *
 * 时间 : 2017/7/3 15:32:08
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
    ///D_Countries数据实体
    /// </summary>
    public class D_CountriesEntity
    {
        #region 变量定义
        ///<summary>
        ///
        ///</summary>
        private int _countryID;
        ///<summary>
        ///
        ///</summary>
        private string _name = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _code = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _otherName = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _logoUrl = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _area = String.Empty;
        #endregion

        #region 构造函数

        ///<summary>
        ///
        ///</summary>
        public D_CountriesEntity()
        {
        }
        ///<summary>
        ///
        ///</summary>
        public D_CountriesEntity
        (
            int countryID,
            string name,
            string code,
            string otherName,
            string logoUrl,
            string area
        )
        {
            _countryID = countryID;
            _name = name;
            _code = code;
            _otherName = otherName;
            _logoUrl = logoUrl;
            _area = area;

        }
        #endregion

        #region 公共属性


        ///<summary>
        ///
        ///</summary>
        public int CountryID
        {
            get { return _countryID; }
            set { _countryID = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string OtherName
        {
            get { return _otherName; }
            set { _otherName = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string LogoUrl
        {
            get { return _logoUrl; }
            set { _logoUrl = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string Area
        {
            get { return _area; }
            set { _area = value; }
        }

        #endregion

    }
}
