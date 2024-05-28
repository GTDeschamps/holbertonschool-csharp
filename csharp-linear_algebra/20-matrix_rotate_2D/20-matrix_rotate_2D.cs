using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Check if matrix is square
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            // Invalid matrix size
            return new double[,] { { -1 } };
        }

        // Create a new matrix to hold the rotated values
        double[,] rotatedMatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];

        // Calculate rotation matrix
        double cosAngle = Math.Cos(angle);
        double sinAngle = Math.Sin(angle);
        double[,] rotationMatrix = new double[,] { { cosAngle, -sinAngle }, { sinAngle, cosAngle } };

        // Perform matrix multiplication
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                double value = 0;
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    value += matrix[i, k] * rotationMatrix[k, j];
                }
                rotatedMatrix[i, j] = value;
            }
        }

        return rotatedMatrix;
    }
}
