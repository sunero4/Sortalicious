using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortalicious
{
    public class QuickSort<T> : ISorting<T> where T : IComparable<T>, IEquatable<T>, IConvertible
    {
        public List<T> SortDescending(List<T> values)
        {
            throw new NotImplementedException();
        }

        public List<T> SortAscending(List<T> values)
        {
            QuickSortAscending(0, values.Count - 1, values);
            return values;
        }

        private int Partition(ref List<T> values, int low, int high)
        {
            var pivot = values[high];
            var smallerIndex = low - 1;

            for (int i = low; i < high; i++)
            {
                if (values[i].CompareTo(pivot) <= 0)
                {
                    smallerIndex++;

                    Swap(smallerIndex, i, ref values);
                }
            }

            Swap(smallerIndex + 1, high, ref values);

            return smallerIndex + 1;
        }

        private void QuickSortAscending(int low, int high, List<T> values)
        {
            if (low < high)
            {
                var partition = Partition(ref values, low, high);

                QuickSortAscending(low, partition - 1, values);
                QuickSortAscending(partition + 1, high, values);
            }
        }

        private void Swap(int a, int b, ref List<T> values)
        {
            var temp = values[a];
            values[a] = values[b];
            values[b] = temp;
        }

    }
}
