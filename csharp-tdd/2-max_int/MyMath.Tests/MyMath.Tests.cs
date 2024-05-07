using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void TestMax()
        {
            // Test with an empty list
            List<int> emptyList = new List<int>();
            Assert.AreEqual(0, Operations.Max(emptyList));

            // Test with a list containing one element
            List<int> oneElementList = new List<int> { 5 };
            Assert.AreEqual(5, Operations.Max(oneElementList));

            // Test with a list containing multiple elements
            List<int> multipleElementsList = new List<int> { 3, 7, 2, 9, 1, 4, 8, 6 };
            Assert.AreEqual(9, Operations.Max(multipleElementsList));
        }
    }
}
