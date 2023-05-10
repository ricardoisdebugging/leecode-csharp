using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeeCode._0034_find_first_and_last_position_in_sorted_array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0034_find_first_and_last_position_in_sorted_array
{
    [TestClass()]
    public class FindFirstAndLastPositionInSortedArrayTest
    {
        [TestMethod()]
        [DataRow(new int[] { 5, 7, 7, 8, 8, 10 }, 8, new int[] { 3, 4 })]
        [DataRow(new int[] { 5, 7, 7, 8, 8, 10 }, 6, new int[] { -1, -1 })]
        [DataRow(new int[] {  }, 0, new int[] { -1, -1 })]
        public void SearchRangeTest(int[] nums, int target, int[] expectedRange)
        {
            var impl = new FindFirstAndLastPositionInSortedArrayImpl();
            var ranges = impl.SearchRange(nums, target);

            CollectionAssert.AreEqual(expectedRange, ranges);
        }
    }
}