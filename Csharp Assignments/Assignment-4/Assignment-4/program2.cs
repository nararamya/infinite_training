using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Scholarship
    {
        int marks = 0;
        float fees = 0;
     

        public void Merit()
        {
            Console.WriteLine("Enter your marks :");
            float marks = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fees:");
            float fees = float.Parse(Console.ReadLine());

           

            if (marks >= 70 && marks <= 80)
            {
                Console.WriteLine((float)0.2 * fees);
               
            }
            else if (marks > 80 && marks <= 90)
            {
              Console.WriteLine((float)0.3* fees);
            }
            else if (marks > 90)
            {
              Console.WriteLine ((float)0.5 * fees);
            }
            else
            {
                Console.WriteLine("Pay the full feee");
            }
            return;
        }


        static void Main(string[] args)
        {
            Scholarship amn = new Scholarship();
            amn.Merit();
           
            Console.Read();

        }
    }
}
