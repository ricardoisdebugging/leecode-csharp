using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeeCode._0061_rotate_list;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeeCodeTest.Common;

namespace LeeCode._0061_rotate_list
{
    [TestClass()]
    public class RotateListTest
    {
        [TestMethod()]
        //[DataRow(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 4, 5, 1, 2, 3 })]
        //[DataRow(new int[] { 1, 2 }, 0, new int[] { 1, 2 })]
        //[DataRow(new int[] { 1, 2 }, 1, new int[] { 2, 1 })]
        //[DataRow(new int[] { 1, 2, 3 }, 2, new int[] { 2, 3, 1 })]
        [DataRow(new int[] { 1 }, 1, new int[] { 1 })]
        public void RotateRightTest(int[] originalList, int rotateIdx, int[] expectedList)
        {
            var impl = new RotateListImpl();

            var origialNode = Funcs.ConvertArrayToListNode(originalList);
            var realNode = impl.RotateRight(origialNode, rotateIdx);
            var realList = Funcs.ConvertListNodeToList(realNode);

            CollectionAssert.AreEqual(expectedList, realList);
        }
    }
}