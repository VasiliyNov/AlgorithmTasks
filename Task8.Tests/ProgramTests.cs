using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Task8.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void GetMountainPeakIndex_PassEmptyArray_ThrowsException()
        {
            int[] arr = Array.Empty<int>();

            var ex = Assert.ThrowsException<ArgumentException>(() => Program.GetMountainPeakIndex(arr));
            StringAssert.Contains(ex.Message, "Array cannot be empty (Parameter 'array')");
        }

        [TestMethod]
        public void GetMountainPeakIndex_PassNull_ThrowsException()
        {
            int[] arr = null;

            var ex = Assert.ThrowsException<ArgumentNullException>(() => Program.GetMountainPeakIndex(arr));
            StringAssert.Contains(ex.Message, "Value cannot be null. (Parameter 'array')");
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDataForGetMountainPeakIndex), DynamicDataSourceType.Method)]
        public void GetMountainPeakIndex_CheckVariousParameters(int[] arr, int expected)
        {
            int actual = Program.GetMountainPeakIndex(arr);

            Assert.AreEqual(expected, actual);
        }

        private static IEnumerable<object[]> GetDataForGetMountainPeakIndex()
        {
            yield return new object[] { new int[] { 24, 79, 69, 100, 99, 78, 67, 36, 26, 19 }, 3 };
            yield return new object[] { new int[] { -2, -1, 2, 3, 4, 5, 3, 2 }, 5 };
            yield return new object[] { new int[] { 10 }, 0 };
        }
    }
}
