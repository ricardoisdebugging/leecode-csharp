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

            DepthFirstSearch(candidates, target, 0);
            return potentialCombs;
        }

        private void DepthFirstSearch(int[] candidates, int target, int nodeIdx)
        {
            if (nodeIdx >= candidates.Length)
                return;

            if (res > target)
                return;

            if (res == target)
            {
                potentialCombs.Add(combination.ToList());
                return;
            }

            for (int i = nodeIdx; i < candidates.Length; i++)
            {
                var candidate = candidates[i];
                res += candidate;
                combination.Add(candidate);
                var combStream = string.Join('-', combination);

                //search from the left node
                DepthFirstSearch(candidates, target, i);

                res -= candidate;
                if (combination.Count > 1)
                    combination.RemoveAt(combination.Count - 1);
                else
                    combination.Clear();
            }
        }
    }
}
