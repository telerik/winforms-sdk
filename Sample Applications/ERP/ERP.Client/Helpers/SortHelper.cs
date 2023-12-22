using ERP.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Services.Client;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.Data;

namespace ERP.Client
{
    public static class SortHelper
    {
        public static DataServiceQuery<T> Sort<T>(DataServiceQuery<T> queryable, SortDescriptorCollection sortDescriptors) where T : ISavableObject
        {
            DataServiceQuery<T> query = queryable;
            bool isFirst = true;

            if (sortDescriptors != null)
            {
                foreach (var descriptor in sortDescriptors)
                {
                    var property = query.ElementType.GetProperty(descriptor.PropertyName);
                    var parameter = Expression.Parameter(query.ElementType, "srt");
                    var propertyAccess = Expression.MakeMemberAccess(parameter, property);
                    var expression = Expression.Lambda(propertyAccess, parameter);

                    string methodName = string.Empty;

                    if (isFirst)
                    {
                        methodName = descriptor.Direction == ListSortDirection.Ascending ? "OrderBy" : "OrderByDescending";
                        isFirst = false;
                    }
                    else
                    {
                        methodName = descriptor.Direction == ListSortDirection.Ascending ? "ThenBy" : "ThenByDescending";
                    }
                    var exp = Expression.Call(typeof(Queryable), methodName, new[] { query.ElementType, expression.Body.Type }, query.Expression, Expression.Quote(expression));

                    query = query.Provider.CreateQuery(exp) as DataServiceQuery<T>;
                }
            }

            return query;
        }
    }
}
