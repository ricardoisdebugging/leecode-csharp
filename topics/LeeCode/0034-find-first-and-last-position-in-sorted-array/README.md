经典的二分搜索变种题。二分搜索有 4 大基础变种题：

1. 查找第一个值等于给定值的元素
2. 查找最后一个值等于给定值的元素
3. 查找第一个大于等于给定值的元素
4. 查找最后一个小于等于给定值的元素

对于1和2，可以参考31题，找到所谓“第一个”以及“最后一个”元素有类似的方式进行处理

这一题的解题思路可以分别利用变种 1 和变种 2 的解法就可以做出此题。

---
题目 #
Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.

Your algorithm’s runtime complexity must be in the order of O(log n).

If the target is not found in the array, return [-1, -1].

Example 1:

Input: nums = [5,7,7,8,8,10], target = 8
Output: [3,4]
Example 2:

Input: nums = [5,7,7,8,8,10], target = 6
Output: [-1,-1]
题目大意 #
给定一个按照升序排列的整数数组 nums，和一个目标值 target。找出给定目标值在数组中的开始位置和结束位置。你的算法时间复杂度必须是 O(log n) 级别。如果数组中不存在目标值，返回 [-1, -1]。