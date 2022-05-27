using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Task9.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [DataTestMethod]
        [DynamicData(nameof(GetDataForReverseOrderOfCharactersInWords), DynamicDataSourceType.Method)]
        public void ReverseOrderOfCharactersInWords_CheckVariousParameters(string str, string expected)
        {
            string actual = Program.ReverseOrderOfCharactersInWords(str);

            Assert.AreEqual(expected, actual);
        }

        private static IEnumerable<object[]> GetDataForReverseOrderOfCharactersInWords()
        {
            yield return new object[] { "just a string", "tsuj a gnirts" };
            yield return new object[] { "Just a String", "tsuJ a gnirtS" };
            yield return new object[] { "Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc" };
        }

        [TestMethod]
        public void ReverseOrderOfCharactersInWords_PassNull_ThrowsException()
        {
            string str = null;

            Assert.ThrowsException<ArgumentNullException>(() => Program.ReverseOrderOfCharactersInWords(str));
        }
    }
}
