using System;

namespace Elephant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountSteps(ReadInt()));
        }

        private static int CountSteps(int input)
        {
            int div = input / 5;
            if (input % 5 != 0) div++;
            return div;
        }

        private static int ReadInt()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
