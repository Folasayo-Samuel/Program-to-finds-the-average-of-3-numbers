using System;

namespace AverageNumbers
{
	class Program
	{
		static void Main(string[]args)
		{
			int number1, number2, number3, average;

			Console.Write("Enter first number: ");
			number1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter second number: ");
			number2 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter third number: ");
			number3 = Convert.ToInt32(Console.ReadLine());

			average = (number1 + number2 + number3) / 3;

			Console.WriteLine($"Average of three numbers is {average}");

            Console.ReadKey();
        }
	}
}