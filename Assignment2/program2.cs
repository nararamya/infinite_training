using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class program2
    {
        static void Main(string[] args)
        {
            int digit;
            Console.WriteLine("Enter a digit:");
            digit = int.Parse(Console.ReadLine());

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0} {1} {2} {3}", digit, digit, digit, digit);
                Console.WriteLine("{0}{1}{2}{3}", digit, digit, digit, digit);
            }
            Console.Read();
           


        }

    }
}
