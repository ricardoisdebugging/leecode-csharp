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
        Stack<int> combination;
        IList<IList<int>> potentialCombs;

        public IList<IList<int>> CombinationSumImpl(int[] candidates, int target)
        {
            res = 0;
            combination = new Stack<int>();
            potentialCombs = new List<IList<int>>();

            DepthFirstSearch(candidates, target, 0);
            return potentialCombs;
        }

        private void DepthFirstSearch(int[] candidates, int target, int nodeIdx)
        {
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
                combination.Push(candidate);

                DepthFirstSearch(candidates, target, i);

                res -= candidate;
                if (combination.Count > 1)
                    combination.Pop();
                else
                    combination.Clear();
            }
        }
    }
}
