using System;
using System.Collections.Generic;
using Telerik.Charting;

namespace _3DBarChart
{
    public class MyDataPointComparer : IComparer<DataPointModel>
    {
        public int Compare(DataPointModel x, DataPointModel y)
        {
            return x.Year > y.Year ? 1 : -1;
        }
    }
}
