using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0344_reverse_string
{
    public class ReverseStringImpl
    {
        public void ReverseString(char[] s)
        {
            var leftIdx = 0;
            var rightIdx = s.Length - 1;

            while(leftIdx <= rightIdx)
            {
                SwithChars(ref s[leftIdx], ref s[rightIdx]);
                leftIdx++;
                rightIdx--;
            }
        }

        private static void SwithChars(ref char a, ref char b)
        {
            var tmp = a; a = b; b = tmp;
        }
    }
}
