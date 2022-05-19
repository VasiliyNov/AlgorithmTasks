using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Task6.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [DataTestMethod]
        [DynamicData(nameof(GetDataForCheckConsistentStrings), DynamicDataSourceType.Method)]
        public void CheckConsistentStrings_CheckVariousParameters(string allowed, string[] words, int expected)
        {
            int actual = Program.CheckConsistentStrings(allowed, words);

            Assert.AreEqual(expected, actual);
        }

        private static IEnumerable<object[]> GetDataForCheckConsistentStrings()
        {
            yield return new object[] { "abc", new string[] { "a", "b", "c", "ab", "ac", "bc", "abc" }, 7 };
            yield return new object[] { "ab", new string[] { "a", "b", "c", "ab", "ac", "bc", "abc" }, 3 };
            yield return new object[] { "ab", new string[] { "ad", "bd", "aaab", "baa", "badab" }, 2 };
            yield return new object[] { "ab", new string[] { "ad", "bd", "caab", "baac", "badab" }, 0 };
        }

        [DataTestMethod]
        [DynamicData(nameof(GetEmptyDataForCheckConsistentStrings), DynamicDataSourceType.Method)]
        public void CheckConsistentStrings_CheckVariousEmptyParameters(string allowed, string[] words, int expected)
        {
            int actual = Program.CheckConsistentStrings(allowed, words);

            Assert.AreEqual(expected, actual);
        }

        private static IEnumerable<object[]> GetEmptyDataForCheckConsistentStrings()
        {
            yield return new object[] { "ab", Array.Empty<string>(), 0 };
            yield return new object[] { String.Empty, new string[] { "ad", "bd", "aaab", "baa", "badab" }, 0 };
            yield return new object[] { String.Empty, Array.Empty<string>(), 0 };
        }

        [TestMethod]
        public void CheckSelfDividingNumber_PassNullParameterAllowed_ThrowsException()
        {
            string allowed = null;
            string[] words = new[] { "ad", "bd", "aaab", "baa", "badab" };

            var ex = Assert.ThrowsException<ArgumentNullException>(() => Program.CheckConsistentStrings(allowed, words));
            StringAssert.Contains(
                "Value cannot be null. (Parameter 'allowed, masWords')",
                ex.Message);
        }

        [TestMethod]
        public void CheckSelfDividingNumber_PassNullParameterWords_ThrowsException()
        {
            string allowed = "ab";
            string[] words = null;

            var ex = Assert.ThrowsException<ArgumentNullException>(() => Program.CheckConsistentStrings(allowed, words));
            StringAssert.Contains(
                "Value cannot be null. (Parameter 'allowed, masWords')",
                ex.Message);
        }
    }
}
