using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
