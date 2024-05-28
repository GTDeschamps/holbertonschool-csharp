using System;

    class VectorMath
    {
        public static double DotProduct(double[] vector1, double[] vector2)
  {
        if ((vector1.Length != 2 || vector2.Length != 2) && (vector1.Length != 3 || vector2.Length != 3))
        {
            return -1; // Return -1 if vectors are not both 2D or both 3D
        }

        if (vector1.Length != vector2.Length)
        {
            return -1; // Return -1 if vectors are not the same size
        }

        double dotProduct = 0;
        for (int i = 0; i < vector1.Length; i++)
        {
            dotProduct += vector1[i] * vector2[i];
        }

        return dotProduct;
    }
}
