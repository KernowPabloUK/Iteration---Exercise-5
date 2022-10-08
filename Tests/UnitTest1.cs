using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iteration___Exercise_5;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculatMaxValue_NegativeNumber()
        {
            // Arrange 
            string strInput = "1,2,3,4,5,6,-1";

            // Act
            int nOutput = Program.CalculatMaxValue(strInput);

            // Assert
            Assert.AreEqual(6, nOutput);
        }

        [TestMethod]
        [ExpectedException(typeof(System.OverflowException))]
        public void TestCalculatMaxValue_HugeNumber()
        {
            // Arrange 
            string strInput = "1,2222222222222222,3,4,5,6,-1";

            // Act
            int nOutput = Program.CalculatMaxValue(strInput);
        }

        [TestMethod]
        public void TestCalculatMaxValue_EmptyString()
        {
            // Arrange 
            string strInput = "";

            // Act
            int nOutput = Program.CalculatMaxValue(strInput);

            // Assert
            Assert.AreEqual(0, nOutput);
        }
    }
}
