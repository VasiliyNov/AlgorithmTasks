using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Task7.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DynamicData(nameof(GetDataForReplacElementsInArray), DynamicDataSourceType.Method)]
        public void ReplacElementsInArray_CheckVariousParameters(int[] arr, int[] expectedArr)
        {
            Program.ReplacElementsInArray(arr);

            CollectionAssert.AreEqual(expectedArr, arr);
        }

        private static IEnumerable<object[]> GetDataForReplacElementsInArray()
        {
            yield return new object[] { new int[] { 2 }, new int[] { -1 } };
            yield return new object[] { new int[] { 17, 18, 5, 4, 6, 1 }, new int[] { 18, 6, 6, 6, 1, -1 } };
            yield return new object[] { new int[] { 3, 3, 3, 3 }, new int[] { 3, 3, 3, -1 } };
        }

        [TestMethod]
        public void ReplacElementsInArray_PassEmptyArray_ArrayRemainsEmpty()
        {
            int[] arr = Array.Empty<int>();
            int expectedLength = 0;

            Program.ReplacElementsInArray(arr);

            Assert.AreEqual(expectedLength, arr.Length);
        }

        [TestMethod]
        public void ReplacElementsInArray_PassNull_ThrowsException()
        {
            int[] arr = null;

            var ex = Assert.ThrowsException<ArgumentNullException>(() => Program.ReplacElementsInArray(arr));
            StringAssert.Contains(ex.Message, "Value cannot be null. (Parameter 'array')");
        }
    }
}
