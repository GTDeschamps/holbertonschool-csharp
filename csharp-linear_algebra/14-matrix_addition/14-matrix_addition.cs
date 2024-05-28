﻿using System;
public class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (IsValidMatrix(matrix1) && IsValidMatrix(matrix2) && AreMatricesSameSize(matrix1, matrix2))
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }
        else
        {
            return new double[,] { { -1 } };
        }
    }

    private static bool IsValidMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        return rows == 2 || rows == 3 && rows == cols;
    }

    private static bool AreMatricesSameSize(double[,] matrix1, double[,] matrix2)
    {
        return matrix1.GetLength(0) == matrix2.GetLength(0) && matrix1.GetLength(1) == matrix2.GetLength(1);
    }
}