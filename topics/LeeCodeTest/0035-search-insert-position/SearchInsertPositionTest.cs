using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeeCode._0035_search_insert_position;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0035_search_insert_position
{
    [TestClass()]
    public class SearchInsertPositionTest
    {
        [TestMethod()]
        [DataRow(new int[] { 1, 3, 5, 6 }, 5, 2)]
        [DataRow(new int[] { 1, 3, 5, 6 }, 2, 1)]
        [DataRow(new int[] { 1, 3, 5, 6 }, 7, 4)]
        [DataRow(new int[] { 1, 3, 5, 6 }, 0, 0)]
        public void SearchInsertTest(int[] nums, int target, int expectedInx)
        {
            int targetIdx = SearchInsertPositionImpl.SearchInsert(nums, target);

            Assert.AreEqual(expectedInx, targetIdx);
        }
    }
}