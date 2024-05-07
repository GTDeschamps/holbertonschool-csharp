using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Add_WhenCalled_ReturnsSumOfTwoNumbers()
        {
            // Arrange
            int a = 5;
            int b = 3;
            int expected = 8;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_WithNegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = -7;
            int b = 4;
            int expected = -3;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // You can add more test cases for different scenarios
    }
}
