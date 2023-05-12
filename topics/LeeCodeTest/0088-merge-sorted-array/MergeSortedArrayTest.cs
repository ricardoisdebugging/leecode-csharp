using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeeCode._0088_merge_sorted_array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0088_merge_sorted_array
{
    [TestClass()]
    public class MergeSortedArrayTest
    {
        [TestMethod()]
        [DataRow(new int[] { -1, 0, 0, 3, 3, 3, 0, 0, 0 }, 6, new[] { 1, 2, 2 }, 3, new int[] { -1, 0, 0, 1, 2, 2, 3, 3, 3 })]
        public void MergeTest(int[] nums1, int m, int[] nums2, int n, int[] expectedNums)
        {
            var mergeSortedArrayImpl = new MergeSortedArrayImpl();
            mergeSortedArrayImpl.Merge(nums1, m, nums2, n);

            CollectionAssert.Equals(mergeSortedArrayImpl, expectedNums);
        }
    }
}