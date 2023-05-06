using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeeCode._0025_remove_duplicates_from_sort_array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0025_remove_duplicates_from_sort_array
{
    [TestClass()]
    public class RemoveDuplicatesFromSortArrayTest
    {
        [TestMethod()]
        [DataRow(new int[] { 1, 1, 2}, 2, new int[] { 1, 2})]
        [DataRow(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4}, 5, new int[] { 0, 1, 2, 3, 4})]
        public void RemoveDuplicatesWithRefTwoHashTest(int[] nums, int expectedNum, int[] expectedValues)
        {
            var k = RemoveDuplicatesFromSortArrayImpl.RemoveDuplicatesWithRefTwoHash(ref nums);
            Assert.AreEqual(expectedNum, k);

            for (int i = 0; i < k; i++)
            {
                Assert.AreEqual(nums[i], expectedValues[i]);
            }

        }

        [TestMethod()]
        [DataRow(new int[] { 1, 1, 2 }, 2, new int[] { 1, 2 })]
        [DataRow(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5, new int[] { 0, 1, 2, 3, 4 })]
        public void RemoveDuplicatesWithPointersTest(int[] nums, int expectedNum, int[] expectedValues)
        {
            var k = RemoveDuplicatesFromSortArrayImpl.RemoveDuplicatesWithPointers(nums);
            Assert.AreEqual(expectedNum, k);

            for (int i = 0; i < k; i++)
            {
                Assert.AreEqual(nums[i], expectedValues[i]);
            }

        }
    }
}