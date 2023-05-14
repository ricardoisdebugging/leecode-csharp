using LeeCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0019_remove_nth_node_from_end_of_list
{
    public class RemoveNthNodeFromEndOfListImpl
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            //if (head == null) return null;
            //if (head.next == null) return head;

            return Solution2(head, n);
        }

        private ListNode Solution1(ListNode head, int n)
        {
            int count = 0;
            var tmp = head;
            while (tmp != null)
            {
                tmp = tmp.next;
                count++;
            }

            if (count == n)//means select first element
                return head.next;

            int idx = 1;
            tmp = head;
            while (idx < count - n)
            {
                tmp = tmp.next;
                idx++;
            }

            tmp.next = tmp.next.next;

            return head;
        }

        private ListNode Solution2(ListNode head, int n)
        {
            var rightIdx = 0;
            var leftIdx = 0;

            //need a pre-head node
            var dummyHead = new ListNode();
            dummyHead.next = head;

            var tmp = dummyHead;
            var newList = dummyHead;
            while (tmp.next != null)
            {
                tmp = tmp.next;
                
                if (rightIdx - leftIdx == n)
                {
                    leftIdx++;
                    newList = newList.next;
                }
                rightIdx++;
            }

            newList.next = newList.next.next;

            return dummyHead.next;
        }
    }
}
