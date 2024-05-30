using System;

class MatrixMath
{
    public static double Determinant(double[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);

        if (rowCount!= colCount || (rowCount!= 2 && rowCount!= 3))
        {
            return -1;
        }

        if (rowCount == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        else // rowCount == 3
        {
            double a = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]);
            double b = matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]);
            double c = matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

            return a - b + c;
        }
    }
}
