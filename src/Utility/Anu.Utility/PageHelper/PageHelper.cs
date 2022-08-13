using Anu.Commons.ServiceModel.ServicePaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Guard;

namespace Anu.Utility.Pagination
{
    public static class PageHelper
    {

        public static Page PageChecker(this Page page,string defualtOrderProperty)
        {
            if (!page.OrderPage.Null() || !page.OrderPage.Property.NullOrWhiteSpace())
            {
                page.OrderPage = new OrderPage() { Property = defualtOrderProperty, Ascending = true };
            }
            if (!page.RowCountPerPage.Null() || page.RowCountPerPage == 0)
            {
                page.RowCountPerPage = 10;
            }
            if (!page.PageNumber.Null() || page.PageNumber == 0)
            {
                page.PageNumber = 1;
            }

            return page;
        }

        public static Page CalculateAllPage(this Page page,int countAll)
        {
            if (countAll <= page.RowCountPerPage)
            {
                page.TotallPage = 1;
            }
            else
            {
                var a = (int)(countAll / page.RowCountPerPage);
                var b = a * page.RowCountPerPage;
                if (countAll - b != 0 && countAll - b < page.RowCountPerPage)
                {
                    a++;
                }
                page.TotallPage = a;
            }
            page.TotalResult = countAll;
            return page;
        }

    }
}
