using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Employee
    {
       public int Empid;
       public string EmpName;
        public float Salary;
        public Employee(int Empid,string EmpName,float Salary)
        {
            this.Empid = Empid;
            this.EmpName = EmpName;
            this.Salary = Salary;
        }
        public void display()
        {
            
            Console.WriteLine("The empid is {0}", Empid);
            Console.WriteLine("The empname is {0}", EmpName);
            Console.WriteLine("The salary is {0}", Salary);
        }

    }
    class ParttimeEmployee:Employee

    {
        public ParttimeEmployee(int Empid, string EmpName, float Salary):base(Empid, EmpName, Salary)
        { 
        }
        int wages;
        
    }
    class employee
    {
        public static void Main()
        {
           
            Console.WriteLine("Enter the empid:");
            int empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the empname:");
            string empname = Console.ReadLine();
            Console.WriteLine("Enter the salary:");
            float salary = Convert.ToInt32(Console.ReadLine());

            ParttimeEmployee pe = new ParttimeEmployee(empid,empname,salary);
            pe.display();

            Employee emp = new Employee(empid, empname, salary);
            emp.display();

            Console.Read();
        }
    }
}
