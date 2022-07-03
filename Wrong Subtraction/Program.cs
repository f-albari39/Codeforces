using System;
using System.Text;

namespace Wrong_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = ReadStrings();
            StringBuilder s = new StringBuilder().Append(input[0]);
            int b = StringToInt(input[1]);
            Console.WriteLine(CountSubstraction(s, b));
        }

        private static int StringToInt(string v)
        {
            return int.Parse(v);
        }

        private static string CountSubstraction(StringBuilder s, int b)
        {
            while (0 < b--)
            {
                int n = s.Length - 1;
                char c = s[n];
                if (c == '0') s.Remove(n, 1);
                else s[n] = (char)(c - 1);
            }
            return s.ToString();
        }

        private static string[] ReadStrings()
        {
            return Console.ReadLine().Split();
        }
    }
}
