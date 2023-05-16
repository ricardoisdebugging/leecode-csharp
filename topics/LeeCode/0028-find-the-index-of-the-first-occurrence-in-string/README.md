首先想到的都是双指针

不过第一个思路是用第二个指针来定位，但是没有考虑滑动的干扰
```
   public int StrStr(string haystack, string needle) {
        var leftIdx = 0;
        var rightIdx = 0;

        var flag = false;
        while(leftIdx < haystack.Length)
        {
            var chrInParent = haystack[leftIdx];
            var chrInChild = needle[rightIdx];

            leftIdx++;
            if (chrInParent == chrInChild)
            {
                flag = true;
                rightIdx++;
            }

            if (rightIdx >= needle.Length)
                break;

            if (chrInParent != chrInChild)
            {
                flag = false;
                rightIdx = 0;
            }
        }

        if (flag)
            return leftIdx - needle.Length;
        else
            return -1;
    }
```

第二个方法就是用快慢指针实现滑动窗口了,
不过快慢指针在第一个索引位的边界条件需要额外处理下————之前处理链表的时候，是通过哑指针实现的（0019）

---
题目 #
Implement strStr().

Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

Example 1:


Input: haystack = "hello", needle = "ll"
Output: 2

Example 2:


Input: haystack = "aaaaa", needle = "bba"
Output: -1

Clarification:

What should we return when needle is an empty string? This is a great question to ask during an interview.

For the purpose of this problem, we will return 0 when needle is an empty string. This is consistent to C’s strstr() and Java’s indexOf().

题目大意 #
实现一个查找 substring 的函数。如果在母串中找到了子串，返回子串在母串中出现的下标，如果没有找到，返回 -1，如果子串是空串，则返回 0 。

解题思路 #