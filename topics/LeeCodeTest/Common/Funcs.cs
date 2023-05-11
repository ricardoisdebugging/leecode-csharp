using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCodeTest.Common
{
    public class Funcs
    {
        public static IList<IList<int>> ConvertStringToTargetNestedList(string valueText)
        {
            var valuesList = valueText.Split("@@");
            var result = new List<IList<int>>();
            foreach (var values in valuesList)
            {
                var arr = values.Split('&').Select(x => int.Parse(x)).ToList();
                result.Add(arr);
            }

            return result;
        }
    }
}
