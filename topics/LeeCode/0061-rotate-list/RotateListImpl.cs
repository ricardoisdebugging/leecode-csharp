using LeeCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0061_rotate_list
{
    public class RotateListImpl
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
                return null;

            if (k == 0)
                return head;

            int listLength = 0;
            var lastNode = head;
            while(lastNode != null)
            {
                listLength++;

                if (lastNode.next == null)
                {
                    lastNode.next = head;
                    break;
                }

                lastNode = lastNode.next;
            }

            var rotateCount = k % listLength;

            if (rotateCount == 0)
            {
                lastNode.next = null;
                return head;
            }

            var startNode = head;

            var i = 0;
            while (i < listLength - rotateCount)
            {
                startNode = startNode.next;
                lastNode = lastNode.next;
                i++;
            }

            head = startNode;
            lastNode.next = null;

            return head;
        }
    }
}
