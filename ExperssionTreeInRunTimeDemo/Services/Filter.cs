using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq.Expressions;
using System.Reflection;

namespace ExperssionTreeInRunTimeDemo.Services
{
     public  static class  Filter
    {
         public static IQueryable<TEntity>Search<TEntity>(this IQueryable<TEntity> query,string ColumnName, string Value) where TEntity : class
        {
            ColumnName = ColumnName.ToLower();
            var actualColumnName = typeof(TEntity).GetProperties().FirstOrDefault(p => p.Name.ToLower() == ColumnName)?.Name;
            if (actualColumnName == null)
            {
                throw new ArgumentException("coulmn not found");
            }
            var paramter  = Expression.Parameter(typeof(TEntity), "paramter");
            var propertyExp = Expression.Property(paramter, actualColumnName);
            MethodInfo method = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            var someValue = Expression.Constant(Value, typeof(string));
            var containmethod= Expression.Call(propertyExp, method, someValue);
            var finalExpression = Expression.Lambda<Func<TEntity, bool>>(containmethod, paramter);
            return query.Where(finalExpression);
        }
    }
}
