using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void CamelCase_InputString_ReturnsCorrectNumberOfWords()
        {
            // Arrange
            string input = "camelCaseTestString";
            int expectedCount = 4;

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.AreEqual(expectedCount, result);
        }

        [Test]
        public void CamelCase_EmptyString_ReturnsZero()
        {
            // Arrange
            string input = "";
            int expectedCount = 0;

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.AreEqual(expectedCount, result);
        }

        [Test]
        public void CamelCase_SingleWord_ReturnsOne()
        {
            // Arrange
            string input = "hello";
            int expectedCount = 1;

            // Act
            int result = Str.CamelCase(input);

            // Assert
            Assert.AreEqual(expectedCount, result);
        }
    }
}
