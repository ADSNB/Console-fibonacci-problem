using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            while (a <= n)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main()
        {
            List<int> queue = new List<int>();

            Console.WriteLine("How many fibous do you wanna know the next value?");
            string input = Console.ReadLine();

            var TimesToCalculate = Convert.ToInt32(input);

            while (TimesToCalculate != 0)
            {
                var temp = Console.ReadLine();
                queue.Add(Convert.ToInt32(temp));
                TimesToCalculate--;
            }

            Console.WriteLine("\r\n");

            foreach (var n in queue)
            {
                Console.WriteLine($"The next fibo number for {n} is:");
                Console.WriteLine(Fibonacci(Convert.ToInt32(n)));
                Console.WriteLine("\r\n");
            }
        }
    }
}
