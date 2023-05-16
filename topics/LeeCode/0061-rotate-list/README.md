双指针实现

参考了官网的思路、实现环————尾结点的下个结点设置成头结点（找到尾结点的同时，顺便记录下了链表长度）

基于环（其实是环比较方便思考），考虑旋转的次数如果和链表长度一致，则无须循环；因此，对于要求的旋转次数，除于链表长度后取模即为真正的旋转次数————其余都是做周期循环。

接下来考虑双指针：

对于链表[1,2,3,4,5]
如果是环，则表现为1,2,3,4,5,1,2,3,4,5,1,2,3,4,5,....
由于原链表不变，因此就是一个滑动窗口（窗口宽度为链表长度）

关键是要滑动到什么位置————
考虑实际情况是把尾结点加到头结点，找到规律：
旋转1次，[5,1,2,3,4]，滑动4个索引位置
旋转2次，[4,5,1,2,3]，滑动3个索引位置

结论是滑动次数=链表长度-旋转次数

---
题目 #
Given a linked list, rotate the list to the right by k places, where k is non-negative.

Example 1:


Input: 1->2->3->4->5->NULL, k = 2
Output: 4->5->1->2->3->NULL
Explanation:
rotate 1 steps to the right: 5->1->2->3->4->NULL
rotate 2 steps to the right: 4->5->1->2->3->NULL 

Example 2:


Input: 0->1->2->NULL, k = 4
Output: 2->0->1->NULL
Explanation:
rotate 1 steps to the right: 2->0->1->NULL
rotate 2 steps to the right: 1->2->0->NULL
rotate 3 steps to the right: 0->1->2->NULL
rotate 4 steps to the right: 2->0->1->NULL 

题目大意 #
旋转链表 K 次。