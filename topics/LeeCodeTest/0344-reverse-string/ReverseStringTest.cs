using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeeCode._0344_reverse_string;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0344_reverse_string
{
    [TestClass()]
    public class ReverseStringTest
    {
        [TestMethod()]
        [DataRow("hannah", "hannah")]
        [DataRow("hello", "olleh")]
        [DataRow("i", "i")]
        public void ReverseString(string value, string reverseValue)
        {
            char[] chars = value.ToCharArray();
            char[] reverseChars = reverseValue.ToCharArray();

            var impl = new ReverseStringImpl();
            impl.ReverseString(chars);

            CollectionAssert.AreEqual(chars, reverseChars);
        }
    }
}