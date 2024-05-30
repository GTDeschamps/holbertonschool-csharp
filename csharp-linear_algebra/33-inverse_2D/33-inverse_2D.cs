class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);

        if (rowCount!= 2 || colCount!= 2)
        {
            return new double[,] { { -1 } };
        }

        double det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        if (det == 0)
        {
            return new double[,] { { -1 } };
        }

        double invDet = 1 / det;

        double[,] inverse = new double[2, 2];

        inverse[0, 0] = matrix[1, 1] * invDet;
        inverse[0, 1] = -matrix[0, 1] * invDet;
        inverse[1, 0] = -matrix[1, 0] * invDet;
        inverse[1, 1] = matrix[0, 0] * invDet;

        return inverse;
    }
}
