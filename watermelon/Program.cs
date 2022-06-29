using System;

namespace watermelon
{
	public class Program
	{
		static void Main()
		{
			int number = IntInput();
			Console.WriteLine(number % 2 == 1 || number <= 2 ? "NO" : "YES");
		}

		private static int IntInput()
		{
			return int.Parse(Console.ReadLine());
		}
	}
}
