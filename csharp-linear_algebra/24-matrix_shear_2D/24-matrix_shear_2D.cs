using System;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            // If the matrix is not square, return a matrix containing -1
            return new double[,] { { -1 } };
        }

        int n = matrix.GetLength(0);
        double[,] result = new double[n, n];

        if (direction != 'x' && direction != 'y')
        {
            // If given an axis that is not x or y, return a matrix containing -1
            return new double[,] { { -1 } };
        }

        if (direction == 'x')
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int newI = i + (int)(factor * j);
                    if (newI >= 0 && newI < n)
                    {
                        result[newI, j] = matrix[i, j];
                    }
                }
            }
        }
        else // direction == 'y'
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int newJ = j + (int)(factor * i);
                    if (newJ >= 0 && newJ < n)
                    {
                        result[i, newJ] = matrix[i, j];
                    }
                }
            }
        }

        return result;
    }
}
