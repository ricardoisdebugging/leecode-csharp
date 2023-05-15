using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0028_find_the_index_of_the_first_occurrence_in_string
{
    public class FindTheIndexOfTheFirstOccurrenceInStringImpl
    {
        public int StrStr(string haystack, string needle)
        {
            var leftIdx = 0;
            var rightIdx = 0;

            while(leftIdx < haystack.Length)
            {
                leftIdx++;

                if (leftIdx - rightIdx == needle.Length)
                {
                    var subStr = haystack.Substring(rightIdx, needle.Length);

                    if (string.Equals(subStr, needle, StringComparison.OrdinalIgnoreCase))
                        return rightIdx;

                    rightIdx++;
                }
            }

            return -1;
        }
    }
}
