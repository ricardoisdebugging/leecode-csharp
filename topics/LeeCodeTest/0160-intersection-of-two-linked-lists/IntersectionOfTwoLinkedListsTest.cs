using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeeCode._0160_intersection_of_two_linked_lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeeCodeTest.Common;

namespace LeeCode._0160_intersection_of_two_linked_lists
{
    [TestClass()]
    public class IntersectionOfTwoLinkedListsTest
    {
        [TestMethod()]
        [DataRow(new int[] { 1, 9, 1, 2, 4 }, new int[] { 3, 2, 4 }, 3, 1)]
        [DataRow(new int[] { 4, 1, 8, 4, 5 }, new int[] { 5, 6, 1, 8, 4, 5 }, 2, 3)]
        [DataRow(new int[] { 2, 6, 4 }, new int[] { 1, 5 }, 3, 2)]
        [DataRow(new int[] { 2, 6 }, new int[] { 1, 6 }, 1, 1)]
        public void GetIntersectionNodeTest(int[] listA, int[] listB, int skipA, int skipB)
        {
            var listNodeA = Funcs.ConvertArrayToListNode(listA);
            var listNodeB = Funcs.ConvertArrayToListNode(listB);

            var intersectionNodeA = listNodeA;
            for (int i = 0; i < skipA; i++)
                intersectionNodeA = intersectionNodeA.next;
            var listOfIntersectionNodeA = Funcs.ConvertListNodeToList(intersectionNodeA);

            var intersectionNodeB = listNodeB;
            for (int i = 0; i < skipB; i++)
                intersectionNodeB = intersectionNodeB.next;
            var listOfIntersectionNodeB = Funcs.ConvertListNodeToList(intersectionNodeB);

            var impl = new IntersectionOfTwoLinkedLists();
            var intersectionNode = impl.GetIntersectionNode(listNodeA, listNodeB);
            var listOfIntersectionNode = Funcs.ConvertListNodeToList(intersectionNode);


            CollectionAssert.AreEqual(listOfIntersectionNode, listOfIntersectionNodeA);
            CollectionAssert.AreEqual(listOfIntersectionNode, listOfIntersectionNodeB);
        }
    }
}