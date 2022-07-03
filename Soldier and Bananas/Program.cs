using System;

namespace Soldier_and_Bananas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = ReadInts();
            int total;
            int k = nums[0];
            int n = nums[1];
            int w = nums[2];

            int x = k * (w + 1);
            total = x * w / 2;
            Console.WriteLine(total > n ? total - n : 0);
        }

        private static int[] ReadInts()
        {
            string[] input = ReadStrings();
            return ArrayStringToArrayInteger(input);
        }

        private static int[] ArrayStringToArrayInteger(string[] input)
        {
            return Array.ConvertAll(input, int.Parse);
        }

        private static string[] ReadStrings()
        {
            return Console.ReadLine().Split();
        }
    }
}
