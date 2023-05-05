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
            HashSet<string> uniqueResults = new HashSet<string>();

            for (int minItemIndex = 0; minItemIndex < nums.Length - 2; minItemIndex++)
            {
                var leftIndex = minItemIndex + 1;
                var rightIndex = nums.Length - 1;

                while (leftIndex < rightIndex)
                {
                    if (nums[minItemIndex] + nums[leftIndex] + nums[rightIndex] == 0)
                    {
                        var tempComb = new List<int>() { nums[minItemIndex], nums[leftIndex], nums[rightIndex] };
                        var tempString = @$"{nums[minItemIndex]}&{nums[leftIndex]}&{nums[rightIndex]}";

                        if (!uniqueResults.Contains(tempString))
                        {
                            results.Add(tempComb);
                            uniqueResults.Add(tempString);
                        }

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
            //var result = new List<IList<int>>();

            //Array.Sort(nums);

            //var map = nums.ToDictionary(x => x, x => Array.IndexOf(nums, x));

            //for (int firstItemIndex = 0; firstItemIndex < nums.Length - 1; firstItemIndex++ )
            //{
            //    if (nums[firstItemIndex] > 0) break;
            //    for (int secondItemIndex = firstItemIndex + 1; secondItemIndex < nums.Length; secondItemIndex++ )
            //    {
            //        int numsK = 0 - nums[i] - nums[j];
            //    }
            //}

            return null;
        }
    }
}
