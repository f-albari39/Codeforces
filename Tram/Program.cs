using System;

namespace Tram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = ReadInt();
            int max = 0;
            int people = 0;
            int[] nums;
            while (0 < n--)
            {
                nums = ReadInts();
                people += nums[1] - nums[0];
                max = max < people ? people : max;
            }
            Console.WriteLine(max);
        }

        private static int[] ReadInts()
        {
            return Array.ConvertAll(ReadStrings(), int.Parse);
        }

        private static string[] ReadStrings()
        {
            return Console.ReadLine().Split();
        }

        private static int ReadInt()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
