using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Anu.Oracle.DbContext
{
    public static class IQueryableExtensions
    {
        public static MemberExpression GetMemberAccessExpression(ParameterExpression parameter, string path)
        {
            var type = parameter.Type;
            var pNames = path.Split('.');
            Expression exp = parameter;
            foreach (var pn in pNames)
            {
                var member = type.GetProperty(pn);
                if (member is null)
                {
                    throw new MemberAccessException($"{path} is invalid.");
                }
                else
                {
                    exp = System.Linq.Expressions.Expression.MakeMemberAccess(exp, member);
                    type = member.PropertyType;
                }

            }
            return (MemberExpression)exp;
        }

        public static IQueryable<TSource> EqualTo<TSource>(this IQueryable<TSource> query, string left, string right)
        {
            var type = query.GetType().GenericTypeArguments[0];
            var p = System.Linq.Expressions.Expression.Parameter(type, "x");
            var exp1 = GetMemberAccessExpression(p, left);
            var exp2 = GetMemberAccessExpression(p, right);
            var exp3 = System.Linq.Expressions.Expression.Equal(exp1, exp2);
            var r = System.Linq.Expressions.Expression.Lambda<Func<TSource, bool>>(exp3, p);
            return query.Where(r);
        }

        public static IQueryable<TSource> EqualToValue<TSource>(this IQueryable<TSource> query, string left, object value)
        {
            var type = query.GetType().GenericTypeArguments[0];
            var p = System.Linq.Expressions.Expression.Parameter(type, "x");
            var exp1 = GetMemberAccessExpression(p, left);
            var exp2 = System.Linq.Expressions.Expression.Constant(value);
            var exp3 = System.Linq.Expressions.Expression.Equal(exp1, exp2);
            var r = System.Linq.Expressions.Expression.Lambda<Func<TSource, bool>>(exp3, p);
            return query.Where(r);
        }

        public static Expression<Func<TEntity, TResult>> Expression<TEntity, TResult>(Expression<Func<TEntity, TResult>> predicate)
        {
            return predicate;
        }

        public static Expression<Func<TEntity, TResult>> ToExpression<TEntity, TResult>(this string path)
        {
            var type = typeof(TEntity);
            var p = System.Linq.Expressions.Expression.Parameter(type, "x");
            var pNames = path.Split('.');
            Expression pExp = p;
            foreach (var pn in pNames)
            {
                var member = type.GetProperty(pn);
                if (member is null)
                {
                    throw new MemberAccessException($"{path} is invalid.");
                }
                else
                {
                    pExp = System.Linq.Expressions.Expression.MakeMemberAccess(pExp, member);
                    type = member.PropertyType;
                }

            }
            var r = System.Linq.Expressions.Expression.Lambda<Func<TEntity, TResult>>(pExp, p);
            return r;
        }


        public static string? Path<TEntity>(Expression<Func<TEntity, object>> predicate)
        {
            StringBuilder path = new StringBuilder();
            var exp = predicate.Body;
            while (exp is MemberExpression)
            {
                if (path.Length > 0)
                {
                    path.Insert(0, ".");
                }
                var memberExp = (MemberExpression)exp;
                path.Insert(0, memberExp.Member.Name);

                exp = memberExp.Expression;
            }
            //var p = (ParameterExpression)exp;

            return path.ToString();
        }

    }
    public enum Operators
    {
        EqualTo = 0,
        NotEqualTo = 1,
        GreaterThan = 2,
        LessThan = 3,
        GreaterThanOrEqual = 4,
        LessThanOrEqual = 5,

    }
}
