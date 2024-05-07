namespace MyMath
{
    public static class Matrix
    {
        public static int[,] Divide(int[,] matrix, int num)
        {
            // Check if num is 0
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

            // Check if matrix is null
            if (matrix == null)
            {
                return null;
            }

            // Get the dimensions of the matrix
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Create a new matrix with the same dimensions
            int[,] result = new int[rows, cols];

            // Divide each element of the matrix by num
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j] / num;
                }
            }

            // Return the new matrix
            return result;
        }
    }
}
