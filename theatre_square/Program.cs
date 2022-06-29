using System;

namespace theatre_square
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] input = InputToArrayOfString();
			int side1 = int.Parse(input[0]);
			int side2 = int.Parse(input[1]);
			int square = int.Parse(input[2]);
			long squares = CalculateSquares(side1, side2, square);
			Console.WriteLine(squares);
		}

		private static long CalculateSquares(int side1, int side2, int square)
		{
			int side1Squares = CalculatePave(side1, square);
			int side2Squares = CalculatePave(side2, square);
			return (long)side1Squares * side2Squares;
		}

		private static int CalculatePave(int side, int square)
		{
			return (side / square) + (side % square != 0 ? 1 : 0);
		}

		private static string[] InputToArrayOfString()
		{
			return Console.ReadLine().Split();
		}
	}
}
