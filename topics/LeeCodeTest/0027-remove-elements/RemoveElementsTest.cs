using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeeCode._0027_remove_elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeeCode._0025_remove_duplicates_from_sort_array;

namespace LeeCode._0027_remove_elements
{
    [TestClass()]
    public class RemoveElementsTest
    {
        [TestMethod()]
        [DataRow(new int[] { 3, 2, 2, 3 }, 3, 2, new int[] { 2, 2 })]
        [DataRow(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5, new int[] { 0, 1, 3, 0, 4 })]
        public void RemoveElementWithRefLinqTest(int[] nums, int dropNum, int expectedNum, int[] expectedValues)
        {
            var k = RemoveElementsImpl.RemoveElementWithRefLinq(ref nums, dropNum);
            Assert.AreEqual(expectedNum, k);

            ValidateElementsInArray(nums, expectedValues, k);
        }

        [TestMethod()]
        [DataRow(new int[] { 3, 2, 2, 3 }, 3, 2, new int[] { 2, 2 })]
        [DataRow(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5, new int[] { 0, 1, 3, 0, 4 })]
        public void RemoveElementWithLinqTest(int[] nums, int dropNum, int expectedNum, int[] expectedValues)
        {
            var k = RemoveElementsImpl.RemoveElementWithLinq(nums, dropNum);
            Assert.AreEqual(expectedNum, k);

            ValidateElementsInArray(nums, expectedValues, k);
        }

        [TestMethod()]
        [DataRow(new int[] { 3, 2, 2, 3 }, 3, 2, new int[] { 2, 2 })]
        [DataRow(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5, new int[] { 0, 1, 3, 0, 4 })]
        public void RemoveElementWithPointerTest(int[] nums, int dropNum, int expectedNum, int[] expectedValues)
        {
            var k = RemoveElementsImpl.RemoveElementWithPointer(nums, dropNum);
            Assert.AreEqual(expectedNum, k);

            ValidateElementsInArray(nums, expectedValues, k);
        }

        private void ValidateElementsInArray(int[] nums, int[] expectedValues, int numCount)
        {
            for (int i = 0; i < numCount; i++)
                Assert.AreEqual(nums[i], expectedValues[i]);
        }
    }
}