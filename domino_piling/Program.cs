using System;

namespace domino_piling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = ReadInt();
            int result = input[0] * input[1];
            Console.WriteLine(result % 2 == 1 ? ( result - 1 ) / 2 : result / 2);
        }

        private static int[] ReadInt()
        {
            string[] input = ReadString();
            return ArrayStringToArrayInteger(input);
        }

        private static int[] ArrayStringToArrayInteger(string[] input)
        {
            return Array.ConvertAll(input, int.Parse);
        }

        private static string[] ReadString()
        {
            return Console.ReadLine().Split();
        }
    }
}
