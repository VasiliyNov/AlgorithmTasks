using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Task4.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckUniqueOccurrencesInArray_PassUniqueOccurrencesInArray_ReturnsTrue()
        {
            int[] arr = new int[] { 1, 2, 3, 3, 3, 5, 5, 5, 5, 2 };

            bool actual = Program.CheckUniqueOccurrencesInArray(arr);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckUniqueOccurrencesInArray_PassNonUniqueOccurrencesInArray_ReturnsFalse()
        {
            int[] arr = new int[] { 2, 1, 2, 3, 3 };

            bool actual = Program.CheckUniqueOccurrencesInArray(arr);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckUniqueOccurrencesInArray_PassNull_ThrowsException()
        {
            int[] arr = null;

            var ex = Assert.ThrowsException<ArgumentNullException>(() => Program.CheckUniqueOccurrencesInArray(arr));
            StringAssert.Contains(ex.Message, "Value cannot be null. (Parameter 'arr')");
        }

        [TestMethod]
        public void CheckUniqueOccurrencesInArray_PassEmptyArray_ThrowsException()
        {
            int[] numbers = Array.Empty<int>();

            var ex = Assert.ThrowsException<ArgumentException>(() => Program.CheckUniqueOccurrencesInArray(numbers));
            StringAssert.Contains(ex.Message, "Array cannot be empty. (Parameter 'arr')");
        }
    }
}
