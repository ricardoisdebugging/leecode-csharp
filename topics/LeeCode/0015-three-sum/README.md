开始的时候，测试代码（单元测试）尝试DataRow输入多个用例，发现返回值遇到问题
```
[TestMethod()]
[DataRow(new int[] { 0, 0, 0 }, new List<IList<int>>() { new List<int>() { 0, 0, 0 } }]
public void ThreeSumWithTwoPointersTest(int[] nums, IList<IList<int>> expectedValues)
```
报错的内容是“特性实参必须是特性形参类型的常量表达式、typeof 表达式或数组创建表达式”
这主要是因为DataRow应该只能接收编译时的常量


后来尝试了一下嵌套数组
https://www.cnblogs.com/tcjiaan/p/3530392.html
```
[TestMethod()]
[DataRow(new int[] { 0, 0, 0 }, new int[1][] { new int[3] { 0, 0, 0 } })]
public void ThreeSumWithTwoPointersTest(int[] nums, IList<IList<int>> expectedValues)
```
也不行。


查阅了一下DataRow的接口
```
//
// 摘要:
//     Initializes a new instance of the Microsoft.VisualStudio.TestTools.UnitTesting.DataRowAttribute
//     class which takes in an array of arguments.
//
// 参数:
//   data1:
//     A data object.
//
//   moreData:
//     More data.
public DataRowAttribute(object data1, params object[] moreData)
{
    if (moreData == null)
    {
        moreData = new object[1];
    }

    Data = new object[moreData.Length + 1];
    Data[0] = data1;
    Array.Copy(moreData, 0, Data, 1, moreData.Length);
}
```
发现是参数数组

目前没有别的处理方式，只能用规定的字符串来组合期望值、然后对字符串后处理得到期望值类型