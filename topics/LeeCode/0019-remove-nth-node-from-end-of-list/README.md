﻿有两种方法：

解决方案1————两段操作
由于链表无法一下子获取整体长度，所以需要第一次遍历、获取链表长度数据
一旦有了长度，第二次遍历只需要找到对应位置、然后修改链表前后关系即可

解决方案2————快慢指针
这里的两个指针，主要起到滑动窗口的左右————快指针在右、慢指针在左，
当快指针到达链表最后一个元素位置时，窗口左边界、即慢指针就是对应位置，然后修改链表前后关系即可
要注意的是，由于不知道长度，因此对于n=1的场景、无法在只有一个头结点的情况下进行判断，
所以需要一个哑指针

---
题目 #
Given the head of a linked list, remove the nth node from the end of the list and return its head.

Follow up: Could you do this in one pass?

Example 1:



Input: head = [1,2,3,4,5], n = 2
Output: [1,2,3,5]

Example 2:

Input: head = [1], n = 1
Output: []

Example 3:

Input: head = [1,2], n = 1
Output: [1]

Constraints:

The number of nodes in the list is sz.
1 <= sz <= 30
0 <= Node.val <= 100
1 <= n <= sz
题目大意 #
删除链表中倒数第 n 个结点。