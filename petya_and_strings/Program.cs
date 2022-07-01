using System;

namespace petya_and_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordA = ReadString().ToLower();
            string wordB = ReadString().ToLower();

            Console.WriteLine(IsLexicographically(wordA, wordB));
        }

        private static int IsLexicographically(string wordA, string wordB)
        {
            if (wordA.Equals(wordB)) return 0;

            string[] words = { wordA, wordB };
            Array.Sort(words);

            return words[0].Equals(wordA) ? -1 : 1;
        }

        private static string ReadString()
        {
            return Console.ReadLine();
        }
    }
}
