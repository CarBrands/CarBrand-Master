#region Version Info
/*******************************************************
 * 作者 : yyj
 *
 * 时间 : 2017/7/10 16:52:19
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
using System.Web;

namespace CarAdmin.Models
{
    public class PagerInfo
    {
        public int TotalCount { get; set; }

        public int CurrentPageIndex { get; set; }

        public int PageSize { get; set; }
    }
}