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