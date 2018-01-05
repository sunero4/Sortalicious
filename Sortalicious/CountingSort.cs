using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortalicious
{
    public class CountingSort
    {
        public List<int> SortAscending(List<int> values, int maxValue)
        {
            var arr = new int[maxValue + 1];

            for (int i = 0, n = values.Count; i < n; i++)
            {
                arr[values[i]]++;
            }

            var sortedValues = new List<int>();

            for (int i = 0, n = arr.Length; i < n; i++)
            {
                for (int j = 0; j < arr[i]; j++)
                {
                    sortedValues.Add(i);
                }
            }

            return sortedValues;
        }

        public List<int> SortDescending(List<int> values, int maxValue)
        {
            var arr = new int[maxValue + 1];

            for (int i = 0, n = values.Count; i < n; i++)
            {
                arr[values[i]]++;
            }

            var sortedValues = new List<int>();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < arr[i]; j++)
                {
                    sortedValues.Add(i);
                }
            }

            return sortedValues;
        }
    }
}
