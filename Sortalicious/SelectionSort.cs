using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Sortalicious
{
    internal class SelectionSort<T> : ISorting<T> where T : IComparable<T>, IEquatable<T>, IConvertible
    {
        /// <summary>
        /// Sorts the supplied list of elements in descending order, by selecting the max value and adding it to
        /// the sorted list, then removing it from the unsorted list.
        /// </summary>
        /// <param name="values">Values to be sorted.</param>
        /// <returns>The supplied values sorted in descending order.</returns>
        public List<T> SortDescending(List<T> values)
        {
            var sortedValues = new List<T>();
            for (int i = 0; i < values.Count; i++)
            {
                var max = values.Max();
                sortedValues.Add(max);
                values.Remove(max);
            }
            return sortedValues;
        }

        /// <summary>
        /// Sorts the supplied list of elements in descending order, by selecting the min value and adding it to
        /// the sorted list, then removing it from the unsorted list. Works in O(n^2) time.
        /// </summary>
        /// <param name="values">Values to be sorted.</param>
        /// <returns>The supplied values sorted in ascending order.</returns>
        public List<T> SortAscending(List<T> values)
        {
            var sortedValues = new List<T>();
            for (int i = 0; i < values.Count; i++)
            {
                var min = values.Min();
                sortedValues.Add(min);
                values.Remove(min);
            }
            return sortedValues;
        }
    }
}
