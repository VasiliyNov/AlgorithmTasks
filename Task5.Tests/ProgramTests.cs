using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Task5.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void GetDigitsFromNumber_PassNumber123_ReturnsListOfDigits1_2_3()
        {
            List<int> expected = new() { 1, 2, 3 };

            List<int> actual = Program.GetDigitsFromNumber(123);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDigitsFromNumber_PassNumberMinus1_ThrowsException()
        {
            int number = -1;

            var ex = Assert.ThrowsException<ArgumentException>(() => Program.GetDigitsFromNumber(number));
            StringAssert.Contains("Parameter 'number' must be positive number.", ex.Message);
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDataForIsDividableByEveryDigit), DynamicDataSourceType.Method)]
        public void IsDividableByEveryDigit_CheckVariousParameters(int number, List<int> digits, bool expected)
        {
            bool actual = Program.IsDividableByEveryDigit(number, digits);

            Assert.AreEqual(expected, actual);
        }

        private static IEnumerable<object[]> GetDataForIsDividableByEveryDigit()
        {
            yield return new object[] { 128, new List<int> { 1, 2, 8 }, true };
            yield return new object[] { 120, new List<int> { 1, 2, 0 }, false };
            yield return new object[] { 127, new List<int> { 1, 2, 7 }, false };
        }


        [DataTestMethod]
        [DataRow(2, 1)]
        [DataRow(-1, 2)]
        [DataRow(1, -2)]
        [DataRow(-1, -2)]
        public void CheckSelfDividingNumber_CheckVariousParameters_ThrowsException(int left, int right)
        {
            var ex = Assert.ThrowsException<ArgumentException>(() => Program.CheckSelfDividingNumber(left, right));
            StringAssert.Contains(
                "Parameters 'left' and 'right' must be positive numbers. And 'right' must be bigger than 'left'.",
                ex.Message);
        }

        [TestMethod]
        public void CheckSelfDividingNumber_Pass9and20_Returns9_11_12_15()
        {
            List<int> expected = new() { 9, 11, 12, 15 };

            List<int> actual = Program.CheckSelfDividingNumber(9, 20);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
