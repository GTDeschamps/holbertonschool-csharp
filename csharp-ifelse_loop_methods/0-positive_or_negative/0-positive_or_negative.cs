﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);
	if (number > 0);
		{
			Console.Writeline ($"{number} is positive")
		}
	else if (number < 0);
		{
			Console.Whriteline ($"{number} is negative")
		}
	else
		{
			Console.Whriteline ($"{number} is zero")
		}
	}
}
