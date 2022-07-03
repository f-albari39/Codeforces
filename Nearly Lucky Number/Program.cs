using System;

namespace Nearly_Lucky_Number
{
    internal class Program
    {
        private static int luckyNumberCount;
        static void Main(string[] args)
        {
            luckyNumberCount = 0;
            foreach (char s in ReadString()) IsLuckyNumber(s);
            Console.WriteLine(luckyNumberCount == 4 || luckyNumberCount == 7 ? "YES" : "NO");
        }

        private static void IsLuckyNumber(char s)
        {
            if (s == '7' || s == '4') luckyNumberCount++;
        }

        private static string ReadString()
        {
            return Console.ReadLine();
        }
    }
}