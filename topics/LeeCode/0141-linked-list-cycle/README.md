题目 #
Given a linked list, determine if it has a cycle in it.

Follow up:
Can you solve it without using extra space?

题目大意 #
判断链表是否有环，不能使用额外的空间。

---
一种是哈希表，和TwoSum类似
一种是快慢指针————
这里的设置是快指针每次往前两步、慢指针每次往前一步。
- 由于（若）是环，快指针一定会在n周期后追上慢指针。
- 若快指针前进过快，可能在一些用例上，造成快指针永远追不上慢指针