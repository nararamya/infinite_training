using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            string input = Console.ReadLine();
            try
            {
                int number = int.Parse(input);
                CheckPostive(number);
                Console.WriteLine("postive number entered:{0}", number);
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid input entered");
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("error occurred;{0}", (e.Message));
            }
            Console.Read();
        }
        static void CheckPostive(int number)
        {
            if(number<0)
            {
                throw new ArgumentOutOfRangeException("Number cannot be negative");
            }
           
        }
    }
}
