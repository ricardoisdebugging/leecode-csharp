using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeeCode._0015_three_sum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeeCodeTest.Common;

namespace LeeCode._0015_three_sum
{
    [TestClass()]
    public class ThreeSumTests
    {
        [TestMethod()]
        [DataRow(new int[] { 0, 0, 0 }, "0&0&0")]
        [DataRow(new int[] { -1, 0, 1, 2, -1, -4 }, "-1&-1&2@@-1&0&1")]
        [DataRow(new int[] { -2, -2, -1, -1, -1, -1, 0, 2, 2, 2, 4 }, "-2&-2&4@@-2&0&2@@-1&-1&2")]
        public void ThreeSumWithTwoPointersTest(int[] nums, string expectedValueText)
        {
            var results = ThreeSumImpl.ThreeSumWithTwoPointers(nums);
            var expectedValues = Funcs.ConvertStringToTargetNestedList(expectedValueText);

            ValidateResultsWithExpectedValues(results, expectedValues);
        }

        private void ValidateResultsWithExpectedValues(
            IList<IList<int>> results, IList<IList<int>> expectedValues)
        {
            for (int i = 0; i < expectedValues.Count; i++)
            {
                var result = results[i];
                var expectedValue = expectedValues[i];
                CollectionAssert.AreEqual(expectedValue.ToArray(), result.ToArray());
            }
        }

        [TestMethod()]
        [DataRow(new int[] { 0, 0, 0 }, "0&0&0")]
        [DataRow(new int[] { -1, 0, 1, 2, -1, -4 }, "-1&-1&2@@-1&0&1")]
        [DataRow(new int[] { -2, -2, -1, -1, -1, -1, 0, 2, 2, 2, 4 }, "-2&-2&4@@-2&0&2@@-1&-1&2")]
        public void ThreeSumWithHashMapTest(int[] nums, string expectedValueText)
        {
            var results = ThreeSumImpl.ThreeSumWithHashMap(nums);
            var expectedValues = Funcs.ConvertStringToTargetNestedList(expectedValueText);

            ValidateResultsWithExpectedValues(results, expectedValues);
        }
    }
}