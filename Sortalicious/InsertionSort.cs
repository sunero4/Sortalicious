using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortalicious
{
    public class InsertionSort<T> : ISorting<T> where T : IComparable<T>, IEquatable<T>, IConvertible
    {
        public List<T> SortDescending(List<T> values)
        {
            throw new NotImplementedException();
        }

        public List<T> SortAscending(List<T> values)
        {
            if (values.Count <= 1)
            {
                return values;
            }
            for (int i = 1, n = values.Count; i < n; i++)
            {
                for (int j = values.Count - 1; j > 0; j--)
                {
                    if (values[j - 1].CompareTo(values[j]) > 0)
                    {
                        Swap(j - 1, j, ref values);
                    }
                }
            }
            return values;
        }

        private void Swap(int a, int b, ref List<T> values)
        {
            var temp = values[a];
            values[a] = values[b];
            values[b] = temp;
        }
    }
}
