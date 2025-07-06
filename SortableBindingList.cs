using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGamemastersChronicler
{
    public class SortableBindingList<T> : BindingList<T>
    {
        private bool isSortedValue;
        private ListSortDirection sortDirectionValue;
        private PropertyDescriptor sortPropertyValue;

        protected override bool SupportsSortingCore => true;

        protected override bool IsSortedCore => isSortedValue;

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            var itemsList = (List<T>)Items;

            var comparer = new PropertyComparer<T>(prop, direction);
            itemsList.Sort(comparer);

            isSortedValue = true;
            sortDirectionValue = direction;
            sortPropertyValue = prop;

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override void RemoveSortCore()
        {
            isSortedValue = false;
        }

        protected override PropertyDescriptor SortPropertyCore => sortPropertyValue;

        protected override ListSortDirection SortDirectionCore => sortDirectionValue;
    }

    public class PropertyComparer<T> : IComparer<T>
    {
        private PropertyDescriptor prop;
        private ListSortDirection direction;

        public PropertyComparer(PropertyDescriptor prop, ListSortDirection direction)
        {
            this.prop = prop;
            this.direction = direction;
        }

        public int Compare(T x, T y)
        {
            object xValue = prop.GetValue(x);
            object yValue = prop.GetValue(y);

            int result;

            if (xValue == null)
            {
                result = (yValue == null) ? 0 : -1;
            }
            else if (yValue == null)
            {
                result = 1;
            }
            else
            {
                result = Comparer<object>.Default.Compare(xValue, yValue);
            }

            return direction == ListSortDirection.Ascending ? result : -result;
        }
    }
}
