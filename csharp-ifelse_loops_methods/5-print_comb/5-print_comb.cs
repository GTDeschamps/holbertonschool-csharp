using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 00; number < 100; number++)
            {
                if (number < 99)
                {
                    Console.Write ("{0:00}, ", number);
                }
                else
                {
                    Console.WriteLine ("{0}",number);
                }
            }
        }
    }
}
