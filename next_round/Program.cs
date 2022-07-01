using System;

namespace next_round
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] requirement = ReadInt();
            Console.WriteLine(GetNumberOfAdvancedParticipant(ReadInt(), requirement[1] - 1, requirement[0] - 1));
        }

        private static int GetNumberOfAdvancedParticipant(int[] input, int k, int n)
        {
            int value = input[k];
            int increment = GetIncrement(value);
            for (; k >= 0 && k <= n; k += increment)
            {
                var x = input[k];
                if (increment == -1 && x > 0) return k + 1;
                if (increment == 1 && x != value) return k;
            }
            return k < 0 ? 0 : n+1;
        }

        private static int GetIncrement(int value)
        {
            return value <= 0 ? -1 : 1;
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
