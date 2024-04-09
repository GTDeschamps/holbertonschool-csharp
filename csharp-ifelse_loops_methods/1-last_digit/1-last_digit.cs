﻿using System;

class Program
{
	static void Main(string[] args)
	{
	Random rndm = new Random();
	int number = rndm.Next(-10000, 10000);

	Console.Write($"The last digit of {number} is");
	if (lastDigit > 5)
		Console.WriteLine($"{lastDigit} and is greater than 5");
	else if (lastDigit == 0)
		Console.WriteLine($"{lastDigit} and is 0");
	else
		Console.WriteLine($"{lastDigit} and is less than 6 and not 0");
	}
}
