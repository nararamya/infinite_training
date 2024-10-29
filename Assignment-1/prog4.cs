using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class prog4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number:");
            int one = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second number:");
            int two = Convert.ToInt32(Console.ReadLine());
            if (one == two)
            {
                Console.WriteLine($"{one * two * 3}");
            }
            else
            {
                Console.WriteLine($"{one + two}");
            }

            Console.Read();
        }
    }
}
