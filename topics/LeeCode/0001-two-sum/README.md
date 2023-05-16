1. 先考虑复杂度，这里是O(n)
2. 然后考虑实现的方式是哈希表，但是我的思路一开始错了————将整个数组转化成哈希表、试图用这样提高检索的效率。实际上正好反过来。
3. 整体的思路是：遍历数组，然后在哈希表中找对应的另一半数值是否存在。如果不存在，则将当前遍历的值存入哈希表————这样遍历到后面的元素，也可以快速检索前面的元素值；如果存在，则将当前元素下标和找到另一半数值的下标返回。
- 注意不要用迭代器编译数组，这样对下标的获取会变得复杂。

空间（缓存住）换时间

---
题目 #
Given an array of integers, return indices of the two numbers such that they add up to a specific target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:
Given nums = [2, 7, 11, 15], target = 9,
Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1]

题目大意 #
在数组中找到 2 个数之和等于给定值的数字，结果返回 2 个数字在数组中的下标。