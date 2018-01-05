using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Sortalicious;

namespace SortaLicious.Tests.Unit
{
    [TestFixture]
    class CountingSortTests
    {
        private CountingSort _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new CountingSort();
        }

        [TestCase(new int[] {3, 11, 5, 7, 2 }, new int[] {2, 3, 5, 7, 11})]
        [TestCase(new int[] { 3, 11, 3, 7, 2 }, new int[] {2, 3, 3, 7, 11})]
        [TestCase(new int[] { 3, 3, 3, 3, 3 }, new int[] {3, 3, 3, 3, 3})]
        [TestCase(new int[] {11, 7, 5, 3, 2 }, new int[] { 2, 3, 5, 7, 11 })]
        [TestCase(new int[] { 2, 3, 5, 7, 11 }, new int[] { 2, 3, 5, 7, 11 })]
        public void SortAscending_UnsortedList_SortsCorrectly(int[] values, int[] sortedValues)
        {
            var sorted = _uut.SortAscending(values.ToList(), values.Max());
            Assert.That(sorted.SequenceEqual(sortedValues), "Resulting sequence does not match sorted sequence");
        }

        [TestCase(new int[] { 3, 11, 5, 7, 2 }, new int[] { 11, 7, 5, 3, 2 })]
        [TestCase(new int[] { 3, 11, 3, 7, 2 }, new int[] { 11, 7, 3, 3, 2 })]
        [TestCase(new int[] { 3, 3, 3, 3, 3 }, new int[] { 3, 3, 3, 3, 3 })]
        [TestCase(new int[] { 11, 7, 5, 3, 2 }, new int[] { 11, 7, 5, 3, 2 })]
        [TestCase(new int[] { 2, 3, 5, 7, 11 }, new int[] { 11, 7, 5, 3, 2 })]
        public void SortDescending_UnsortedList_SortsCorrectly(int[] values, int[] sortedValues)
        {
            var sorted = _uut.SortDescending(values.ToList(), values.Max());
            Assert.That(sorted.SequenceEqual(sortedValues), "Resulting sequence does not match sorted sequence");
        }

        [Test]
        public void TestTest()
        {
            string name = "Joshua";
            string reverse = "auhsoJ";

            var reverseName = new char[name.Length];


            for (int i = 0; i < name.Length; i++)
            {
                reverseName[(name.Length - 1) - i] = name[i];
            }

            var result = new string(reverseName);

            Assert.That(reverse == result, String.Format("was {0}", result));
        }
    }
}
