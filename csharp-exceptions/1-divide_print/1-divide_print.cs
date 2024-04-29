using System;

class Int
{
    public static void divide(int a, int b)
    {
        try
        {
            int result = 0;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
            result = 0;
        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {result}");
        }
    }
}

