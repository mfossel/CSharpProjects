using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Sequence
{
    class Program
    {
        static int GetIntegerFromConsole(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(prompt);
                    string input = Console.ReadLine();
                    int x = int.Parse(input);
                    return x;
                }
                catch (Exception e)
                {
                    Console.WriteLine("That is not a number.");
                }
            }
        }

        static int FindFib (int n)
        {
            if (n== 0)
            {
                return 0;
            }

            else
            {
                int a = 0;
                int b = 1;
                for (int i = 2; i < n; i++)
                {
                    int c = a + b;
                    a = b;
                    b = c;
                }

                return a + b;
            }

        }

        static void Main(string[] args)
        {
            int userNum = GetIntegerFromConsole("Please enter which Fibonaci number you want to see(up to 46):");
            int fib = FindFib(userNum);

         

            Console.WriteLine("==============================");
            Console.WriteLine("Fibonacci number " + userNum + " is " + fib);
            Console.WriteLine("==============================");
            Console.ReadLine();


        }
    }
}
