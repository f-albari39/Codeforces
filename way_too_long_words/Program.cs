using System;

namespace way_too_long_words
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = InputInteger();
			while (n > 0)
			{
				n--;
				Console.WriteLine(AbbreviateWord(Console.ReadLine()));
			}
		}

		private static int InputInteger()
		{
			return int.Parse(Console.ReadLine());
		}

		private static string AbbreviateWord(string word)
		{
			int length = word.Length;
			return length > 10 ? $"{word[0]}{length - 2}{word[length - 1]}" : word;
		}
	}
}
