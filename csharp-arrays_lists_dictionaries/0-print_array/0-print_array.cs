using System;
class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size == 0)
        {
            Console.WriteLine();
            return new int[0];
        }
        if (size < 0)
        {
            Console.WriteLine ("Size cannot be negative");
            return null;
        }
        int[] result = new int[size];
        for (int i = 0; i < size; i++)
        {
            result[i] = i;
            Console.Write (result[i] +" ");
        }
        Console.WriteLine();
        return result;
    }
}

