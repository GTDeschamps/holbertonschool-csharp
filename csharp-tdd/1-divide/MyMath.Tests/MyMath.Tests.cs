using NUnit.Framework;

namespace MyMath.Tests
{
    public class MatrixTests
    {
        [Fact]
        public void Divide_MatrixIsNull_ReturnsNull()
        {
            int[,] matrix = null;
            int num = 5;

            int[,] result = Matrix.Divide(matrix, num);

            Assert.Null(result);
        }

        [Fact]
        public void Divide_NumIsZero_PrintsErrorMessageAndReturnsNull()
        {
            int[,] matrix = new int[,] { { 1, 2 }, { 3, 4 } };
            int num = 0;

            int[,] result = Matrix.Divide(matrix, num);

            Assert.Null(result);
        }

        [Fact]
        public void Divide_NormalCase_ReturnsDividedMatrix()
        {
            int[,] matrix = new int[,] { { 10, 20 }, { 30, 40 } };
            int num = 5;
            int[,] expected = new int[,] { { 2, 4 }, { 6, 8 } };

            int[,] result = Matrix.Divide(matrix, num);

            Assert.Equal(expected, result);
        }
    }
}
