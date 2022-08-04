using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Commons.ServiceModel.ServiceResponseEnumerations;
using Anu.Oracle.DbContext;
using System.Linq.Expressions;
using Utility.Exceptions;

namespace Anu.Utility.Linq
{
    public static class CustomLinq
    {
        public static IOrderedQueryable<TSource> PageOrderBy<TSource>(this IQueryable<TSource> source, OrderPage order)
        {
            var property = typeof(TSource).GetProperty(order.Property);

            if (property == null)
            {
                throw new AnuExceptions(AnuResult.PropertyOrderNotFound);
            }

            var type = property.PropertyType;

            if (type == typeof(int))
            {
                return source.AnuOrderBy(IQueryableExtensions.ToExpression<TSource, int>(order.Property),order.Ascending);
            }
            else if (type == typeof(long))
            {
                return source.AnuOrderBy(IQueryableExtensions.ToExpression<TSource, long>(order.Property), order.Ascending);
            }
            else
            {
                return source.AnuOrderBy(IQueryableExtensions.ToExpression<TSource, string>(order.Property), order.Ascending);
            }
        }

        public static IOrderedQueryable<TSource> AnuOrderBy<TSource,TKey>(this IQueryable<TSource> source, Expression<Func<TSource, TKey>> exp, bool Asc)
        {          
            if (Asc)
            {
                return source.OrderBy(exp);
            }
            else
            {
                return source.OrderByDescending(exp);
            }
        }

        public static IQueryable<TSource> AnuPagination<TSource>(this IQueryable<TSource> source, Page page)
        {
            return source
                .PageOrderBy(page.OrderPage)
                .Skip((page.PageNumber - 1) * page.RowCountPerPage)
                .Take(page.RowCountPerPage);
        }


    }
}
