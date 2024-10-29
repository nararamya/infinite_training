using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class prog3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            while (i < 10)
            {

                i++;
                Console.WriteLine($"{num} * {i}={num * i}");
            }
            Console.Read();
        }
    }
}
