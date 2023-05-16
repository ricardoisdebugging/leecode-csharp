
1. 首先确认复杂度是O(n)，采用双指针
2. 于是想到应该用While语句进行循环控制，每次循环体内做大小判断即可
- 注意，采用显式的临时变量，可以降低计算耗时（堆栈指针提高效率），但是会增加CPU消耗。反过来，通过内联临时变量，可以降低CPU消耗，但是会增加计算耗时。

---
题目 #
Given n non-negative integers a1, a2, …, an , where each represents a point at coordinate (i, ai). n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). Find two lines, which together with x-axis forms a container, such that the container contains the most water.

Note: You may not slant the container and n is at least 2.

The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.

Example 1:


Input: [1,8,6,2,5,4,8,3,7]
Output: 49

题目大意 #
给出一个非负整数数组 a1，a2，a3，…… an，每个整数标识一个竖立在坐标轴 x 位置的一堵高度为 ai 的墙，选择两堵墙，和 x 轴构成的容器可以容纳最多的水。