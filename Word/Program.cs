using System;

namespace Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int upper = 0;
            foreach (char c in input) upper += (CharIsUpperCase(c)) ? 1 : -1;
            Console.WriteLine(upper > 0 ? input.ToUpper() : input.ToLower());
        }

        private static bool CharIsUpperCase(char c)
        {
            return c >= 'A' && c <= 'Z';
        }
    }
}
