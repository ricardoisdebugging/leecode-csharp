using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0009_palindrome_number
{
    public class PalindromeNumberImpl
    {
        public bool IsPalindrome(int x)
        {
            var xChars = x.ToString().ToCharArray();
            if (xChars[0] == '-')
                return false;

            var leftIdx = 0;
            var rightIdx = xChars.Length - 1;
            while (leftIdx <= rightIdx)
            {
                
                if (xChars[leftIdx] != xChars[rightIdx])
                    return false;

                leftIdx++;
                rightIdx--;
            }

            return true;
        }
    }
}
