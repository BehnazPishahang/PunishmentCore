using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.Commons.ServiceModel.ServicePaging
{
    public interface IPage<T>
    {
        public T Data { get; set; }
        public Page Paged { get; set; }

    }

    public interface IPage
    {
        public int TotallPage { get; set; }

        public int TotalResult { get; set; }

        public int RowCountPerPage { get; set; }
        public int PageNumber { get; set; }
        public OrderPage OrderPage { get; set; }

    }

    public class Page<T> : IPage<T>
    {
        public Page()
        { }

        public Page(T data, Page paged)
        {
            this.Data = data;
            this.Paged = paged;
        }
        public T Data { get; set; }
        public Page Paged { get; set; }
    }

    public class Page : IPage
    {
        public Page()
        {
            this.TotallPage = 0;
            this.TotalResult = 0;
            this.RowCountPerPage = 10;
            this.PageNumber = 1;
            this.OrderPage = new OrderPage();
        }


        public int TotallPage { get; set; }
        public int TotalResult { get; set; }
        public int RowCountPerPage { get; set; } = 10;
        public int PageNumber { get; set; } = 1;
        public OrderPage OrderPage { get; set; }
    }


    public class OrderPage
    {
        public string Property { get; set; }
        public bool Ascending { get; set; }
    }
}
