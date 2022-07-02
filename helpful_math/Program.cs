using System;
using System.Text;

namespace helpful_math
{
    internal class Program
    {
        static int[] nums;
        static StringBuilder result;
        static int index;

        static void Main(string[] args)
        {
            string input = ReadString();
            result = new StringBuilder().Append(input);
            nums = new int[3];

            CountEachNumber(input);
            ReplaceNumbers();

            Console.WriteLine(result.ToString());
        }

        private static void ReplaceNumbers()
        {
            index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int n = nums[i];
                while (0 < n--) ReplaceNumber(i);
            }
        }

        private static void ReplaceNumber(int i)
        {
            result[index] = (char)('1' + i);
            index += 2;
        }

        private static void CountEachNumber(string input)
        {
            for (int i = 0; i < input.Length; i += 2) nums[input[i] - '1']++;
        }

        private static string ReadString()
        {
            return Console.ReadLine();
        }
    }
}
