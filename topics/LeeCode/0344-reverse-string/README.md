比较简单。首尾两个指针各自向中间靠近即可，过程不断交换收尾指针指向的元素数值。
要注意的就是边界条件
---
题目 #
Write a function that reverses a string. The input string is given as an array of characters char[].

Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

You may assume all the characters consist of printable ascii characters.

Example 1:


Input: ["h","e","l","l","o"]
Output: ["o","l","l","e","h"]

Example 2:


Input: ["H","a","n","n","a","h"]
Output: ["h","a","n","n","a","H"]

题目大意 #
题目要求我们反转一个字符串。

解题思路 #
这一题的解题思路是用 2 个指针，指针对撞的思路，来不断交换首尾元素，即可。