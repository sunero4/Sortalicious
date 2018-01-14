using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sortalicious;

namespace SortaLicious.Tests.Unit
{
    [TestFixture]
    class QuickSortTests
    {
        private ISorting<int> _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new QuickSort<int>();
        }

        [TestCase(new int[] {3, 11, 5, 7, 2}, new int[] {2, 3, 5, 7, 11})]
        [TestCase(new int[] {3, 11, 3, 7, 2}, new int[] {2, 3, 3, 7, 11})]
        [TestCase(new int[] {3, 3, 3, 3, 3}, new int[] {3, 3, 3, 3, 3})]
        [TestCase(new int[] {11, 7, 5, 3, 2}, new int[] {2, 3, 5, 7, 11})]
        [TestCase(new int[] {2, 3, 5, 7, 11}, new int[] {2, 3, 5, 7, 11})]
        public void QuickSort_Integers_SortsAscending(int[] values, int[] sortedValues)
        {
            var sorted = _uut.SortAscending(values.ToList());
            Assert.That(sorted.SequenceEqual(sortedValues));
        }

    }
}
