using System;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.length == 2 || vector.length == 3)
        {
            double sumOfSquares = 0;
            foreach (double component in vector)
            {
                sumOfSquares += component * component;
            }
            double magnitude = Math.sqrt(sumOfSquares);
            return Math.round(magnitude, 2);
        }
        else
        {
            return -1;
        }
    }
}
