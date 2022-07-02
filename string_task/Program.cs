using System;
using System.Text;

namespace string_task
{
    internal class Program
    {
        static char[] _vowels;
        static StringBuilder s;
        static void Main(string[] args)
        {
            _vowels = new char[] { 'a', 'e', 'i', 'u', 'o', 'y' };
            s = new StringBuilder();
            StringTask();
        }

        private static void StringTask()
        {
            string input = ReadString().ToLower();
            foreach (char ch in input) if (!IsVowel(ch)) s.Append("." + ch);
            Console.WriteLine(s.ToString());
        }

        private static bool IsVowel(char ch)
        {
            foreach (char vowel in _vowels)
            {
                if (vowel.Equals(ch)) return true;
            }
            return false;
        }

        private static string ReadString()
        {
            return Console.ReadLine();
        }
    }
}
