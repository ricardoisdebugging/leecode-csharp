using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0035_search_insert_position
{
    public class SearchInsertPositionImpl
    {
        public static int SearchInsert(int[] nums, int target)
        {
            return BinarySearch(nums, target);
        }

        private static int BinarySearch(int[] nums, int target)
        {
            int leftIdx = 0;
            int rightIdx = nums.Length - 1;

            int targetIdx = nums.Length;

            while (leftIdx <= rightIdx)
            {
                var midIdx = leftIdx + (rightIdx - leftIdx) / 2;

                int mid = nums[midIdx];

                if (target <= mid)
                {
                    targetIdx = midIdx;
                    rightIdx = midIdx - 1;
                }

                if (target > mid)
                    leftIdx = midIdx + 1;
            }

            return targetIdx;
        }
    }
}
