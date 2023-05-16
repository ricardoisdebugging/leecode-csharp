基本思路是，排除负数（符号）干扰后，

将整数作为数组，通过双指针、从两端分别比较对称位置的值：
如果是回文，那么对称位置的值一定是相等的

约束条件就是双指针的大小不能交换；
临界情况要么左右指针相等————此时回文数列是奇数个，要么左右指针大小交换————此时回文数列是偶数个

---
题目 #
Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.

Example 1:

Input: 121
Output: true
Example 2:

Input: -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
Example 3:

Input: 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
Follow up:

Coud you solve it without converting the integer to a string?

题目大意 #
判断一个整数是否是回文数。回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数。