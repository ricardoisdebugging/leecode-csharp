using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeeCode._0011_container_with_most_water;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0011_container_with_most_water
{
    [TestClass()]
    public class ContainerWithMostWaterTest
    {
        [TestMethod()]
        [DataRow(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        [DataRow(new int[] { 1, 1 }, 1)]
        public void MaxAreaTest(int[] height, int expectedArea)
        {
            var realArea = ContainerWithMostWaterImpl.MaxArea(height);
            Assert.AreEqual(expectedArea, realArea);
        }
    }
}