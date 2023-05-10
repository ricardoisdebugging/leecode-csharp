using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0034_find_first_and_last_position_in_sorted_array
{
    public class FindFirstAndLastPositionInSortedArrayImpl
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var firstIdx = BinarySearchForFirstElement(nums, target);
            var lastIdx = BinarySearchForLastElement(nums, target);
            return new int[] { firstIdx, lastIdx };
        }

        private static int BinarySearchForFirstElement(int[] nums, int target)
        {
            var leftIdx = 0;
            var rightIdx = nums.Length - 1;

            while (leftIdx <= rightIdx)
            {
                var midIdx = leftIdx + (rightIdx - leftIdx) / 2;

                if (nums[midIdx] > target)
                    rightIdx = midIdx - 1;

                if (nums[midIdx] < target)
                    leftIdx = midIdx + 1;

                if (nums[midIdx] == target)
                {
                    //适用于递增数列
                    if (midIdx == 0 || nums[midIdx - 1] != target)
                        return midIdx;

                    rightIdx = midIdx - 1;
                }
            }

            return -1;
        }

        private static int BinarySearchForLastElement(int[] nums, int target)
        {
            var leftIdx = 0;
            var rightIdx = nums.Length - 1;

            while (leftIdx <= rightIdx)
            {
                var midIdx = leftIdx + (rightIdx - leftIdx) / 2;

                if (nums[midIdx] > target)
                    rightIdx = midIdx - 1;

                if (nums[midIdx] < target)
                    leftIdx = midIdx + 1;

                if (nums[midIdx] == target)
                {
                    //适用于递增数列
                    if (midIdx == nums.Length - 1 || nums[midIdx + 1] != target)
                        return midIdx;

                    leftIdx = midIdx + 1;
                }
            }

            return -1;
        }
    }
}
