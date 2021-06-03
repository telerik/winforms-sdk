using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Telerik.Data.Expressions;

namespace VirtualRadGridViewSortingFiltering.Core
{
    public class ExpressionParser
    {
        private delegate ExpressionNode ParseDelegate(string expression, bool caseSensitive);
        private static ParseDelegate parse;

        static ExpressionParser()
        {
            foreach (Assembly telerikAssembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                Type expressionParserType = telerikAssembly.GetType("Telerik.Data.Expressions.ExpressionParser");
                if (expressionParserType != null)
                {
                    MethodInfo parseMethod = expressionParserType.GetMethod("Parse");
                    parse = (ParseDelegate)Delegate.CreateDelegate(typeof(ParseDelegate), parseMethod);
                    return;
                }
            }
        }

        public static ExpressionNode Parse(string expression, bool caseSensitive)
        {
            return parse(expression, caseSensitive);
        }
    }
}
