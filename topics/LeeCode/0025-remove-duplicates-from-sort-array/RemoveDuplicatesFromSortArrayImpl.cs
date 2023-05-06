using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0025_remove_duplicates_from_sort_array
{
    public class RemoveDuplicatesFromSortArrayImpl
    {
        public static int RemoveDuplicatesWithRefTwoHash(ref int[] nums)
        {
            if (nums.Length <= 1)
                return nums.Length;

            var uniqueList = new List<int>();
            var duplicateList = new List<int>();

            foreach ( int i in nums )
            {
                if (!uniqueList.Contains(i))
                    uniqueList.Add(i);
                else
                    duplicateList.Add(i);
            }

            var uniqueNum = uniqueList.Count;

            uniqueList.AddRange(duplicateList);
            nums = uniqueList.ToArray();

            return uniqueNum;
        }

        public static int RemoveDuplicatesWithPointers(int[] nums)
        {
            if (nums.Length <= 1)
                return nums.Length;

            int uniqueNum = 0;
            for (int i = 0; i < nums.Length - 1; i++ )
            {
                if (nums[i] < nums[i + 1])
                    nums[++uniqueNum] = nums[i + 1];
            }

            return uniqueNum + 1;
        }
    }
}
