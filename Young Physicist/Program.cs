using System;

namespace Young_Physicist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = ReadInt();
            int[] array = new int[3];
            while (0 < n--)
            {
                int[] vectors = ReadInts();
                for (int i = 0; i < 3; i++) array[i] += vectors[i];
            }

            Console.WriteLine(IsArrayEquilibrium(array) ? "YES" : "NO");
        }

        private static bool IsArrayEquilibrium(int[] array)
        {
            foreach (int item in array) if (item != 0) return false;
            return true;
        }

        private static int ReadInt()
        {
            return int.Parse(ReadString());
        }

        private static string ReadString()
        {
            return Console.ReadLine();
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
