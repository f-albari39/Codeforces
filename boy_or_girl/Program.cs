using System;

namespace boy_or_girl
{
    internal class Program
    {
        private static int[] characters;
        static void Main(string[] args)
        {
            characters = new int[26];
            int distinctCharacters = CountDistinctCharacter(ReadString());
            Console.WriteLine(distinctCharacters % 2 == 0 ? "CHAT WITH HER!" : "IGNORE HIM!");
        }

        private static int CountDistinctCharacter(string v)
        {
            foreach (char c in v) characters[c - 97] += 1;
            int result = 0;
            foreach (int i in characters) result += i > 0 ? 1 : 0;
            return result;
        }

        private static string ReadString()
        {
            return Console.ReadLine();
        }
    }
}

