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
            int userNum = GetIntegerFromConsole("Please enter which Fibonaci number you want to see(up to 46):");            
            var n = 1;
            var nn = 0;
            var nnn = 1;
            var count = 1;
            while (count < userNum)
            {                
                n = nn + nnn;
                nn = nnn;
                nnn = n;
                count = count + 1;
                ;
            }

            Console.WriteLine("==============================");
            Console.WriteLine("Fibonacci number " + userNum + " is " + n);
            Console.WriteLine("==============================");
            Console.ReadLine();


        }
    }
}
