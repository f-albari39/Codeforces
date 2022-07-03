using System;

namespace Football
{
    internal class Program
    {
        private static int index;
        private static int count;
        static void Main(string[] args)
        {
            index = 0;
            count = 1;
            Console.WriteLine(Count(ReadString()));
        }

        private static string Count(string input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                CountValidation(input, i);
                if (count == 7) return "YES";
            }
            return "NO";
        }

        private static void CountValidation(string input, int i)
        {
            if (input[i] == input[index]) count++;
            else
            {
                index = i;
                count = 1;
            }
        }

        private static string ReadString()
        {
            return Console.ReadLine();
        }
    }
}
