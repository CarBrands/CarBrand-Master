#region Version Info
/*******************************************************
 * 作者 : yyj
 *
 * 时间 : 2017/7/11 15:48:21
 *
 * 版本 : V1.0.0
 *******************************************************
 * 修改者:
 * 说明 :
 *******************************************************/
#endregion

using System.Web;
using System.Web.Mvc;
using CarAdmin.Models;
using Common;

namespace CarAdmin.Controllers.Extensions
{
    public static class ShowPager
    {
        public static HtmlString PageHelper(this HtmlHelper html, int currentPage, int pageSize, int totalCount)
        {
            return new HtmlString(PagerHelper.Pageer(currentPage, pageSize, totalCount));
        }

        public static HtmlString PageHelper(this HtmlHelper html, PagerInfo pager)
        {
            return new HtmlString(PagerHelper.Pageer(pager.CurrentPageIndex, pager.PageSize, pager.TotalCount));
        }
    }
}