using System;

namespace beautiful_matrix
{
    internal class Program
    {
        static bool location;
        static int i, x, y;
        static void Main(string[] args)
        {
            location = false;
            i = x = y = 0;

            while (i < 5)
            {
                int[] input = ReadInt();
                if (!location) FindOne(input);
                i++;
            }

            Console.WriteLine(CalculateMoves(x, y, 2));
        }

        private static void FindOne(int[] input)
        {
            for (int j = 0; j < input.Length; j++)
            {
                if (input[j] == 1)
                {
                    location = true;
                    x = j;
                    y = i;
                    break;
                }
            }
        }

        private static int CalculateMoves(int x, int y, int v)
        {
            return CalculateDifference(x, v) + CalculateDifference(y, v);
        }

        private static int CalculateDifference(int x, int v)
        {
            return Math.Abs(x - v);
        }

        private static int[] ReadInt()
        {
            return ArrayStringToArrayInteger(ReadString());
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
