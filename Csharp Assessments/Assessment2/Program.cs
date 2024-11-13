using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    
      public abstract class Student
        {
            public String Name { get; set; }
             public String StudentId { get; set; }
            public double Grade { get; set; }
            
            public abstract bool IsPassed(double grade);
        }
        
       public class Undergraduate :Student
        {
            public override bool IsPassed(double grade)
            {
                return grade > 70.0;
            }
            
        }
        public class Graduate : Student
        {
            public override bool IsPassed(double grade)
            {
                return grade > 80.0;
            }
        }
    class Program
    {
        static void Main(string[] args)
            {
            Undergraduate undergrad = new Undergraduate
            {
               
                Name = "ramya",
                StudentId = "In233",
                Grade = 75.0

            };
            Graduate grad = new Graduate
            {
                Name = "ram",
                StudentId = "In244",
                Grade = 85.0
            };
            Console.WriteLine($"{undergrad.Name} (Undergraduate) has passed:{undergrad.IsPassed(undergrad.Grade)}");
            Console.WriteLine($"{grad.Name} (Graduate) has passed:{grad.IsPassed(grad.Grade)}");
            Console.Read();

            }
        }
    }



