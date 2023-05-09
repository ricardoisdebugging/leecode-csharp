using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeeCode._0033_search_in_rotated_sorted_array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeeCode._0035_search_insert_position;

namespace LeeCode._0033_search_in_rotated_sorted_array
{
    [TestClass()]
    public class SearchInRotatedSortedArrayTest
    {
        [TestMethod()]
        [DataRow(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
        [DataRow(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
        [DataRow(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 8, -1)]
        [DataRow(new int[] { 1 }, 0, -1)]
        public void SearchTest(int[] nums, int target, int expectedInx)
        {
            var impl = new SearchInRotatedSortedArrayImpl();
            var targetIdx = impl.Search(nums, target);

            Assert.AreEqual(expectedInx, targetIdx);
        }
    }
}