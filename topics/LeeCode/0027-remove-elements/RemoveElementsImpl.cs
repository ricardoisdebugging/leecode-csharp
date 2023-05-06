using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0027_remove_elements
{
    public class RemoveElementsImpl
    {
        public static int RemoveElementWithRefLinq(ref int[] nums, int val)
        {
            var cutList = nums.ToList().Where(x => x != val).ToList();
            nums = cutList.ToArray();
            return cutList.Count;
        }

        public static int RemoveElementWithLinq(int[] nums, int val)
        {
            var cutList = nums.ToList().Where(x => x != val).ToList();
            for(int i = 0; i < cutList.Count; i++)
                nums[i] = cutList[i];
            return cutList.Count;
        }

        public static int RemoveElementWithPointer(int[] nums, int val)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                    nums[count++] = nums[i];
            }
            return count;
        }
    }
}
