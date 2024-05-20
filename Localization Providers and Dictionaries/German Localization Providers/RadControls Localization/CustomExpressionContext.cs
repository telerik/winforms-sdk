using System;
using Telerik.Data.Expressions;

namespace GermanRadControlsLocalization
{
    public class CustomExpressionContext : ExpressionContext
    {
        /// <summary>
        /// Custom function, which returns Pi.
        /// </summary>
        /// <returns></returns>
        public double Pi()
        {
            return Math.PI;
        }
    }
}
