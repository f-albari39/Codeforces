using System;

namespace bit__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = ReadInt();
            int result = 0;
            while (n > 0)
            {
                if (ReadString().Contains("++")) result++;
                else result--;
                n--;
            }
            Console.WriteLine(result);
        }

        private static string ReadString()
        {
            return Console.ReadLine();
        }

        private static int ReadInt()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
