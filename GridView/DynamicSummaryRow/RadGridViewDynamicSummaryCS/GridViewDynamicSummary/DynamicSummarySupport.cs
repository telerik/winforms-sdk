
using System;
using System.ComponentModel;
using System.Reflection;
using Telerik.WinControls.UI;

namespace GridView
{
    /// <summary>Provides support for the RadgridViewDynamicSummary grid</summary>
    public class DynamicSummarySupport
    {
        /// <summary>
        /// Converts a Aggregate function into a GridAggregateFunction
        /// </summary>
        /// <param name="aggregateFunction">the aggregate function to convert</param>
        /// <returns>GridAggregateFunction</returns>
        public static GridAggregateFunction AggregateFunctionToGridAggregateFunction(AggregateFunction aggregateFunction)
        {
            switch (aggregateFunction)
            {
                case AggregateFunction.Avg:

                    return GridAggregateFunction.Avg;
                case AggregateFunction.Count:

                    return GridAggregateFunction.Count;
                case AggregateFunction.Max:

                    return GridAggregateFunction.Max;
                case AggregateFunction.Min:

                    return GridAggregateFunction.Min;
                case AggregateFunction.First:

                    return GridAggregateFunction.First;
                case AggregateFunction.Last:

                    return GridAggregateFunction.Last;
                case AggregateFunction.None:

                    return GridAggregateFunction.None;
                default:
                    return GridAggregateFunction.Sum;
            }
        }

        /// <summary>
        /// Gets the description attribute from the Aggregate Function enum
        /// </summary>
        /// <param name="en">the aggregate function enum</param>
        /// <returns>string description</returns>
        public static string GetEnumDescription(AggregateFunction en)
        {
            Type type = en.GetType();

            MemberInfo[] memInfo = type.GetMember(en.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return (en.ToString());
        }

        /// <summary>
        /// Returns the allowOnDateTimeColumn attribute from the Aggregate Function enum
        /// </summary>
        /// <param name="en">the aggregate function enum</param>
        /// <returns>allowOnDateTimeColumn boolean</returns>
        public static bool GetEnumAllowOnDateTimeColumn(AggregateFunction en)
        {
            Type type = en.GetType();

            MemberInfo[] memInfo = type.GetMember(en.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(AllowOnDateTimeColumnAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    return ((AllowOnDateTimeColumnAttribute)attrs[0]).AllowOnDateTimecolumn;
                }
            }

            return (false);
        }

    }

    /// <summary>Enum of possible aggregate functions</summary>
    public enum AggregateFunction
    {
        [Description("The average of ")]
        [AllowOnDateTimeColumn(false)]
        Avg,

        [Description("The count of ")]
        [AllowOnDateTimeColumn(true)]
        Count,

        [Description("The max of ")]
        [AllowOnDateTimeColumn(true)]
        Max,

        [Description("The min of ")]
        [AllowOnDateTimeColumn(true)]
        Min,

        [Description("The first of ")]
        [AllowOnDateTimeColumn(false)]
        First,

        [Description("The last of ")]
        [AllowOnDateTimeColumn(true)]
        Last,

        [Description("none")]
        [AllowOnDateTimeColumn(true)]
        None,

        [Description("The sum is: ")]
        [AllowOnDateTimeColumn(false)]
        Sum
    }

    /// <summary>Enum indicating if the summary row should be rendered at the top or the bottom</summary>
    public enum SummaryRowPosition
    {
        Top,
        Bottom
    }

}


