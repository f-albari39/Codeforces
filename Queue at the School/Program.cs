using System;
using System.Text;

namespace Queue_at_the_School
{
    internal class Program
    {
        private static StringBuilder result;
        private static bool isChanged;
        static void Main(string[] args)
        {
            int[] nums = ReadInts();
            result = new StringBuilder().Append(ReadString());

            SwapQueue(nums[1]);

            Console.WriteLine(result.ToString());
        }

        private static void SwapQueue(int t)
        {
            while (0 < t--)
            {
                isChanged = false;
                for (int i = 0; i < result.Length - 1; i++)
                {
                    if(Swap(i)) i++;
                }
                if (!isChanged) break;
            }
        }

        private static bool Swap(int i)
        {
            if (Swapable(i))
            {
                DoSwap(i);
                isChanged = true;
                return true;
            }
            return false;
        }

        private static void DoSwap(int i)
        {
            result[i] = 'G';
            result[i + 1] = 'B';
        }

        private static bool Swapable(int i)
        {
            return result[i] == 'B' && result[i + 1] == 'G';
        }

        private static int[] ReadInts()
        {
            return Array.ConvertAll(ReadString().Split(), int.Parse);
        }

        private static string ReadString()
        {
            return Console.ReadLine();
        }
    }
}
