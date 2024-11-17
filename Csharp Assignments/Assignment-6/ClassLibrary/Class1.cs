using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Class1
    {
        static int age;
        static String Name;
        const double Total_Fare = 500;
        public void Calculate(string Name, int age)
        {

            if (age <= 5)
            {
                Console.WriteLine("Little Champs-Free Ticket");
            }
            else if (age > 60)
            {
                double TotalFare = 500 - (0.3 * Total_Fare);
                Console.WriteLine("Senior Citizen" + " " + TotalFare);
            }
            else
            {
                Console.WriteLine("Tickets Booked" + " " + Total_Fare);
            }
            Console.Read();
        }

    }
}
