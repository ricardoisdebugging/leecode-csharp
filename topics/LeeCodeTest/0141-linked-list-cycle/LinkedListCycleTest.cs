using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeeCode._0141_linked_list_cycle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeeCodeTest.Common;

namespace LeeCode._0141_linked_list_cycle
{
    [TestClass()]
    public class LinkedListCycleTest
    {
        [TestMethod()]
        //[DataRow(new int[] { 3, 2, 0, -4 }, 1, true)]
        //[DataRow(new int[] { 1, 2, 1, 2 }, 0, true)]
        //[DataRow(new int[] { 1, 2 }, -1, false)]
        //[DataRow(new int[] { 1 }, -1, false)]
        [DataRow(new int[] { -21, 10, 17, 8, 4, 26, 5, 35, 33, -7, -16, 27, -12, 6, 29, -12, 5, 9, 20, 14, 14, 2, 13, -24, 21, 23, -21, 5 }, -1, false)]
        public void HasCycleWithHashTest(int[] listNodes, int pos, bool expectedValue)
        {
            var listNode = Funcs.ConvertArrayToCycleListNode(listNodes, pos);
            var impl = new LinkedListCycle();
            var hasCycle = impl.HasCycleWithHash(listNode);

            Assert.AreEqual(expectedValue, hasCycle);
        }

        [TestMethod()]
        //[DataRow(new int[] { 3, 2, 0, -4 }, 1, true)]
        //[DataRow(new int[] { 1, 2, 1, 2 }, 0, true)]
        //[DataRow(new int[] { 1, 2 }, -1, false)]
        [DataRow(new int[] { 1 }, -1, false)]
        [DataRow(new int[] { -21, 10, 17, 8, 4, 26, 5, 35, 33, -7, -16, 27, -12, 6, 29, -12, 5, 9, 20, 14, 14, 2, 13, -24, 21, 23, -21, 5 }, -1, false)]
        public void HashCycleWithPointersTest(int[] listNodes, int pos, bool expectedValue)
        {
            var listNode = Funcs.ConvertArrayToCycleListNode(listNodes, pos);
            var impl = new LinkedListCycle();
            var hasCycle = impl.HashCycleWithPointers(listNode);

            Assert.AreEqual(expectedValue, hasCycle);
        }
    }
}