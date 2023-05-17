using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeeCode._0125_valid_palindrome
{
    public class ValidPalindromeImpl
    {
        public bool IsPalindrome(string s)
        {
            var extractTxt = Regex.Replace(s, @"[^A-Za-z0-9]+", "").ToLower();

            
            var rightIdx = extractTxt.Length - 1;
            var leftIdx = 0;
            while(leftIdx <= rightIdx)
            {
                if (extractTxt[rightIdx] != extractTxt[leftIdx])
                    return false;

                leftIdx++;
                rightIdx--;
            }

            return true;
        }
    }
}
