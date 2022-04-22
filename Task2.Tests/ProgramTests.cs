using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task2;

namespace Task2.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void CheckingDivisionBy3And5_PassParameter15_ReturnsArray()
        {
            int param = 15;
            string[] expected = new string[] {
                "FizzBuzz", "1", "2", "Fizz", "4", "Buzz", "Fizz", "7","8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };

            string[] actual = Program.CheckingDivisionBy3And5(param);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckingDivisionBy3And5_PassParameter0_ReturnsFizzBuzz()
        {
            int param = 0;
            string[] expected = new string[] { "FizzBuzz" };

            string[] actual = Program.CheckingDivisionBy3And5(param);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckingDivisionBy3And5_PassNegativeParameter_ThrowsException()
        {
            int negativeParam = -1;

            var ex = Assert.ThrowsException<ArgumentException>(() => Program.CheckingDivisionBy3And5(negativeParam));
            StringAssert.Contains(ex.Message, "Parameter cannot be negative (Parameter 'n')");
        }
    }
}
