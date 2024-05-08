using System;
using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void TestIsPalindrome()
        {
            // Test palindrome strings
            Assert.IsTrue(Str.IsPalindrome("Racecar"));
            Assert.IsTrue(Str.IsPalindrome("level"));
            Assert.IsTrue(Str.IsPalindrome("A man, a plan, a canal: Panama."));

            // Test non-palindrome strings
            Assert.IsFalse(Str.IsPalindrome("hello"));
            Assert.IsFalse(Str.IsPalindrome("123456"));
            Assert.IsFalse(Str.IsPalindrome("Palindrome"));

            // Test empty string
            Assert.IsTrue(Str.IsPalindrome(""));

            // Test palindrome with spaces
            Assert.IsTrue(Str.IsPalindrome("never odd or even"));
        }
    }
}
