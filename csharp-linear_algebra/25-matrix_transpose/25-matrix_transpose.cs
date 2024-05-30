using System;

class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix.Length == 0)
        {
            return new double[0, 0];
        }

        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);
        double[,] result = new double[colCount, rowCount];

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                result[j, i] = matrix[i, j];
            }
        }

        return result;
    }
}
