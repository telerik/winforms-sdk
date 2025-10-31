using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Telerik.WinControls.Data;

namespace ERP.Client
{
    public static class SortHelper
    {
        public static List<T> Sort<T>(List<T> list, SortDescriptorCollection sortDescriptors)
        {
            if (list == null || sortDescriptors == null || sortDescriptors.Count == 0)
            {
                return list;
            }

            IOrderedEnumerable<T> orderedList = null;
            bool isFirst = true;

            foreach (var descriptor in sortDescriptors)
            {
                var property = typeof(T).GetProperty(descriptor.PropertyName);
                if (property == null)
                {
                    continue;
                }

                if (isFirst)
                {
                    if (descriptor.Direction == ListSortDirection.Ascending)
                    {
                        orderedList = list.OrderBy(x => property.GetValue(x, null));
                    }
                    else
                    {
                        orderedList = list.OrderByDescending(x => property.GetValue(x, null));
                    }

                    isFirst = false;
                }
                else
                {
                    if (descriptor.Direction == ListSortDirection.Ascending)
                    {
                        orderedList = orderedList.ThenBy(x => property.GetValue(x, null));
                    }
                    else
                    {
                        orderedList = orderedList.ThenByDescending(x => property.GetValue(x, null));
                    }
                }
            }

            return orderedList != null ? orderedList.ToList() : list;
        }
    }
}
