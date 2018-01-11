using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortalicious
{
    internal class QuickSort<T> : ISorting<T> where T : IComparable<T>, IEquatable<T>, IConvertible
    {
        public List<T> SortDescending(List<T> values)
        {
            throw new NotImplementedException();
        }

        public List<T> SortAscending(List<T> values)
        {
            var low = values[0];
            var high = values[values.Count - 1];


        }

        private void Partition(List<T> values, int low, int high)
    }
}
