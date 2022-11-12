using System;
using System.Text;

namespace NewConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("brooklyn"));
        }

        static StringBuilder ReverseString (string rev)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = rev.Length-1; i >=0; i--)
            {
                stringBuilder.Append(rev[i]);
            }
            return stringBuilder;
        }

    }
}
