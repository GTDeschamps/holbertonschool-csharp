using System;

class Program
{
	static void Main(string[] args)
	{
		for (int number = 0; number < 99; number++)
		{
			Console.Write($"{number} = 0X{number.ToString("X2")}");
		}
	}
}
