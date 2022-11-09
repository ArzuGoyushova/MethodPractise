using System;
using System.Threading;

namespace MethodPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method 1");Console.
            WriteLine("Please add your name:");
            string name = Console.ReadLine();
            Welcome(name);

            Console.WriteLine("Method 2");
            Console.WriteLine("Please add your age:");
            int age = int.Parse(Console.ReadLine());
            Age(age);

            Console.WriteLine("Method 3");
            Console.WriteLine("Please add your bias's name:");
            string bias = Console.ReadLine();
            BTSbias(bias);

            Console.WriteLine("Method 4");
            Console.WriteLine("Please add yours and your bias's ages:");
            Console.Write("Bias age: ");
            int biasAge = int.Parse(Console.ReadLine());
            Console.Write("Your age: ");
            int yourAge = int.Parse(Console.ReadLine());
            Console.WriteLine(CompOfYourAges(yourAge,biasAge));

            Console.WriteLine("Method 5");
            Console.WriteLine("Please add members' names:");
            Console.WriteLine(WholeGroup("Namjoon", "Seokjin", "Yoongi", "Hoseok", "Jimin", "Taehyung", "Jungkook"));
            Console.WriteLine("You counted correctly.");
        }

            static void Welcome(string name)
            {
                Console.WriteLine($"Welcome dear {name}.");
            }

            static void Age(int age)
            {
                Console.WriteLine($"I guess you were born in {2022 - age} or {2021 - age}.");
            }

            static void BTSbias(string bias)
            {
                Console.WriteLine($"So your bias is the one and only {bias}. Good taste.");
            }

            static string CompOfYourAges(int yourAge, int biasAge)
            {
            if (yourAge > biasAge)
            {
                return "Oh you are older than him.";
            }
            else if (yourAge < biasAge)
            {
                return "Ok, looks like your bias is older than you.";
            }
            else
            {
                return "OMG you are the same age.";
            }
            }

        static int WholeGroup(params string [] array)
        {
           return array.Length;
        }
        

        
    }
}
