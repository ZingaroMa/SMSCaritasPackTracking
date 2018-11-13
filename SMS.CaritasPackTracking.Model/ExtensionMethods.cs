using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Linq.Expressions;

namespace SMS.CaritasPackTracking.Model
{
    public static class ExtensionMethods
    {
        public static TResult NextId<TSource, TResult>(this ObjectSet<TSource> table, Expression<Func<TSource, TResult>> selector)
            where TSource : class
        {
            TResult lastId = table.Any() ? table.Max(selector) : default(TResult);

            if (lastId is int)
            {
                lastId = (TResult)(object)(((int)(object)lastId) + 1);
            }
            return lastId;
        }
    }
}
