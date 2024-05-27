using System;

namespace _6_vector_addition
{
    class VectorMath
    {
        public static double[] Add(double[] vector1, double[] vector2)
        {
            if ((vector1.length != 2 && vector1.length != 3) || (vector2.length != 2 && vector2.length != 3))
            {
                return new double[]{-1};
            }

            if (vector1.length != vector2.length)
            {
                return new double[]{-1};
            }

            double[] result = new double[vector1.length];
            for (int i = 0; i < vector1.length; i++)
            {
                result[i] = vector1[i] + vector2[i];
            }

            return result;
        }
    }
}
