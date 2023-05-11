using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeeCode._0039_combination_sum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeeCodeTest.Common;

namespace LeeCode._0039_combination_sum.Tests
{
    [TestClass()]
    public class CombinationSumTest
    {
        [TestMethod()]
        [DataRow(new int[] { 2, 3, 6, 7 }, 7, "2&2&3@@7")]
        [DataRow(new int[] { 2, 3, 5 }, 8, "2&2&2&2@@2&3&3@@3&5")]
        [DataRow(new int[] { 2 }, 1, "2&2&2&2@@2&3&3@@3&5")]
        public void CombinationSumImplTest(int[] candidates, int target, string expectedValues)
        {
            var combinationSum = new CombinationSum();
            var potentialCombs = combinationSum.CombinationSumImpl(candidates, target);

            var expectedCombs = Funcs.ConvertStringToTargetNestedList(expectedValues);
        }
    }
}