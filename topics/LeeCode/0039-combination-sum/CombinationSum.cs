using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0039_combination_sum
{
    public class CombinationSum
    {
        int res = 0;
        List<int> combination;
        IList<IList<int>> potentialCombs;

        public IList<IList<int>> CombinationSumImpl(int[] candidates, int target)
        {
            combination = new List<int>();
            potentialCombs = new List<IList<int>>();

            for (int i = 0; i < candidates.Length; i++)
                DepthFirstSearch(candidates, target, i);
            return potentialCombs;
        }

        private void DepthFirstSearch(int[] candidates, int target, int nodeIdx)
        {
            if (nodeIdx >= candidates.Length)
                return;

            if (res + candidates[nodeIdx] > target)
                return;

            if (res + candidates[nodeIdx] == target)
            {
                combination.Add(candidates[nodeIdx]);
                potentialCombs.Add(combination.ToList());
                combination.RemoveAt(combination.Count - 1);
                return;
            }

            res += candidates[nodeIdx];
            combination.Add(candidates[nodeIdx]);

            //search from the left node
            DepthFirstSearch(candidates, target, nodeIdx);
            //search from the right node
            DepthFirstSearch(candidates, target, nodeIdx + 1);

            res -= candidates[nodeIdx];
            combination.RemoveAt(combination.Count - 1);

        }
    }
}
