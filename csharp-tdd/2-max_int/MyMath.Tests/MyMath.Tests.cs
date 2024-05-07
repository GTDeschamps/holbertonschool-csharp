using System;
using System.Collections.Generic;
using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Max_WhenListIsEmpty_ReturnsZero()
        {
            List<int> emptyList = new List<int>();
            int result = Operations.Max(emptyList);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Max_WhenListHasOneElement_ReturnsThatElement()
        {
            List<int> list = new List<int> { 5 };
            int result = Operations.Max(list);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Max_WhenListHasMultipleElements_ReturnsMax()
        {
            List<int> list = new List<int> { 3, 7, 2, 9, 4 };
            int result = Operations.Max(list);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void Max_WhenListHasNegativeNumbers_ReturnsMax()
        {
            List<int> list = new List<int> { -3, -7, -2, -9, -4 };
            int result = Operations.Max(list);
            Assert.AreEqual(-2, result);
        }
    }
}
