using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = GetIntegerFromConsole("How many primes would you like to see?");
            Console.WriteLine("=========================================");
            Console.WriteLine("               Sieving                   ");
            Console.WriteLine("=========================================");
            Sieve(n);
            
        }


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

        static void Sieve(int n)
        {
            List<int> numbers = new List<int>();
            

            for (int i = 1; i <= n; i++)
            {
               
                numbers.Add(i);
                
            }

            List<int> primes = new List<int>() { 2, 3 };

            int primers = 5;

            while (primes.Count < n)
            {
                int primerRoot = (int)Math.Sqrt(primers);

                for (int i = 1; i < primes.Count; i++)
                {
                    if (primers % primes[i] == 0)
                    {
                        break;
                    }

                    if (primes[i] > primerRoot)
                    {
                        primes.Add(primers);
                        break;
                    }
                }
                primers += primes[0];
            }


                foreach (var prime in primes)
                {
                    Console.WriteLine(prime);
                    System.Threading.Thread.Sleep(125);
                }
                Console.WriteLine("=========================================");
                Console.WriteLine("                Sieved                    ");
                Console.WriteLine("=========================================");
            Console.ReadLine();
        }


    }
}
