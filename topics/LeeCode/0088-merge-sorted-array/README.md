题目 #
Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.

Note:

The number of elements initialized in nums1 and nums2 are m and n respectively.
You may assume that nums1 has enough space (size that is equal to m + n) to hold additional elements from nums2.
Example:

Input:
nums1 = [1,2,3,0,0,0], m = 3
nums2 = [2,5,6],       n = 3

Output: [1,2,2,3,5,6]
Constraints:

-10^9 <= nums1[i], nums2[i] <= 10^9
nums1.length == m + n
nums2.length == n
题目大意 #
合并两个已经有序的数组，结果放在第一个数组中，第一个数组假设空间足够大。要求算法时间复杂度足够低。