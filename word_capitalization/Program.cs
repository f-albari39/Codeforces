using System;
using System.Text;

namespace word_capitalization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ReadString());
            sb[0] = char.ToUpper(sb[0]);
            Console.WriteLine(sb.ToString());
        }

        private static string ReadString()
        {
            return Console.ReadLine();
        }
    }
}
