using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0011_container_with_most_water
{
    public class ContainerWithMostWaterImpl
    {
        public static int MaxArea(int[] height)
        {
            var maxArea = 0;

            var leftIndex = 0;
            var rightIndex = height.Length - 1;

            while (leftIndex < rightIndex)
            {
                if (height[leftIndex] <= height[rightIndex])
                {
                    maxArea = Math.Max(maxArea, (rightIndex - leftIndex) * height[leftIndex]);

                    leftIndex++;
                    continue;
                }

                if (height[leftIndex] > height[rightIndex])
                {
                    maxArea = Math.Max(maxArea, (rightIndex - leftIndex) * height[rightIndex]);

                    rightIndex--;
                    continue;
                }
            }

            return maxArea;
        }
    }
}
