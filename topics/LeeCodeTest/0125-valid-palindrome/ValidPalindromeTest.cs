using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeeCode._0125_valid_palindrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0125_valid_palindrome
{
    [TestClass()]
    public class ValidPalindromeTest
    {
        [TestMethod()]
        [DataRow("A man, a plan, a canal: Panama", true)]
        [DataRow("race a car", false)]
        [DataRow(" ", true)]
        public void IsPalindromeTest(string s, bool expectedRes)
        {
            var impl = new ValidPalindromeImpl();
            var isPalindrome = impl.IsPalindrome(s);

            Assert.AreEqual(expectedRes, isPalindrome);
        }
    }
}