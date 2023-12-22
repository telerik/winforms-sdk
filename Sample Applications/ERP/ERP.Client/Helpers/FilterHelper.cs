using ERP.Repository;
using System;
using System.Collections.Generic;
using System.Data.Services.Client;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.Data;

namespace ERP.Client
{
    public static class FilterHelper
    {
        private static readonly MethodInfo StringStartsWithMethodInfo = typeof(string).GetMethod("StartsWith", new[] { typeof(string) });
        private static readonly MethodInfo StringEndsWithMethodInfo = typeof(string).GetMethod("EndsWith", new[] { typeof(string) });
        private static readonly MethodInfo StringContainsMethodInfo = typeof(string).GetMethod("Contains", new[] { typeof(string) });

        public static DataServiceQuery<T> Filter<T>(DataServiceQuery<T> queryable, FilterDescriptorCollection filters) where T : ISavableObject
        {
            DataServiceQuery<T> query = queryable;

            if (filters != null && filters.Count > 0)
            {

                Expression predicate = FilterHelper.BuildFilter(query.ElementType, filters);
                var exp = Expression.Call(typeof(Queryable), "Where", new[] { query.ElementType }, query.Expression, Expression.Quote(predicate));
                query = query.Provider.CreateQuery(exp) as DataServiceQuery<T>;
            }

            return query;
        }

        private static LambdaExpression BuildFilter(Type elementType, FilterDescriptorCollection filters)
        {
            ParameterExpression pe = Expression.Parameter(elementType, "fltr");
            Expression expression = null;

            foreach (FilterDescriptor filter in filters)
            {
                PropertyInfo pi = elementType.GetProperty(filter.PropertyName);
                if (filter.Value == null)
                {


                    if (pi.PropertyType.IsValueType)
                    {
                        filter.Value = Activator.CreateInstance(pi.PropertyType);
                    }
                }
                if (filter.GetType() != pi.PropertyType)
                {
                    filter.Value = Convert.ChangeType(filter.Value, pi.PropertyType);
                }

                Expression value = Expression.Constant(filter.Value);
                Expression property = Expression.Property(pe, filter.PropertyName);
                Expression comparison = null;

                switch (filter.Operator)
                {
                    case FilterOperator.None:
                        comparison = Expression.Empty();
                        break;
                    case FilterOperator.IsLessThan:
                        comparison = Expression.LessThan(property, value);
                        break;
                    case FilterOperator.IsLessThanOrEqualTo:
                        comparison = Expression.LessThanOrEqual(property, value);
                        break;
                    case FilterOperator.IsEqualTo:
                    case FilterOperator.IsLike:
                        comparison = Expression.Equal(property, value);
                        break;
                    case FilterOperator.IsNotEqualTo:
                    case FilterOperator.IsNotLike:
                        comparison = Expression.NotEqual(property, value);
                        break;
                    case FilterOperator.IsGreaterThanOrEqualTo:
                        comparison = Expression.GreaterThanOrEqual(property, value);
                        break;
                    case FilterOperator.IsGreaterThan:
                        comparison = Expression.GreaterThan(property, value);
                        break;
                    case FilterOperator.StartsWith:
                        comparison = FilterHelper.GenerateStringMethodCall(StringStartsWithMethodInfo, property, value);
                        break;
                    case FilterOperator.EndsWith:
                        comparison = FilterHelper.GenerateStringMethodCall(StringEndsWithMethodInfo, property, value);
                        break;
                    case FilterOperator.Contains:
                    case FilterOperator.IsContainedIn:
                        comparison = FilterHelper.GenerateStringMethodCall(StringContainsMethodInfo, property, value);
                        break;
                    case FilterOperator.NotContains:
                    case FilterOperator.IsNotContainedIn:
                        comparison = Expression.Not(FilterHelper.GenerateStringMethodCall(StringContainsMethodInfo, property, value));
                        break;
                    case FilterOperator.IsNull:
                        comparison = Expression.Equal(property, Expression.Constant(null));
                        break;
                    case FilterOperator.IsNotNull:
                        comparison = Expression.NotEqual(property, Expression.Constant(null));
                        break;
                }

                if (expression == null)
                {
                    expression = comparison;

                    continue;
                }

                if (filters.LogicalOperator == FilterLogicalOperator.And)
                {
                    expression = Expression.AndAlso(expression, comparison);
                }
                else
                {
                    expression = Expression.OrElse(expression, comparison);
                }
            }

            return Expression.Lambda(expression, pe);
        }

        private static Expression GenerateStringMethodCall(MethodInfo methodInfo, Expression left, Expression right)
        {
            if (methodInfo.IsStatic)
            {
                return Expression.Call(methodInfo, new[] { left, right });
            }

            if (IsNullLiteral(left))
            {
                left = Expression.Constant(string.Empty);
            }

            return Expression.Call(left, methodInfo, right);
        }

        private static bool IsNullLiteral(Expression expression)
        {
            ConstantExpression constantExpression = expression as ConstantExpression;

            if (constantExpression != null)
            {
                return constantExpression.Value == null;
            }

            return false;
        }
    }
}
