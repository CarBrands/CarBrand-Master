#region Version Info
/*******************************************************
 * 作者 : yyj
 *
 * 时间 : 2017/7/10 15:52:02
 *
 * 版本 : V1.0.0
 *******************************************************
 * 修改者:
 * 说明 :
 *******************************************************/
#endregion

using System;
using System.Text;
using System.Web;

namespace Common
{
    public static class PagerHelper
    {
        public static string Pageer(int currentPage, int pageSize, int totalCount)
        {
            var redirectToUrl = HttpContext.Current.Request.Url.AbsolutePath;
            pageSize = pageSize <= 0 ? 4 : pageSize;

            //1.0 总页数
            int totalPages = Math.Max((totalCount + pageSize - 1) / pageSize, 1);

            //2.0 分页条的��量
            int pageBarSize = 6;//默认一个分页条显示6个页码。分页条容量 

            //3.0 分页条的个数 totalPages个页数按 pageBarSize = 6  可以 分为多少个分页条
            int pageBarNum = (totalPages + pageBarSize - 1) / pageBarSize; // totalPages=13时，也就是把13个页码分成3个分页条

            //判断当前页currentPage坐落在第几个分页条内
            int position = (currentPage - 1) / pageBarSize;

            //根据分页条的序号，计算出该分页条的第一个页码start和最后一个页码end
            int start = position * pageBarSize + 1;

            //如果是最后一个分页条，则需判断它实际的页条容量；否则页条容量就是pageBarSize
            int curBarCapacity = pageBarSize;
            if (position == pageBarNum - 1)
            {
                curBarCapacity = totalPages - (pageBarNum - 1) * pageBarSize;
            }

            var pagerHtmlString = new StringBuilder();
            var endHtmlString = new StringBuilder();

            //处理首页
            pagerHtmlString.AppendFormat("<li id='start-page'><a href='{0}?pageIndex={1}'>首页</a></li> ", redirectToUrl, 1);

            //处理上一页:如果当前页不是第一页,就加上上一页
            if (currentPage > 1)
            {
                pagerHtmlString.AppendFormat("<li class='prev-page'><a href='{0}?pageIndex={1}'>上一页</a></li> ", redirectToUrl, currentPage - 1);
            }

            //假如起始位置start为1  7  13
            for (int i = 0; i < curBarCapacity; i++)  //curBarCapacity=3  i=0 1 2
            {
                int j = start + i; //要显示的页码当量值
                if (j == currentPage)
                {
                    //对当前页的处理:class=active
                    pagerHtmlString.AppendFormat("<li class='active show-page'><span>{0}</span></li> ", currentPage);

                    if (curBarCapacity == pageBarSize)
                    {
                        //不处理最后一个分页条页
                        if (currentPage == start + pageBarSize - 1)
                        {
                            if (currentPage + 1 < totalPages)
                            {
                                endHtmlString.AppendFormat("<li class='show-page'><a href='{0}?pageIndex={1}'>{2}</a></li>", redirectToUrl, currentPage + 1, currentPage + 1);
                            }
                            endHtmlString.Append("<li class='show-page'><span>...</span></li>");
                            endHtmlString.AppendFormat("<li class='show-page'><a href='{0}?pageIndex={1}'>{2}</a></li>", redirectToUrl, totalPages, totalPages);
                        }
                    }

                }
                else
                {
                    pagerHtmlString.AppendFormat("<li class='show-page'><a href='{0}?pageIndex={1}'>{2}</a></li> ", redirectToUrl, j, j);
                }
            }

            //省略号的处理
            pagerHtmlString.Append(endHtmlString.ToString());

            //处理下一页：如果当前页不是最后一页，则加上下一页。也即中间的所有分页条都显示下一页
            if (currentPage != totalPages)
            {
                pagerHtmlString.AppendFormat("<li class='next-page'><a href='{0}?pageIndex={1}'>下一页</a></li> ", redirectToUrl, currentPage + 1);
            }

            //处理末页
            pagerHtmlString.AppendFormat("<li id='end-page'><a href='{0}?pageIndex={1}'>末页</a></li> ", redirectToUrl, totalPages);

            pagerHtmlString.AppendFormat("<li id='total-page'><span>共-{0}-页</span></li>", totalPages);

            pagerHtmlString.Append(" ");

            return pagerHtmlString.ToString();
        }

        
    }
}