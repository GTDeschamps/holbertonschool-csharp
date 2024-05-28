using System;

class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        // Check if matrices can be multiplied
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            // Create a 1x1 matrix of -1 if matrices cannot be multiplied
            return new double[,] { { -1 } };
        }

        // Get dimensions of matrices
        int matrix1RowCount = matrix1.GetLength(0);
        int matrix1ColCount = matrix1.GetLength(1);
        int matrix2ColCount = matrix2.GetLength(1);

        // Initialize resulting matrix
        double[,] result = new double[matrix1RowCount, matrix2ColCount];

        // Perform matrix multiplication
        for (int i = 0; i < matrix1RowCount; i++)
        {
            for (int j = 0; j < matrix2ColCount; j++)
            {
                for (int k = 0; k < matrix1ColCount; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }
}
