using LeeCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0141_linked_list_cycle
{
    public class LinkedListCycle
    {
        public bool HasCycleWithHash(ListNode head)
        {
            if (head == null) return false;

            var listSet = new HashSet<int>();

            var node = head;
            while(node.next != null)
            {
                if(listSet.Contains(node.val))
                    return true;

                listSet.Add(node.val);
                node = node.next;
            }

            return false;
        }

        public bool HashCycleWithPointers(ListNode head)
        {
            if (head == null) return false;

            if (head.next != null && head.next.next != null)
            {
                var faster = head.next.next;
                var slower = head.next;
                while(faster != slower)
                {
                    if (slower.next != null && faster.next.next != null)
                    {
                        faster = faster.next.next;
                        slower = slower.next;
                    }
                    else
                        return false;
                }
                return true;
            }
            return false;
        }
    }
}
