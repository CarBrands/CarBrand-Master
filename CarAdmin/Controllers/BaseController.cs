#region Version Info
/*******************************************************
 * 作者 : yyj
 *
 * 时间 : 2017/7/10 14:39:43
 *
 * 版本 : V1.0.0
 *******************************************************
 * 修改者:
 * 说明 :
 *******************************************************/
#endregion

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Common;

namespace CarAdmin.Controllers
{
    public class BaseController : Controller
    {
        public static readonly int InPageSize = Convert.ToInt32(ConfigurationManager.AppSettings["InPageSize"]);

        public static bool CheckCurrentPageIndex(int curpageindex)
        {
            int cur = 0;

            return false;
        }
    }
}




   
