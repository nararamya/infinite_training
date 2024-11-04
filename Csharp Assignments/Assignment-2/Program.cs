using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.WriteLine(" Enter 1st number:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number:");
            num2 = int.Parse(Console.ReadLine());
          

            temp = num1;
            num1= num2;
            num2 = temp;
            Console.WriteLine("1st number is {0}", num1);
            Console.WriteLine("2nd number is {0}", num2);
            Console.Read();
        } 
    }
}
