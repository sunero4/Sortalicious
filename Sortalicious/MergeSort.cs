using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortalicious
{
    public class MergeSort<T> : ISorting<T> where T : IComparable<T>, IEquatable<T>, IConvertible
    {
        public List<T> SortDescending(List<T> values)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Recursively splits the list of values in two halves, then finally merges the individual values into one
        /// sorted list and returns it.
        /// </summary>
        /// <param name="values">List of values to be sorted.</param>
        /// <returns>Sorted values.</returns>
        public List<T> SortAscending(List<T> values)
        {
            if (values.Count <= 1)
            {
                return values;
            }

            var leftSide = new List<T>();
            var rightSide = new List<T>();

            for (int i = 0, n = values.Count; i < n; i++)
            {
                if (i < n / 2)
                {
                    leftSide.Add(values[i]);
                }
                else
                {
                    rightSide.Add(values[i]);
                }
            }

            leftSide = SortAscending(leftSide);
            rightSide = SortAscending(rightSide);

            return Merge(leftSide, rightSide);
        }

        /// <summary>
        /// Merges the two halves of the values to be sorted.
        /// </summary>
        /// <param name="left">Left half of the values list</param>
        /// <param name="right">Right half of the values list</param>
        /// <returns></returns>
        private List<T> Merge(List<T> left, List<T> right)
        {
            var mergedList = new List<T>();

            //Iterate over the two halves, merging them into one list in correct order
            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0].CompareTo(right[0]) <= 0)
                {
                    mergedList.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    mergedList.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            //There might be elements left in one of the lists, which is handled here. 
            while (left.Count > 0)
            {
                mergedList.Add(left[0]);
                left.RemoveAt(0);
            }
            while (right.Count > 0)
            {
                mergedList.Add(right[0]);
                right.RemoveAt(0);
            }

            return mergedList;
        }
    }
}
