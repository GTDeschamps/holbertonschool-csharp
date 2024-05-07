using System;
using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class MatrixTests
    {
        [Test]
        public void TestDivide()
        {
            // Test the Divide method with some sample inputs
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] result = Matrix.Divide(matrix, 2);
            Assert.AreEqual(new int[,] { { 0, 1, 1 }, { 2, 2, 3 }, { 3, 4, 4 } }, result);

            matrix = new int[,] { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 } };
            result = Matrix.Divide(matrix, 10);
            Assert.AreEqual(new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }, result);

            matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            result = Matrix.Divide(matrix, 1);
            Assert.AreEqual(new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }, result);

            matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            result = Matrix.Divide(matrix, 3);
            Assert.AreEqual(new int[,] { { 0, 2, 1 }, { 4, 1, 2 }, { 2, 2, 3 } }, result);
        }

        [Test]
        public void TestDivideWithZero()
        {
            // Test the Divide method with num = 0
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Assert.Throws<DivideByZeroException>(() => Matrix.Divide(matrix, 0));
        }

        [Test]
        public void TestDivideWithNullMatrix()
        {
            // Test the Divide method with a null matrix
            int[,] matrix = null;
            Assert.Throws<ArgumentNullException>(() => Matrix.Divide(matrix, 2));
        }
    }
}
