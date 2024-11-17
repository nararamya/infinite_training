using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Assignment6
{
    class CalculateFare
    {
        const double Total_Fare = 500;

        static void Main()
        {
            const double Total_Fare = 500;
            Console.WriteLine("Enter the name : ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the age :");
            int age = Convert.ToInt32(Console.ReadLine());
            Class1 s = new Class1();
            s.Calculate(Name, age);
            Console.Read();
        }
    }
}

