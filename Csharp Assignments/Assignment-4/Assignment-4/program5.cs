using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    interface IStudent
    {
        int StudentId { get; set; }
          string Name { get; set; }
        void ShowDetails();

    }
    class Dayscholar:IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public void ShowDetails()
        {
            Console.WriteLine("------Dayscholar details--------");
            Console.WriteLine("The student id is {0}", StudentId);
            Console.WriteLine("The student name is {0}", Name);
        }

    }

    class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public void ShowDetails()
        {
            Console.WriteLine("----------Resident details------------");
            Console.WriteLine("The student id is {0}", StudentId);
            Console.WriteLine("The student name is {0}", Name);
        }


    }
   

    class interfaces
    {
        static void Main()
        {


            IStudent Is = new Dayscholar();

            Console.WriteLine("----------Enter Daysscholar details--------------");
            Console.WriteLine("Enter the student id:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the student name:");
            string name = Console.ReadLine();

            Is.StudentId = id;
            Is.Name = name;
            Is.ShowDetails();

            IStudent Id = new Resident();

            Console.WriteLine("-------enter resident details---------");
            Console.WriteLine("Enter the student id:");
            int ids = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the student name:");
            string names = Console.ReadLine();
            Id.StudentId = ids;
            Id.Name = names;

            Id.ShowDetails();
            
           



            Console.Read();


        }
    }
}
