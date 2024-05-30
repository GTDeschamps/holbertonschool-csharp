using System;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return new double[,] {{-1}};
        }

        int size = matrix.GetLength(0);
        double[,] result = new double[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                result[i, j] = matrix[i, j];
            }
        }

        if (direction != 'x' && direction != 'X' && direction != 'y' && direction != 'Y')
        {
            return new double[,] {{-1}};
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (direction == 'x' || direction == 'X')
                {
                    if (j + 1 < size)
                    {
                        result[i, j + 1] += factor * result[i, j];
                    }
                }
                else // direction == 'y' || direction == 'Y'
                {
                    if (i + 1 < size)
                    {
                        result[i + 1, j] += factor * result[i, j];
                    }
                }
            }
        }

        return result;
    }
}
