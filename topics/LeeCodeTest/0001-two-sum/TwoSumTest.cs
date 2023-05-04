using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0001_two_sum
{
    [TestClass]
    public class TwoSumTest
    {
        [TestMethod]
        [DataRow(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [DataRow(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        public void TwoSum(int[] nums, int target, int[] expectedValues)
        {
            var realValues = TwoSumImpl.TwoSum(nums, target);
            Array.Sort(realValues);
            CollectionAssert.AreEqual(expectedValues, realValues);
        }
    }
}
