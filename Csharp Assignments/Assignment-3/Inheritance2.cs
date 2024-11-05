using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Inheritance2
    {
        protected int rollno;
        protected string name;
        protected string Class;
        protected int Semester;
        protected string branch;
        protected int[] marks = new int[5];
        protected int sum = 0;
        public Inheritance2(int rollnum, string Name, string ClasS, int SEM, string Branch)
        {
            rollno = rollnum;
            name = Name;
            Class = ClasS;
            Semester = SEM;
            branch = Branch;
        }
        public void GetMarks()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Enter marks of subject {0}:", i+1);
                marks[i] = Convert.ToInt32(Console.ReadLine());



            }

        }
    }

    internal class Average : Inheritance2
    {
        public Average(int rollnum, string Name, string ClasS, int SEM, string Branch)
       : base(rollnum, Name, ClasS, SEM, Branch)
        {

        }
        public void displayresult()
        {
            for (int i = 0; i < marks.Length; i++)
            {

                sum += marks[i];
            }

            double average = (double)sum / marks.Length;
            for (int j = 1; j < marks.Length; j++)
            {

                if (marks[j] < 35)
                {
                    Console.WriteLine("Failed in subject {0}", j);
                }
            }
            if (average > 50)
            {
                Console.WriteLine("Student Passed and  Average : {0} ", average);
            }
            else
            {
                Console.WriteLine("Student Failed and Average : {0} ", average);
            }
        }

        public void Display_Data()
        {
            Console.WriteLine("Student Roll No : {0}", rollno);
            Console.WriteLine("Student Name : {0}", name);
            Console.WriteLine("Class : {0}", Class);
            Console.WriteLine("Semester : {0}", Semester);
            Console.WriteLine("Branch : {0}", branch);
        }
        class Inheritance
        {
            public static void Main()
            {
                Console.WriteLine("Enter the student roll");
                int rollnum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the student name");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter the student class");
                string ClasS = Console.ReadLine();
                Console.WriteLine("Enter the semester");
                int SEM = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the student branch");
                string Branch = Console.ReadLine();

                Average avg = new Average(rollnum, Name, ClasS, SEM, Branch);

                avg.GetMarks();
                avg.displayresult();
                avg.Display_Data();


                Console.Read();
            }

        }
    }
}


    




