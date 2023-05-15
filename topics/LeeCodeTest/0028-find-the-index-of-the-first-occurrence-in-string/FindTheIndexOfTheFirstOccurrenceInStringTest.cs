using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeeCode._0028_find_the_index_of_the_first_occurrence_in_string;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeCode._0028_find_the_index_of_the_first_occurrence_in_string
{
    [TestClass()]
    public class FindTheIndexOfTheFirstOccurrenceInStringTest
    {
        [TestMethod()]
        [DataRow("sadbutsad", "sad", 0)]
        [DataRow("leetcode", "leeto", -1)]
        [DataRow("abc", "d", -1)]
        [DataRow("hello", "ll", 2)]
        [DataRow("mississippi", "issip", 4)]
        [DataRow("a", "a", 0)]
        public void StrStrTest(string haystack, string needle, int expectedIdx)
        {
            var impl = new FindTheIndexOfTheFirstOccurrenceInStringImpl();
            var realIdx = impl.StrStr(haystack, needle);

            Assert.AreEqual(expectedIdx, realIdx);
        }
    }
}