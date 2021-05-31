using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ServerSideDropDownList.Core
{
    public class ExpressionBuilder
    {
        private static ExpressionBuilder instance;
        private static readonly object syncRoot = new object();
        private HashSet<Type> optimizationCache = new HashSet<Type>();

        public static ExpressionBuilder Instance
        {
            get
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        lock (syncRoot)
                        {
                            instance = new ExpressionBuilder();
                        }
                    }
                }

                return instance;
            }
        }

        public bool Optimize<T>(IQueryable<T> collection)
        {
            if (this.optimizationCache.Contains(typeof(T)))
            {
                return false;
            }

            this.optimizationCache.Add(typeof(T));
            collection.ToList();
            return true;
        }

        public Expression<Func<T, TResult>> BuildMethodCallExpression<T, TResult>(string parameter, string property, Type ownerType, 
            string methodName, int parametersCount)
        {
            var param = Expression.Parameter(typeof(T));
            var constant = Expression.Constant(parameter);
            var prop = Expression.Property(param, property);
            var method = ownerType.GetMethods().First(x => x.Name == methodName && x.GetParameters().Length == parametersCount);
            var body = Expression.Call(prop, method, constant);

            return Expression.Lambda<Func<T, TResult>>(body, param);
        }

        public Expression<Func<T, bool>> BuildContainsExpression<T>(string property, string filter)
        {
            var dataItemsExp = this.BuildMethodCallExpression<T, bool>(filter, property, typeof(String), "Contains", 1);
            return dataItemsExp;
        }

        public Expression<Func<T, string>> BuildSelectExpression<T>(string property)
        {
            var param = Expression.Parameter(typeof(T));
            var prop = Expression.Property(param, property);
            var expression = Expression.Lambda<Func<T, string>>(prop, param);
            return expression;
        }

        public Expression<Func<T, bool>> BuildStartsWithExpression<T>(string property, string filter)
        {
            var lambda = this.BuildMethodCallExpression<T, bool>(filter, property, typeof(String), "StartsWith", 1);
            var newBody = Expression.And(lambda.Body,
                Expression.NotEqual(Expression.Property(lambda.Parameters.First(), property), Expression.Constant(filter)));
            var newExpression = Expression.Lambda<Func<T, bool>>(newBody, lambda.Parameters);

            return newExpression;
        }

    }
}
