using System;
using System.Threading;

namespace MethodPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Method 1");Console.
            //WriteLine("Please add your name:");
            //string name = Console.ReadLine();
            //Welcome(name);

            //Console.WriteLine("Method 2");
            //Console.WriteLine("Please add your age:");
            //int age = int.Parse(Console.ReadLine());
            //Age(age);

            //Console.WriteLine("Method 3");
            //Console.WriteLine("Please add your bias's name:");
            //string bias = Console.ReadLine();
            //BTSbias(bias);

            //Console.WriteLine("Method 4");
            //Console.WriteLine("Please add yours and your bias's ages:");
            //Console.Write("Bias age: ");
            //int biasAge = int.Parse(Console.ReadLine());
            //Console.Write("Your age: ");
            //int yourAge = int.Parse(Console.ReadLine());
            //Console.WriteLine(CompOfYourAges(yourAge,biasAge));

            //Console.WriteLine("Method 5");
            //Console.WriteLine("Please add members' names:");
            //Console.WriteLine(WholeGroup("Namjoon", "Seokjin", "Yoongi", "Hoseok", "Jimin", "Taehyung", "Jungkook"));
            //Console.WriteLine("You counted correctly.");

            Console.WriteLine("Method 6");
            Console.WriteLine("Power of the entered number:");
            Console.WriteLine(PowerOfNumber(2,4));

            Console.WriteLine("Method 7");
            Console.WriteLine("Enter n number to describe Fibonacci sequence:");
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write(Fibonacci(i)+ " ");
            }

            Console.WriteLine("Method 8");
            Console.WriteLine(SumOfDigits(123));

            Console.WriteLine("Method 9");
            Console.WriteLine(Fact(4));

            Console.WriteLine("Method 10");
            Console.WriteLine(FiboNum(10));
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
        
        static int PowerOfNumber (int num, int exp)
        {
            int result = 1;
            for (int i = 1; i <= exp; i++)
            {
                result *= num;
            }
            return result;
        }

        static int Fibonacci (int n)
        {
            int num1 = 0, num2 = 1;
            int temp;
            
            for (int i = 0; i < n; i++)
            {
                temp = num1;
                num1 = num2;
                num2 = temp + num2;
            }
            return num1;
        }

        static int SumOfDigits(int n)
        {
            int sum = 0;
            int r = 0;
            while (n != 0)
            {
                r = n % 10;
                sum += r;
                n /= 10;
            }
            return sum;
        }

        static int Fact (int n)
        {
            int fact=1;
            for (int i = n; i >1; i--)
            {
               fact *= i;
            }
            return fact;
        }
        
        static int FiboNum(int n)
        {
            int num1=0, num2=1;
            int num3=0;

            for (int i = 3; i<=n; i++)
            {
                num3 = num1+num2;
                num1 = num2;
                num2 = num3;
            }
            return num3;
        }

    }
}
