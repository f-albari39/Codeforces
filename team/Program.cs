using System;

namespace team
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int result = 0;
			int n = InputInteger();
			while (n > 0)
			{
				n--;
				string[] input = InputToArrayOfString();
				int sum = SumFromArrayOfString(input);
				result += sum >= 2 ? 1 : 0;
			}
			Console.WriteLine(result);
		}

		private static string[] InputToArrayOfString()
		{
			return Console.ReadLine().Split();
		}

		private static int SumFromArrayOfString(string[] input)
		{
			return int.Parse(input[0]) + int.Parse(input[1]) + int.Parse(input[2]);
		}

		private static int InputInteger()
		{
			return int.Parse(Console.ReadLine());
		}
	}
}
