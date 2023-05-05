using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeeCode._0015_three_sum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0015_three_sum
{
    [TestClass()]
    public class ThreeSumTests
    {
        [TestMethod()]
        //[DataRow(new int[] { 0, 0, 0 })]
        [DataRow(new int[] { -1, 0, 1, 2, -1, -4 })]
        public void ThreeSumWithTwoPointersTest(int[] nums)
        {
            var results = ThreeSumImpl.ThreeSumWithTwoPointers(nums);

            //CollectionAssert.AreEqual(expectedValues, results);
        }
    }
}