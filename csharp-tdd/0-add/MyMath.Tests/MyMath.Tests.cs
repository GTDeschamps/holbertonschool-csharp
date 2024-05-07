using System;
using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        [Test]
        public void TestAdd()
        {
            // Test the Add method with some sample inputs
            Assert.AreEqual(3, Operations.Add(1, 2));
            Assert.AreEqual(10, Operations.Add(5, 5));
            Assert.AreEqual(-2, Operations.Add(-3, 1));
        }
    }
}
