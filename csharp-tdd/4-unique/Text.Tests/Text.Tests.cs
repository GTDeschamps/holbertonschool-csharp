using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void UniqueChar_InputString_ReturnsIndexOfFirstNonRepeatingChar()
        {
            // Arrange
            string input = "leetcode";
            int expectedIndex = 0;

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.AreEqual(expectedIndex, result);
        }

        [Test]
        public void UniqueChar_InputStringWithAllRepeatingChars_ReturnsNegativeOne()
        {
            // Arrange
            string input = "hello";
            int expectedIndex = -1;

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.AreEqual(expectedIndex, result);
        }

        [Test]
        public void UniqueChar_EmptyString_ReturnsNegativeOne()
        {
            // Arrange
            string input = "";
            int expectedIndex = -1;

            // Act
            int result = Str.UniqueChar(input);

            // Assert
            Assert.AreEqual(expectedIndex, result);
        }
    }
}
