namespace LeeCode._0031_next_permutation
{
    public class NextPermutationImpl
    {
        public static void NextPermutationSolution1(int[] nums)
        {
            int i;
            for (i = nums.Length - 1; i >= 1; i--)
            {
                if (nums[i - 1] < nums[i])
                    break;
            }


            if (i - 1 >=0)
            {
                int j;
                for (j = nums.Length - 1; i - 1 < j; j--)
                {
                    if (nums[j] > nums[i - 1])
                        break;
                }

                Swap(nums, i - 1, j);
            }

            Reverse(nums, i);
        }

        private static void Reverse(int[] nums, int start)
        {
            int left = start, right = nums.Length - 1;
            while (left < right)
            {
                Swap(nums, left, right);
                left++;
                right--;
            }
        }

        private static void Swap(int[] nums, int aIndex, int bIndex)
        {
            int tmp = nums[aIndex];
            nums[aIndex] = nums[bIndex];
            nums[bIndex] = tmp;
        }

        private static void QuickSort(int[] nums, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int pivot = Partition(nums, leftIndex, rightIndex);

                QuickSort(nums, leftIndex, pivot - 1);
                QuickSort(nums, pivot + 1, rightIndex);
            }
        }

        //单路快排
        private static int Partition(int[] nums, int left, int right)
        {
            int pivot = nums[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (nums[j] < pivot)
                {
                    i++;
                    Swap(nums, i, j);
                }
            }
            Swap(nums, i + 1, right);
            return i + 1;
        }

    }
}
