using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class prog1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Test Data:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine($"{x} is a positive number");
            }
            else
            {
                Console.WriteLine($"{x} is a negative number");
            }
            Console.Read();
        }
    }
}
