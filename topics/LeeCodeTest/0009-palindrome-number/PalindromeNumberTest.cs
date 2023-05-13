using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeeCode._0009_palindrome_number;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0009_palindrome_number
{
    [TestClass()]
    public class PalindromeNumberTest
    {
        [TestMethod()]
        [DataRow(121, true)]
        [DataRow(-121, false)]
        [DataRow(10, false)]
        [DataRow(1, true)]
        [DataRow(123321, true)]
        public void IsPalindromeTest(int x, bool expectedValue)
        {
            var palindromeNumberImpl = new PalindromeNumberImpl();
            var isParlindrom = palindromeNumberImpl.IsPalindrome(x);

            Assert.AreEqual(expectedValue, isParlindrom);
        }
    }
}