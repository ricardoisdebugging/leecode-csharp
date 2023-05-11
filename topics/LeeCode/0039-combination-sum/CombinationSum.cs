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

            if (res + candidates[nodeIdx] > target)
                return;

            if (res + candidates[nodeIdx] == target)
            {
                combination.Add(candidates[nodeIdx]);
                potentialCombs.Add(combination.ToList());
                combination.RemoveAt(combination.Count - 1);
                return;
            }         

            for(int i = nodeIdx; i < candidates.Length; i++)
            {
                res += candidates[i];
                combination.Add(candidates[i]);

                if (res < target)
                {
                    //search from the left node
                    DepthFirstSearch(candidates, target, i);
                    //search from the right node
                    DepthFirstSearch(candidates, target, i + 1);
                }

                if (res == target)
                    potentialCombs.Add(combination.ToList());

                res -= candidates[i];
                combination.RemoveAt(combination.Count - 1);         
            }    

        }
    }
}
