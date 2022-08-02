using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.Commons.ServiceModel.ServicePaging
{
    public interface IPage
    {
        public int TotallPage { get; set; }
        public int RowCountPerPage { get; set; }
        public int PageNumber { get; set; }
    }

    public class Page : IPage
    {
        public Page()
        {
            this.TotallPage = 0;
            this.RowCountPerPage = 10;
            this.PageNumber = 1;
            this.OrderPage = new OrderPage();
        }
        public int TotallPage { get; set; }
        public int RowCountPerPage { get; set; }
        public int PageNumber { get; set; }
        public OrderPage OrderPage { get; set; }
    }

    public class OrderPage
    {
        public string Property { get; set; }
        public bool Ascending { get; set; }
    }
}
