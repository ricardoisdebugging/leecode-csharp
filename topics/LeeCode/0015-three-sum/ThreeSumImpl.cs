using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0015_three_sum
{
    public class ThreeSumImpl
    {
        public static IList<IList<int>> ThreeSumWithTwoPointers(int[] nums)
        {
            Array.Sort(nums);

            IList<IList<int>> results = new List<IList<int>>();

            for (int minItemIndex = 0; minItemIndex < nums.Length - 2; minItemIndex++)
            {
                var leftIndex = minItemIndex + 1;
                var rightIndex = nums.Length - 1;

                if (nums[minItemIndex] > 0) break;
        
                if (minItemIndex > 0 && nums[minItemIndex] == nums[minItemIndex - 1]) continue; // a去重

                while (leftIndex < rightIndex)
                {
                    if (nums[minItemIndex] + nums[leftIndex] + nums[rightIndex] == 0)
                    {
                        //缓存一定要在判断之前做，否则遇到一直跳过的重复项，最终达到边界条件就无法存储可行解了
                        var tempComb = new List<int>() { nums[minItemIndex], nums[leftIndex], nums[rightIndex] };
                        results.Add(tempComb);

                        // leftIndex++/rightIndex-- 是跳过重复项
                        // 搭配While才能达到一直跳过重复项的目的
                        // 但是又要有边界条件：leftIndex < rightIndex
                        while (leftIndex < rightIndex && nums[leftIndex] == nums[leftIndex + 1]) leftIndex++; //b去重
                        while (leftIndex < rightIndex && nums[rightIndex] == nums[rightIndex - 1]) rightIndex--; //c去重           

                        leftIndex++;
                        rightIndex--;
                        continue;
                    }

                    if (nums[minItemIndex] + nums[leftIndex] + nums[rightIndex] < 0)
                    {
                        leftIndex++;
                        continue;
                    }

                    if (nums[minItemIndex] + nums[leftIndex] + nums[rightIndex] > 0)
                    {
                        rightIndex--;
                        continue;
                    }
                }
            }

            return results;
        }

        public static IList<IList<int>> ThreeSumWithHashMap(int[] nums)
        {
            Array.Sort(nums);

            var result = new List<IList<int>>();

            var map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                map[nums[i]] = i;
            }

            for (int firstItemIndex = 0; firstItemIndex < nums.Length - 1; firstItemIndex++)
            {
                if (nums[firstItemIndex] > 0) break;

                if (firstItemIndex > 0 && nums[firstItemIndex] == nums[firstItemIndex - 1]) continue; // a去重

                for (int secondItemIndex = firstItemIndex + 1; secondItemIndex < nums.Length; secondItemIndex++)
                {
                    // 如果secondItemIndex只是比firstItemIndex大一位的话，则会去重a本身，如[-2, -2, -1, 0, 4]
                    if (secondItemIndex > firstItemIndex + 1 
                        && nums[secondItemIndex] == nums[secondItemIndex - 1]) continue; // a去重

                    int numsK = 0 - nums[firstItemIndex] - nums[secondItemIndex];

                    if (map.ContainsKey(numsK)
                        && map[0 - nums[firstItemIndex] - nums[secondItemIndex]] > secondItemIndex) //c去重 
                    {
                        var tempComb = new List<int>() 
                        { 
                            nums[firstItemIndex], 
                            nums[secondItemIndex], 
                            numsK
                        };
                        result.Add(tempComb);
                    }
                }
            }

            return result;
        }
    }
}
