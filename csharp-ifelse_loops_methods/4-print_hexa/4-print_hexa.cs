using System;

class Program
{
	static void Main(string[] args)
	{
		for (int number = 0; number < 99; number++)
		{
			Console.WriteLine("{0} = 0x{0:x}", number);
		}
	}
}
