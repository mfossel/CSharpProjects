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
            var count = 0;
            var n = 1;
            var nn = 0;
            var nnn = 1;
            Console.WriteLine("=======================");
            while (count<range)
            {
                Console.WriteLine(n);
                n = nn + nnn;
                nn = nnn;
                nnn = n;              
                count = count + 1;
                System.Threading.Thread.Sleep(125);
                ;
            }
            Console.WriteLine("=======================");
            Console.ReadLine();

        }
    }
}
