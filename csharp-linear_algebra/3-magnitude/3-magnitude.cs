using System;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.length == 2 || vector.length == 3)
        {
            double sumOfSquares = 0;

            for (double component : vector)
            {
                sumOfSquares += Math.pow(component, 2);
            }
            double magnitude = Math.sqrt(sumOfSquares);
            return Math.round(magnitude * 100.0) / 100.0;
            // Arrondi à la centième près
        }
        else
        {
            return -1;
        }
    }
}
