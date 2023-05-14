using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeeCode._0019_remove_nth_node_from_end_of_list;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeeCode.Common;
using LeeCodeTest.Common;

namespace LeeCode._0019_remove_nth_node_from_end_of_list
{
    [TestClass()]
    public class RemoveNthNodeFromEndOfListTest
    {
        [TestMethod()]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 1, 2, 3, 5 })]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, 5, new int[] { 2, 3, 4, 5 })]
        [DataRow(new int[] { 1 }, 1, new int[] { })]
        [DataRow(new int[] { 1, 2 }, 1, new int[] { 1 })]
        public void RemoveNthFromEndTest(int[] array, int n, int[] expectedArray)
        {
            var listNode = Funcs.ConvertArrayToListNode(array);

            var tmp = new RemoveNthNodeFromEndOfListImpl();
            var realListNode = tmp.RemoveNthFromEnd(listNode, n);

            var realArray = Funcs.ConvertListNodeToList(realListNode).ToArray();

            CollectionAssert.AreEqual(expectedArray, realArray);
        }
    }
}