using System;

namespace Bear_and_Big_Brother
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(ReadInt()));
        }

        private static double Calculate(int[] ints)
        {
            double a = (double)2 / 3;
            double b = (double)ints[0] / ints[1];
            double n = Math.Floor(Math.Log(b, a)) + 1;
            double x = Math.Pow(a, n);
            return  x == b ? n+=1 : n;
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
