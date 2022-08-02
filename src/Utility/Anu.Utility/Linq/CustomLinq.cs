using Anu.Commons.ServiceModel.ServicePaging;
using Anu.Oracle.DbContext;
using System.Linq.Expressions;
using Utility.Exceptions;

namespace Anu.Utility.Linq
{
    public static class CustomLinq
    {
        public static IOrderedQueryable<TSource> PageOrderBy<TSource>(this IQueryable<TSource> source, OrderPage order, Enum NotFoundProperty)
        {
            //var property = typeof(TSource).GetProperty(order.Property);
            //var type = property.PropertyType;

            var exp = IQueryableExtensions.ToExpression<TSource, string>(order.Property);

            //if (property.PropertyType == typeof(int))
            //{
            //    exp = IQueryableExtensions.ToExpression<TSource, int>(order.Property);
            //}
            //else if (property.PropertyType == typeof(long))
            //{
            //    exp = IQueryableExtensions.ToExpression<TSource, long>(order.Property);
            //}
            //else
            //{
            //    exp = IQueryableExtensions.ToExpression<TSource, string>(order.Property);
            //}

            //if (!source.Any(exp=> exp.Equals(order.Property)))
            //{
            //    throw new AnuExceptions(NotFoundProperty);
            //}


            if (order.Ascending)
            {
                return source.OrderBy(exp);
            }
            else
            {
                return source.OrderByDescending(exp);
            }

        }

    }
}
