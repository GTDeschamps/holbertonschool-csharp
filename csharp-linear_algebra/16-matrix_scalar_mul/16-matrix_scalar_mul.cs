using System;

class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        // Check if matrix is 2D or 3D
        int matrixRows = matrix.GetLength(0);
        int matrixCols = matrix.GetLength(1);

        if (matrixRows == 2 || matrixCols == 2 || matrixRows == 3 || matrixCols == 3)
        {
            // Create a new matrix with the same size as the input matrix
            double[,] result = new double[matrixRows, matrixCols];

            // Multiply the matrix and scalar element-wise
            for (int i = 0; i < matrixRows; i++)
            {
                for (int j = 0; j < matrixCols; j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }

            return result;
        }
        else
        {
            // Return a matrix with -1 if matrix is not 2D or 3D
            return new double[,] { { -1 } };
        }
    }
}
