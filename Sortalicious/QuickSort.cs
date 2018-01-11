using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortalicious
{
    internal class QuickSort<T> : ISorting<T> where T : IComparable<T>, IEquatable<T>, IConvertible
    {
        private List<T> _values;

        public List<T> SortDescending(List<T> values)
        {
            throw new NotImplementedException();
        }

        public List<T> SortAscending(List<T> values)
        {
            _values = values;

        }

        private int Partition(int pivot, int left, int right)
        {
            var leftIndex = left;
            var rightIndex = right;

            while (leftIndex < rightIndex)
            {
                while (_values[leftIndex].CompareTo(_values[pivot]) < 0)
                {
                    leftIndex++;
                }
                while (_values[rightIndex].CompareTo(_values[pivot]) > 0 && rightIndex > 0)
                {
                    rightIndex--;
                }
                if (leftIndex < rightIndex)
                {
                    Swap(leftIndex, rightIndex, ref _values);
                }
            }
            Swap(leftIndex, rightIndex, ref _values);
            return leftIndex;
        }

        private void QuickSortAscending(int left, int right)
        {
            if (left - right <= 0)
            {
                return;
            }
            else
            {
                var pivot = 
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
