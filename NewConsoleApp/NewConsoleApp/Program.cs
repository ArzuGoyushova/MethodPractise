using System;

namespace NewConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("brooklyn"));
        }

        static string ReverseString (string rev)
        {
            string rev2="";
            
            for (int i = rev.Length-1; i >=0; i--)
            {
                rev2 += rev[i];
            }
            return rev2;
        }
    }
}
