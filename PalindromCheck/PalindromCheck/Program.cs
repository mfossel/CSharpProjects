using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PalindromCheck
{
    class Program
    {

        static void Main(string[] args)
        {
            WriteLine("==================================");
            WriteLine("        Palindron Checker         ");
            WriteLine("==================================");
            WriteLine("Enter the string you wish to check");
            string str = ReadLine();
            Checker(str);
            Read();

        }



        static void Checker(string str)
        {
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {

                if (str[i] != str[j])
                {
                    WriteLine("This is not a Palindrome.");
                    return;
                }       

            }

            WriteLine("It's a Palindrome!!!");

        }

    }
}
