using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Telerik.WinControls.Data;

namespace ERP.Client
{
    public static class FilterHelper
    {
        private static readonly MethodInfo StringStartsWithMethodInfo = typeof(string).GetMethod("StartsWith", new[] { typeof(string) });
        private static readonly MethodInfo StringEndsWithMethodInfo = typeof(string).GetMethod("EndsWith", new[] { typeof(string) });
        private static readonly MethodInfo StringContainsMethodInfo = typeof(string).GetMethod("Contains", new[] { typeof(string) });

        public static List<T> Filter<T>(List<T> queryable, FilterDescriptorCollection filters) where T : class
        {
            if (queryable == null || queryable.Count == 0)
            {
                return queryable ?? new List<T>();
            }

            if (filters == null || filters.Count == 0)
            {
                return queryable;
            }

            try
            {
                // Build the filter expression
                LambdaExpression predicate = FilterHelper.BuildFilter(typeof(T), filters);
                
                // Compile the lambda expression to a delegate
                var compiledPredicate = predicate.Compile() as Func<T, bool>;
                
                if (compiledPredicate == null)
                {
                    return queryable;
                }
                
                // Apply the filter using LINQ Where
                List<T> filteredList = queryable.Where(compiledPredicate).ToList();
                
                return filteredList;
            }
            catch (Exception)
            {
                // If filtering fails, return the original list
                return queryable;
            }
        }



        private static LambdaExpression BuildFilter(Type elementType, FilterDescriptorCollection filters)
        {
            ParameterExpression pe = Expression.Parameter(elementType, "fltr");
            Expression expression = null;

            foreach (FilterDescriptor filter in filters)
            {
                if (string.IsNullOrEmpty(filter.PropertyName))
                {
                    continue;
                }

                PropertyInfo pi = elementType.GetProperty(filter.PropertyName);
                if (pi == null)
                {
                    // Handle navigational properties (e.g., "Vendor.Name")
                    if (filter.PropertyName.Contains("."))
                    {
                        string[] parts = filter.PropertyName.Split('.');
                        Expression property = pe;
                        Type currentType = elementType;
                        
                        foreach (string part in parts)
                        {
                            PropertyInfo prop = currentType.GetProperty(part);
                            if (prop == null)
                            {
                                break;
                            }

                            property = Expression.Property(property, prop);
                            currentType = prop.PropertyType;
                        }
                        
                        if (currentType != elementType)
                        {
                            Expression comparison = BuildComparison(property, currentType, filter);
                            expression = CombineExpressions(expression, comparison, filters.LogicalOperator);
                        }
                    }

                    continue;
                }
                
                Expression filterComparison = BuildComparison(Expression.Property(pe, filter.PropertyName), pi.PropertyType, filter);
                expression = CombineExpressions(expression, filterComparison, filters.LogicalOperator);
            }

            if (expression == null)
            {
                // Return a predicate that always returns true
                expression = Expression.Constant(true);
            }

            return Expression.Lambda(expression, pe);
        }

        private static Expression BuildComparison(Expression property, Type propertyType, FilterDescriptor filter)
        {
            object filterValue = filter.Value;
            
            // Handle null values
            if (filter.Operator == FilterOperator.IsNull)
            {
                return Expression.Equal(property, Expression.Constant(null, propertyType));
            }
            
            if (filter.Operator == FilterOperator.IsNotNull)
            {
                return Expression.NotEqual(property, Expression.Constant(null, propertyType));
            }
            
            // Convert filter value to property type
            if (filterValue == null)
            {
                if (propertyType.IsValueType && Nullable.GetUnderlyingType(propertyType) == null)
                {
                    filterValue = Activator.CreateInstance(propertyType);
                }
            }
            else if (filterValue.GetType() != propertyType)
            {
                Type targetType = Nullable.GetUnderlyingType(propertyType) ?? propertyType;
                try
                {
                    filterValue = Convert.ChangeType(filterValue, targetType);
                }
                catch
                {
                    // If conversion fails, use the original value
                }
            }

            Expression value = Expression.Constant(filterValue, propertyType);
            Expression comparison = null;

            switch (filter.Operator)
            {
                case FilterOperator.None:
                    comparison = Expression.Constant(true);
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
                default:
                    comparison = Expression.Constant(true);
                    break;
            }

            return comparison;
        }

        private static Expression CombineExpressions(Expression left, Expression right, FilterLogicalOperator logicalOperator)
        {
            if (left == null)
            {
                return right;
            }

            if (right == null)
            {
                return left;
            }

            if (logicalOperator == FilterLogicalOperator.And)
            {
                return Expression.AndAlso(left, right);
            }
            else
            {
                return Expression.OrElse(left, right);
            }
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
