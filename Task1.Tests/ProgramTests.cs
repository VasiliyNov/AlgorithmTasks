using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task1;

namespace Task1.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void FindFrequentElement_ArrayWithFrequentElement2_Returns2()
        {
            int[] numbers = new int[] { 1, 2, 2, 2, 2, 5, 5, 6, 7, 8 };
            int expected = 2;

            int actual = Program.FindFrequentElement(numbers);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindFrequentElement_ArrayWithOneElement1_Returns1()
        {
            int[] numbers = new int[] { 1 };
            int expected = 1;

            int actual = Program.FindFrequentElement(numbers);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindFrequentElement_PassNullParameter_ThrowsException()
        {
            int[] numbers = null;

            var ex = Assert.ThrowsException<ArgumentNullException>(() => Program.FindFrequentElement(numbers));
            StringAssert.Contains(ex.Message, "Value cannot be null. (Parameter 'nums')");
        }

        [TestMethod]
        public void FindFrequentElement_PassEmptyParameter_ThrowsException()
        {
            int[] numbers = Array.Empty<int>();

            var ex = Assert.ThrowsException<ArgumentException>(() => Program.FindFrequentElement(numbers));
            StringAssert.Contains(ex.Message, "Array cannot be empty (Parameter 'nums')");
        }

        [TestMethod]
        public void FindFrequentElement_ArrayWithNegativeFrequentNumber1_ReturnsMinus1()
        {
            int[] numbers = new int[] { -1, -1, -1, -1, -1, 1, 2, 2, 7, 8 };
            int expected = -1;

            int actual = Program.FindFrequentElement(numbers);

            Assert.AreEqual(expected, actual);
        }
    }
}
