using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Task3.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void SortPairedUnpairedNumbers_PassUnsortedArray_ReturnsSortedArray()
        {
            int[] numbers = { 3, 7, 2, 5, 4, 6 };
            int[] expected = { 6, 5, 4, 7, 2, 3 };

            Program.SortPairedUnpairedNumbers(numbers);
           
            CollectionAssert.AreEqual(expected, numbers);
        }

        [TestMethod]
        public void SortPairedUnpairedNumbers_PassNull_ThrowsException()
        {
            int[] numbers = null;

            var ex = Assert.ThrowsException<ArgumentNullException>(() => Program.SortPairedUnpairedNumbers(numbers));
            StringAssert.Contains(ex.Message, "Value cannot be null. (Parameter 'mas')");
        }

        [TestMethod]
        public void SortPairedUnpairedNumbers_PassEmptyArray_ItShouldStayEmpty()
        {
            int[] numbers = Array.Empty<int>();
            int[] expected = Array.Empty<int>();

            Program.SortPairedUnpairedNumbers(numbers);

            CollectionAssert.AreEqual(expected, numbers);
        }

        [TestMethod]
        public void SortPairedUnpairedNumbers_PassArrayWithOneElement1_ReturnsArrayWithOneElement1()//- - - - -
        {
            int[] numbers = { 1 };
            int[] expected = { 1 };

            Program.SortPairedUnpairedNumbers(numbers);

            CollectionAssert.AreEqual(expected, numbers);
        }
    }
}
