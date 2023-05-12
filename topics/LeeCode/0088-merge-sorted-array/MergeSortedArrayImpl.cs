using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0088_merge_sorted_array
{
    public class MergeSortedArrayImpl
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var list1 = nums1.ToList();
            list1.RemoveRange(m, n);

            var sortedDuplicatedArray = list1.Concat(nums2.ToList()).ToList();

            sortedDuplicatedArray.Sort();

            if (m == 0)
                sortedDuplicatedArray.Where(x => x != 0);

            for( int i = 0; i < m + n; i++)
            {
                nums1[i] = sortedDuplicatedArray[i];
            }
        }
    }
}
