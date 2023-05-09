using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0033_search_in_rotated_sorted_array
{
    public class SearchInRotatedSortedArrayImpl
    {
        public int Search(int[] nums, int target)
        {
            #region LINQ
            //var numList = nums.ToList();
            //var targetIdx = numList.IndexOf(target);
            //return targetIdx;
            #endregion

            int maxIdx = 0;
            while (maxIdx < nums.Length - 1)
            {
                if (nums[maxIdx] < nums[maxIdx + 1])
                    maxIdx++;
                else break; 
            }

            int targetIdx = -1;

            BinarySearchInLowCustermize(nums, maxIdx, target, ref targetIdx);
            BinarySearchInHighPart(nums, maxIdx, target, ref targetIdx);

            return targetIdx;
        }

        private void BinarySearchInLowCustermize(int[] nums, int rotatedPoint, int target, ref int targetIdx)
        {
            var leftIdx = rotatedPoint + 1;
            var rightIdx = nums.Length - 1;

            BinarySearchCustomized(nums, target, leftIdx, rightIdx, ref targetIdx);
        }

        private void BinarySearchInHighPart(int[] nums, int rotatedPoint, int target, ref int targetIdx)
        {
            var leftIdx = 0;
            var rightIdx = rotatedPoint;

            BinarySearchCustomized(nums, target, leftIdx, rightIdx, ref targetIdx);
        }

        private void BinarySearchCustomized(int[] nums, int target, int leftIdx, int rightIdx, ref int targetIdx)
        {
            while (leftIdx <= rightIdx)
            {
                var midIdx = leftIdx + (rightIdx - leftIdx) / 2;

                var mid = nums[midIdx];

                if (target < mid)
                    rightIdx = midIdx - 1;

                if (target == mid)
                {
                    targetIdx = midIdx;
                    break;
                }

                if (target > mid)
                    leftIdx = midIdx + 1;
            }
        }
    }
}
