#region Version Info
/*******************************************************
 * 作者 : yyj
 *
 * 时间 : 2017/7/3 15:25:42
 *
 * 版本 : V1.0.0
 *******************************************************
 * 修改者:
 * 说明 :
 *******************************************************/
#endregion

using System;

namespace Models
{
    /// <summary>
    ///C_CarMasterBrand数据实体
    /// </summary>
    public class C_CarMasterBrandEntity
    {
        #region 变量定义
        ///<summary>
        ///
        ///</summary>
        private int _masterBrandID;
        ///<summary>
        ///
        ///</summary>
        private string _masterBrandName = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _masterBrandOtherName = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _brandEnName = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _masterBrandLogo = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _allSpells = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private int _countryID;
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
        public C_CarMasterBrandEntity()
        {
        }
        ///<summary>
        ///
        ///</summary>
        public C_CarMasterBrandEntity
        (
            int masterBrandID,
            string masterBrandName,
            string masterBrandOtherName,
            string brandEnName,
            string masterBrandLogo,
            string allSpells,
            int countryID,
            DateTime createTime,
            DateTime updateTime
        )
        {
            _masterBrandID = masterBrandID;
            _masterBrandName = masterBrandName;
            _masterBrandOtherName = masterBrandOtherName;
            _brandEnName = brandEnName;
            _masterBrandLogo = masterBrandLogo;
            _allSpells = allSpells;
            _countryID = countryID;
            _createTime = createTime;
            _updateTime = updateTime;

        }
        #endregion

        #region 公共属性


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
        public string MasterBrandName
        {
            get { return _masterBrandName; }
            set { _masterBrandName = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string MasterBrandOtherName
        {
            get { return _masterBrandOtherName; }
            set { _masterBrandOtherName = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string BrandEnName
        {
            get { return _brandEnName; }
            set { _brandEnName = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string MasterBrandLogo
        {
            get { return _masterBrandLogo; }
            set { _masterBrandLogo = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string AllSpells
        {
            get { return _allSpells; }
            set { _allSpells = value; }
        }

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
