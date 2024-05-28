using System;
public static class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        // Check if matrices are 2D or 3D
        int matrix1Rows = matrix1.GetLength(0);
        int matrix1Cols = matrix1.GetLength(1);
        int matrix2Rows = matrix2.GetLength(0);
        int matrix2Cols = matrix2.GetLength(1);

        if (matrix1Rows != matrix2Rows || matrix1Cols != matrix2Cols)
        {
            // Return a matrix with -1 if matrices are not the same size
            return new double[,] { { -1 } };
        }

        // Create a new matrix with the same size as the input matrices
        double[,] result = new double[matrix1Rows, matrix1Cols];

        // Add the matrices element-wise
        for (int i = 0; i < matrix1Rows; i++)
        {
            for (int j = 0; j < matrix1Cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }
}
