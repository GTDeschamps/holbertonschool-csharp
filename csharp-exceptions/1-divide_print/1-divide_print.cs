using System;

class Int
{
    public static void divide(int a, int b)
    {
        int quotien= 0;
        try
        {
            quotien = a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
            quotien = 0;
        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {quotien}");
        }
    }
}

