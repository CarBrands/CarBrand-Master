#region Version Info
/*******************************************************
 * 作者 : yyj
 *
 * 时间 : 2017/7/3 15:27:18
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
    ///C_BrandIntroduction数据实体
    /// </summary>
    public class C_BrandIntroductionEntity
    {
        #region 变量定义
        ///<summary>
        ///
        ///</summary>
        private int _iD;
        ///<summary>
        ///
        ///</summary>
        private DateTime _foundTime;
        ///<summary>
        ///
        ///</summary>
        private string _brandExplain = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _brandContent = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private string _brandHostory = String.Empty;
        ///<summary>
        ///
        ///</summary>
        private int _masterBrandID;
        ///<summary>
        ///
        ///</summary>
        private DateTime _updateTime;
        ///<summary>
        ///
        ///</summary>
        private DateTime _createTime;
        #endregion

        #region 构造函数

        ///<summary>
        ///
        ///</summary>
        public C_BrandIntroductionEntity()
        {
        }
        ///<summary>
        ///
        ///</summary>
        public C_BrandIntroductionEntity
        (
            int iD,
            DateTime foundTime,
            string brandExplain,
            string brandContent,
            string brandHostory,
            int masterBrandID,
            DateTime updateTime,
            DateTime createTime
        )
        {
            _iD = iD;
            _foundTime = foundTime;
            _brandExplain = brandExplain;
            _brandContent = brandContent;
            _brandHostory = brandHostory;
            _masterBrandID = masterBrandID;
            _updateTime = updateTime;
            _createTime = createTime;

        }
        #endregion

        #region 公共属性


        ///<summary>
        ///
        ///</summary>
        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public DateTime FoundTime
        {
            get { return _foundTime; }
            set { _foundTime = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string BrandExplain
        {
            get { return _brandExplain; }
            set { _brandExplain = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string BrandContent
        {
            get { return _brandContent; }
            set { _brandContent = value; }
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
        public int MasterBrandID
        {
            get { return _masterBrandID; }
            set { _masterBrandID = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public DateTime UpdateTime
        {
            get { return _updateTime; }
            set { _updateTime = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public DateTime CreateTime
        {
            get { return _createTime; }
            set { _createTime = value; }
        }

        #endregion

    }
}
