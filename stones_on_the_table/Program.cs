using System;

namespace stones_on_the_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadString();
            Console.WriteLine(CountMinimumTakes(ReadString()));
        }

        private static int CountMinimumTakes(string input)
        {
            int result = 0;
            for (int i = 0, j = 0; i < input.Length; i++)
            {
                if (i == j) continue;
                if (input[i] == input[j]) result++;
                else j = i;
            }
            return result;
        }

        private static string ReadString()
        {
            return Console.ReadLine();
        }
    }
}
