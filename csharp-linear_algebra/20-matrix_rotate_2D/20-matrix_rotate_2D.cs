using System;

 class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
        {
            // Return a matrix containing -1 if the matrix is not square
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows, cols];
        double centerX = rows / 2.0;
        double centerY = cols / 2.0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                double x = i - centerX;
                double y = j - centerY;

                // Apply rotation transformation
                double newX = x * Math.Cos(angle) - y * Math.Sin(angle);
                double newY = x * Math.Sin(angle) + y * Math.Cos(angle);

                // Translate back to original coordinates and round to the nearest integer
                int newXCoord = (int)Math.Round(newX + centerX);
                int newYCoord = (int)Math.Round(newY + centerY);

                // Check if the new coordinates are within bounds
                if (newXCoord >= 0 && newXCoord < rows && newYCoord >= 0 && newYCoord < cols)
                {
                    result[newXCoord, newYCoord] = matrix[i, j];
                }
            }
        }

        return result;
    }
}
