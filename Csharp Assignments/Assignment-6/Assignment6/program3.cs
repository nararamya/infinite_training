using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Employees
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public double EmpSalary { get; set; }

    }
    class program3
    {
        static void Main()
        {
            List<Employees> employees = new List<Employees>();

            for (int i = 1; i < 4; i++)
            {
                Console.Write("Enter the employee id {0} Id : ", i);
                int empid = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the employee {0} Name : ", i);
                string empname = Console.ReadLine();
                Console.Write("Enter the employee {0} city : ", i);
                string empcity = Console.ReadLine();
                Console.Write("Enter the employee {0} salary : ", i);
                double empsalary = Convert.ToDouble(Console.ReadLine());

                employees.Add(new Employees
                {
                    EmpId = empid,
                    EmpName = empname,
                    EmpCity = empcity,
                    EmpSalary = empsalary
                });
            }
            Console.WriteLine("------------all employees data------------");
            foreach (var a in employees)
            {
                Console.WriteLine($"Employee Id : {a.EmpId} , Employee Name : {a.EmpName} ,Employee City : {a.EmpCity} ,Employee Salary : {a.EmpSalary}");
            }
            Console.WriteLine("--------- all employees data whose salary is greater than 45000-------------------");

            IEnumerable<Employees> Emp = employees.Where(b => b.EmpSalary > 45000);

            foreach (var e in Emp)
            {
                if (e != null)
                {
                    Console.WriteLine($"Employee Id : {e.EmpId} , Employee Name : {e.EmpName} ,Employee City : {e.EmpCity} ,Employee Salary : {e.EmpSalary}");
                }
                else
                    Console.WriteLine("Employee not found");
            }
            Console.WriteLine("--------- employees data whose belong to Bangalore Region-------------------");

            Employees d = employees.Find(emp => emp.EmpCity == "Bangalore");

            if (d != null)
            {
                Console.WriteLine($"Employee Id : {d.EmpId} , Employee Name : {d.EmpName} ,Employee City : {d.EmpCity} ,Employee Salary : {d.EmpSalary}");
            }
            else
                Console.WriteLine("Employee not found");

            Console.WriteLine("--------- all employees data by their names in Ascending order-------------------");

            IEnumerable<Employees> sortedEmployees = employees.OrderBy(s => s.EmpName);

            foreach (var f in sortedEmployees)
            {
                Console.WriteLine($"Employee Id : {f.EmpId} , Employee Name : {f.EmpName} ,Employee City : {f.EmpCity} ,Employee Salary : {f.EmpSalary}");
            }

            Console.Read();

        }
    }
}
