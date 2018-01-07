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
    class InsertionSortTests
    {
        private ISorting<int> _uutInts;
        private ISorting<double> _uutDoubles;
        private ISorting<float> _uutFloats;

        [SetUp]
        public void Setup()
        {
            _uutInts = new InsertionSort<int>();
            _uutDoubles = new InsertionSort<double>();
            _uutFloats = new InsertionSort<float>();
        }


        [TestCase(new int[] {3, 11, 5, 7, 2}, new int[] {2, 3, 5, 7, 11})]
        [TestCase(new int[] {3, 11, 3, 7, 2}, new int[] {2, 3, 3, 7, 11})]
        [TestCase(new int[] {3, 3, 3, 3, 3}, new int[] {3, 3, 3, 3, 3})]
        [TestCase(new int[] {11, 7, 5, 3, 2}, new int[] {2, 3, 5, 7, 11})]
        [TestCase(new int[] {2, 3, 5, 7, 11}, new int[] {2, 3, 5, 7, 11})]
        public void InsertionSort_Integers_SortsAscending(int[] values, int[] sortedValues)
        {
            var sorted = _uutInts.SortAscending(values.ToList());
            Assert.That(sorted.SequenceEqual(sortedValues.ToList()), "Resulting sequence does not match sorted sequence.");
        }

        [TestCase(new double[] { 3.2, 11.2, 5.1, 7.1, 2.3 }, new double[] { 2.3, 3.2, 5.1, 7.1, 11.2 })]
        [TestCase(new double[] { 3.2, 11.2, 3.2, 7.1, 2.3 }, new double[] { 2.3, 3.2, 3.2, 7.1, 11.2 })]
        [TestCase(new double[] { 3.2, 3.2, 3.2, 3.2, 3.2 }, new double[] { 3.2, 3.2, 3.2, 3.2, 3.2 })]
        [TestCase(new double[] { 11.2, 7.1, 5.1, 3.2, 2.3 }, new double[] { 2.3, 3.2, 5.1, 7.1, 11.2 })]
        [TestCase(new double[] { 2.3, 3.2, 5.1, 7.1, 11.2 }, new double[] { 2.3, 3.2, 5.1, 7.1, 11.2 })]
        public void InsertionSort_Doubles_SortsAscending(double[] values, double[] sortedValues)
        {
            var sorted = _uutDoubles.SortAscending(values.ToList());
            Assert.That(sorted.SequenceEqual(sortedValues.ToList()), "Resulting sequence does not match sorted sequence.");
        }

        [TestCase(new float[] { 3.2F, 11.2F, 5.1F, 7.1F, 2.3F }, new float[] { 2.3F, 3.2F, 5.1F, 7.1F, 11.2F })]
        [TestCase(new float[] { 3.2F, 11.2F, 3.2F, 7.1F, 2.3F }, new float[] { 2.3F, 3.2F, 3.2F, 7.1F, 11.2F })]
        [TestCase(new float[] { 3.2F, 3.2F, 3.2F, 3.2F, 3.2F }, new float[] { 3.2F, 3.2F, 3.2F, 3.2F, 3.2F })]
        [TestCase(new float[] { 11.2F, 7.1F, 5.1F, 3.2F, 2.3F }, new float[] { 2.3F, 3.2F, 5.1F, 7.1F, 11.2F })]
        [TestCase(new float[] { 2.3F, 3.2F, 5.1F, 7.1F, 11.2F }, new float[] { 2.3F, 3.2F, 5.1F, 7.1F, 11.2F })]
        public void InsertionSort__SortsAscending(float[] values, float[] sortedValues)
        {
            var sorted = _uutFloats.SortAscending(values.ToList());
            Assert.That(sorted.SequenceEqual(sortedValues.ToList()), "Resulting sequence does not match sorted sequence.");
        }



    }
}
