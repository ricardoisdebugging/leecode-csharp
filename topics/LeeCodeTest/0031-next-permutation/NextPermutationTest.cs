namespace LeeCode._0031_next_permutation
{
    [TestClass()]
    public class NextPermutationTest
    {
        [TestMethod()]
        [DataRow(new int[] { 1, 6, 5, 8, 4, 3, 2 }, new int[] { 1, 6, 2, 3, 4, 5, 8 })]
        [DataRow(new int[] { 1, 5, 6, 8, 4, 3, 2 }, new int[] { 1, 5, 8, 2, 3, 4, 6 })]
        [DataRow(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 3, 2 })]
        [DataRow(new int[] { 1, 3, 2 }, new int[] { 2, 1, 3 })]
        [DataRow(new int[] { 1, 1, 5 }, new int[] { 1, 5, 1 })]
        public void NextPermutationSolution1Test(int[] nums, int[] nextArray)
        {
            NextPermutationImpl.NextPermutationSolution1(nums);

            CollectionAssert.AreEquivalent(nextArray, nums);
        }
    }
}