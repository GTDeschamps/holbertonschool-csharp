using System;

class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        // Check if the matrix is a 2D square matrix
        if (n != m)
        {
            return new double[,] { { -1 } };
        }

        // Calculate the determinant
        double det = Determinant(matrix);

        // If the determinant is 0, the matrix is non-invertible
        if (det == 0)
        {
            return new double[,] { { -1 } };
        }

        // Find the inverse of the matrix
        double[,] adjugate = Adjugate(matrix);
        double[,] inverse = new double[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                inverse[i, j] = adjugate[i, j] / det;
            }
        }

        return inverse;
    }
}
