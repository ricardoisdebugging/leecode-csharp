using LeeCode.Common;

namespace LeeCode._0160_intersection_of_two_linked_lists
{
    public class IntersectionOfTwoLinkedLists
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            (var lastNodeA, int lenA) = GetLastNodeAndListLen(headA);
            (var lastNodeB, int lenB) = GetLastNodeAndListLen(headB);

            if (lastNodeA.val != lastNodeB.val)
                return null;

            (ListNode longerListNode, ListNode shorterListNode, int diff) = DistinguishLongerAndShorterLists(headA, lenA, headB, lenB);

            ListNode intersectionNode = null;
            int countDiff = 0;
            while (longerListNode != null)
            {
                if (countDiff < diff)
                    MoveForwardLongerList(ref longerListNode);
                else
                {
                    if (longerListNode == shorterListNode)
                        return longerListNode;
                    longerListNode = longerListNode.next;
                    shorterListNode = shorterListNode.next;
                }

                countDiff++;
            }

            return intersectionNode;
        }

        private void MoveForwardLongerList(ref ListNode listNode)
            => listNode = listNode.next;

        private (ListNode lastNode, int linkedListLen) GetLastNodeAndListLen(ListNode head)
        {
            int len = 0;
            var lastNode = head;
            while (lastNode.next != null)
            {
                len++;
                lastNode = lastNode.next;
            }

            return (lastNode, len);
        }

        private (ListNode longerListNode, ListNode shorterListNode, int diff) DistinguishLongerAndShorterLists(
            ListNode headA, int listALen, ListNode headB, int listBLen)
        {
            if (listALen >= listBLen)
                return (headA, headB, listALen - listBLen);
            else
                return (headB, headA, listBLen - listALen);
        }
    }
}
