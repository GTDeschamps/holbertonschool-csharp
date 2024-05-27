using System;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.length == 2 || vector.length == 3)
        {
            double sumOfSquares = 0;

            for (double component in vector)
            {
                sumOfSquares += Math.pow(component, 2);
            }
            double magnitude = Math.sqrt(sumOfSquares);
            return Math.round(magnitude, 2);
            // Arrondi à la centième près
        }
        else
        {
            return -1;
        }
    }
}
