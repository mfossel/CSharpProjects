using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ChangeCalculator
{
    class Program
    {
        static double GetDoubleFromConsole(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(prompt);
                    string input = Console.ReadLine();
                    double x = double.Parse(input);
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


            double cost = GetDoubleFromConsole("How much does the item cost? ($$.$$)");
            double given = GetDoubleFromConsole("How much has the customer given you? ($$.$$)");
            if (given < cost)
            {
                Console.WriteLine("The customer did not give you enough for the item.");

            }
            double change = Math.Round((given - cost), 2);
            int dollars = (int)change;
            int cents = (int)(((decimal)change % 1) * 100);

            int Quart = cents / 25;
            int Dime = 0;
            int Nickel = 0;
            int Penny = 0;

            int twenties = dollars / 20;
            int tens = 0;
            int fives = 0;
            int ones = 0;

            if (dollars > 0)
            {
                tens = (dollars % 20) / 10;
                fives = ((dollars % 20) % 10) / 5;
                ones = ((dollars % 20) % 10) % 5;
            }

            if (cents > 0)
            {

                Dime = (cents % 25) / 10;
                Nickel = ((cents % 25) % 10) / 5;
                Penny = ((cents % 25) % 10) % 5;
            }

            Console.WriteLine("");
            Console.WriteLine("=========================================");
            Console.WriteLine("The customer's change is $" + change);
            if (twenties > 0)
            {
                if (twenties == 1)
                {
                    Console.WriteLine("Give the customer 1 twenty dollar bill.");
                }
                else
                {
                    Console.WriteLine("Give the customer " + twenties + " twenty dollar bills.");
                }

            }


            if (tens > 0)
            {
                if (tens == 1)
                {
                    Console.WriteLine("Give the customer 1 ten dollar bill.");
                }

                else
                {
                    Console.WriteLine("Give the customer " + tens + " ten dollar bills.");
                }
            }


            if (fives > 0)
            {
                if (fives == 1)
                {
                    Console.WriteLine("Give the customer 1 five dollar bill.");
                }
                else
                {
                    Console.WriteLine("Give the customer " + fives + " five dollar bills.");
                }

            }

            if (ones > 0)
            {
                if (ones == 1)
                {
                    Console.WriteLine("Give the customer 1 one dollar bill.");
                }
                else
                {
                    Console.WriteLine("Give the customer " + ones + " one dollar bills.");
                }

            }


            if (Quart > 0)
            {
                if (Quart == 1)
                {
                    Console.WriteLine("Give the customer 1 quarter.");
                }
                else
                {
                    Console.WriteLine("Give the customer " + Quart + " quarter.");
                }

            }

            if (Dime > 0)
            {
                if (Dime == 1)
                {
                    Console.WriteLine("Give the customer 1 dime.");
                }
                else
                {
                    Console.WriteLine("Give the customer " + Dime + " dimes.");
                }

            }


            if (Nickel > 0)
            {
                if (Nickel == 1)
                {
                    Console.WriteLine("Give the customer 1 nickel.");
                }
                else
                {
                    Console.WriteLine("Give the customer " + Nickel + " nickels.");
                }

            }


            if (Penny > 0)
            {
                if (Penny == 1)
                {
                    Console.WriteLine("Give the customer 1 penny.");
                }
                else
                {
                    Console.WriteLine("Give the customer " + Penny + " pennies.");
                }

            }

            Console.WriteLine("=========================================");
            Console.ReadLine();
        }
    }
}