using LeeCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCodeTest.Common
{
    public class Funcs
    {
        public static IList<IList<int>> ConvertStringToTargetNestedList(string valueText)
        {
            var valuesList = valueText.Split("@@");
            var result = new List<IList<int>>();
            foreach (var values in valuesList)
            {
                var arr = values.Split('&').Select(x => int.Parse(x)).ToList();
                result.Add(arr);
            }

            return result;
        }

        public static ListNode ConvertArrayToListNode(int[] array)
        {
            ListNode head = null;
            ListNode node = null;
            foreach(var ele in array)
            {
                var tmp = new ListNode(ele);
                if (head == null)
                {
                    head = tmp;
                    node = head;
                }
                else
                {
                    node.next = tmp;
                    node = node.next;
                }
            }

            return head;
        }

        public static List<int> ConvertListNodeToList(ListNode head)
        {
            var array = new List<int>();

            if (head == null)
                return array;

            var tmp = head;
            while(tmp != null)
            {
                array.Add(tmp.val);
                tmp = tmp.next;
            }

            return array;
        }
    }
}
