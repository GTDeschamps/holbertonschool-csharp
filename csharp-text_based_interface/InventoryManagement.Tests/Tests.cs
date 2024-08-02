using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyProject.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAddition()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Add(2, 2);

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivisionByZero()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            calculator.Divide(4, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidInput()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            calculator.Add("a", 2);
        }
    }
}
