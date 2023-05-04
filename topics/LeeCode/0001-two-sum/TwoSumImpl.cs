using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0001_two_sum
{
    public class TwoSumImpl
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var numMap = new Dictionary<int, int>();

            for (int itemIndex = 0; itemIndex < nums.Length; itemIndex++)
            {
                var item = nums[itemIndex];
                var remainValue = target - item;

                if (numMap.ContainsKey(remainValue))
                    return new int[] { itemIndex, numMap[remainValue] };
                else
                    numMap[item] = itemIndex;
            }

            return new int[] { 0 , 0 };
        }
    }
}
