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

        static void Main(string[] args)
        {
            int range = GetIntegerFromConsole("Please enter how many Fibonacci numbers you want to see(up to 46):");

            Console.WriteLine("=======================");
            Console.WriteLine("1");

            int a = 0;
            int b = 1;

            for (int i = 1; i < range; i++)
            {
                int c = a + b;
                a = b;            
                b = c;
                Console.WriteLine(c);
            }

            Console.WriteLine("=======================");
            Console.ReadLine();

        }
    }
}
