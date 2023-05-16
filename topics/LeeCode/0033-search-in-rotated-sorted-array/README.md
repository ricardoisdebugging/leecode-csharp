假设有0<= i < i+k <= i+n
其中i>=0, n>0, n>=k>0

如果在k处旋转，那么旋转前在索引区间[i, i+k)以及[i+k, i+n)之间，都是单调递增
旋转后，原数组变成[i+k, i+n)，[i, i+k)，是先递增、再递减，所以最大值一定是索引i+n

因此可以先找到最大值的索引，然后二分查找

---
题目 #
Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.

(i.e., [0,1,2,4,5,6,7] might become [4,5,6,7,0,1,2]).

You are given a target value to search. If found in the array return its index, otherwise return -1.

You may assume no duplicate exists in the array.

Your algorithm’s runtime complexity must be in the order of O(log n).

Example 1:

Input: nums = [4,5,6,7,0,1,2], target = 0
Output: 4
Example 2:

Input: nums = [4,5,6,7,0,1,2], target = 3
Output: -1

题目大意 #
假设按照升序排序的数组在预先未知的某个点上进行了旋转。( 例如，数组 [0,1,2,4,5,6,7] 可能变为 [4,5,6,7,0,1,2] )。搜索一个给定的目标值，如果数组中存在这个目标值，则返回它的索引，否则返回 -1 。你可以假设数组中不存在重复的元素。
你的算法时间复杂度必须是 O(log n) 级别。