
# 快速排序
目前使用了单路快排

双路快排失效

# 求解思路
最终也没有必要用快排，而是用了业务逻辑

以1, 5, 6, 7, 8, 4, 2为例，
因为要找到一个较小数偏右（这样交换的大数也会很小）、较大数靠近较小数。

第一步，要找到nums[i] < nums[i + 1]，这样[i+1, n)必然是下降区间————可以动手找几个例子尝试下
但是这里要注意，必须要使得i尽可能大，比如5<6、但是这样一对数字显然不应该取
所以要找num[i + 1]最大的值。
考虑到[i+1, n)，可以从右往左(k递减)，找到第一个nums[k - 1] < nums[k]。
此时，k-1即是i值。

第二步，要在[i+1, n)区间内，从左到右(j递减)，找到一个第一个j，使得nums[i] < nums[j]。
比如1, 8, 3, 2，选择的nums[i]是1，nums[i + 1]是8，在区间[1, 4）中，第一个满足条件的j值是3、即2

第三步，交换nums[i]与nums[j]。

第四步，对于[i+1, n)，重新排序

---
题目 #
Implement next permutation, which rearranges numbers into the lexicographically next greater permutation of numbers.

If such an arrangement is not possible, it must rearrange it as the lowest possible order (i.e., sorted in ascending order).

The replacement must be  in place and use only constant extra memory.

Example 1:

Input: nums = [1,2,3]
Output: [1,3,2]
Example 2:

Input: nums = [3,2,1]
Output: [1,2,3]
Example 3:

Input: nums = [1,1,5]
Output: [1,5,1]
Example 4:

Input: nums = [1]
Output: [1]
Constraints:

1 <= nums.length <= 100
0 <= nums[i] <= 100
题目大意 #
实现获取 下一个排列 的函数，算法需要将给定数字序列重新排列成字典序中下一个更大的排列。如果不存在下一个更大的排列，则将数字重新排列成最小的排列（即升序排列）。必须 原地 修改，只允许使用额外常数空间。
