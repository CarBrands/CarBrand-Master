#region Version Info
/*******************************************************
 * 作者 : yyj
 *
 * 时间 : 2017/7/3 15:28:25
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
    ///C_CarBrand数据实体
    /// </summary>
    public class C_CarBrandEntity
    {
        #region 变量定义
        ///<summary>
        ///
        ///</summary>
        private int _brandID;
        ///<summary>
        ///
        ///</summary>
        private int _masterBrandID;
        ///<summary>
        ///
        ///</summary>
        private string _brandName = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _brandSiteUrl = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _brandPhone = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _introduction = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _logoHostory = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _brandHostory = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _brandLogo = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _brandLogoTwo = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _spell = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private DateTime _createTime;
        ///<summary>
        ///
        ///</summary>
        private DateTime _updateTime;
        #endregion

        #region 构造函数

        ///<summary>
        ///
        ///</summary>
        public C_CarBrandEntity()
        {
        }
        ///<summary>
        ///
        ///</summary>
        public C_CarBrandEntity
        (
            int brandID,
            int masterBrandID,
            string brandName,
            string brandSiteUrl,
            string brandPhone,
            string introduction,
            string logoHostory,
            string brandHostory,
            string brandLogo,
            string brandLogoTwo,
            string spell,
            DateTime createTime,
            DateTime updateTime
        )
        {
            _brandID = brandID;
            _masterBrandID = masterBrandID;
            _brandName = brandName;
            _brandSiteUrl = brandSiteUrl;
            _brandPhone = brandPhone;
            _introduction = introduction;
            _logoHostory = logoHostory;
            _brandHostory = brandHostory;
            _brandLogo = brandLogo;
            _brandLogoTwo = brandLogoTwo;
            _spell = spell;
            _createTime = createTime;
            _updateTime = updateTime;

        }
        #endregion

        #region 公共属性


        ///<summary>
        ///
        ///</summary>
        public int BrandID
        {
            get { return _brandID; }
            set { _brandID = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public int MasterBrandID
        {
            get { return _masterBrandID; }
            set { _masterBrandID = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string BrandName
        {
            get { return _brandName; }
            set { _brandName = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string BrandSiteUrl
        {
            get { return _brandSiteUrl; }
            set { _brandSiteUrl = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string BrandPhone
        {
            get { return _brandPhone; }
            set { _brandPhone = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string Introduction
        {
            get { return _introduction; }
            set { _introduction = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string LogoHostory
        {
            get { return _logoHostory; }
            set { _logoHostory = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string BrandHostory
        {
            get { return _brandHostory; }
            set { _brandHostory = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string BrandLogo
        {
            get { return _brandLogo; }
            set { _brandLogo = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string BrandLogoTwo
        {
            get { return _brandLogoTwo; }
            set { _brandLogoTwo = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string Spell
        {
            get { return _spell; }
            set { _spell = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public DateTime CreateTime
        {
            get { return _createTime; }
            set { _createTime = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public DateTime UpdateTime
        {
            get { return _updateTime; }
            set { _updateTime = value; }
        }

        #endregion
		
    }
}
