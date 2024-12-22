using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_project
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("\n==================Train Operations=============");
                Console.WriteLine("Choose an operation");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. User");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Admin.Adminlogin();
                        break;
                    case 2:
                        User.UserMenu();
                        break;
                    case 3:
                        Console.WriteLine("Closing Application");
                        return;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;

                }
               
            }
        }
    }
}