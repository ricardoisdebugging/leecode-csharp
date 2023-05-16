二分法的边界条件判断不熟练

另外对于算法的变体中、灵活修改条件，换思路（对审题不够详尽）：
这道题可以改成不小于比目标值的最小数，这样的话、如果是目标值自己，那么索引正好是自己，如果比目标值大，那么索引就是目标值插入的位置
还有就是要确定边界条件之类的

对LINQ进行适当的分析，时间上会有优化

---
题目 #
Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You may assume no duplicates in the array.

Example 1:

Input: [1,3,5,6], 5
Output: 2
Example 2:

Input: [1,3,5,6], 2
Output: 1
Example 3:

Input: [1,3,5,6], 7
Output: 4
Example 4:

Input: [1,3,5,6], 0
Output: 0
题目大意 #
给定一个排序数组和一个目标值，在数组中找到目标值，并返回其索引。如果目标值不存在于数组中，返回它将会被按顺序插入的位置。

你可以假设数组中无重复元素。