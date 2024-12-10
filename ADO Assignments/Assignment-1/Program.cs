using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Emplist = new List<Employee>
              {
                new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla",
                    Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" },
                new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla",
                   Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai"},
                new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza",
                    Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
                new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh",
                    Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
               new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh",
                   Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
               new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak",
                   Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
                new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan",
                    Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
               new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey",
                   Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
              new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry",
                  Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
               new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah",
                   Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }
            };
            Console.WriteLine("list of all the employee who have joined before 1/1/2015:");
            var a = Emplist.Where(e => e.DOJ < new DateTime(2015, 1, 1)).Select(n => n);
            foreach (var item in a)
            {
                Console.WriteLine($"Employee Id : {item.EmployeeID} , Employee Name : {item.FirstName}, Title : {item.Title} ,DOB:{item.DOB}, DOJ : {item.DOJ.ToShortDateString()} , City : {item.City}");
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(" list of all the employee whose date of birth is after 1/1/1990:");

            var b = Emplist.Where(e => e.DOB > new DateTime(1990, 1, 1)).Select(n => n);
            foreach (var item in b)
            {
                Console.WriteLine($"Employee Id : {item.EmployeeID} , Employee Name : {item.FirstName}, Title : {item.Title} ,DOB:{item.DOB}, DOJ : {item.DOJ.ToShortDateString()} , City : {item.City}");
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(" list of all the employee whose designation is Consultant and Associate:");

            var c = Emplist.Where(e => e.Title == "Consultant" || e.Title == "Associate").Select(n => n);
            foreach (var item in c)
            {
                Console.WriteLine($"Employee Id : {item.EmployeeID} , Employee Name : {item.FirstName}, Title : {item.Title} ,DOB:{item.DOB},DOJ : {item.DOJ.ToShortDateString()} , City : {item.City}");
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("total number of employees:");

            var d = Emplist.Count();
            Console.WriteLine(d);

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("total number of employees belonging to “Chennai”:");

            var f = Emplist.Where(e => e.City == "Chennai").Select(n => n);
            var s = f.Count();
            Console.WriteLine(s);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("highest employee id from the list:");
            var emp = Emplist.Select(h => h.EmployeeID).Max();
            Console.WriteLine(emp);

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("list of all the employee who have joined after 1/1/2015:");
            var i = Emplist.Where(e => e.DOJ > new DateTime(2015, 1, 1)).Select(n => n);
            foreach (var item in i)
            {
                Console.WriteLine($"Employee Id : {item.EmployeeID} , Employee Name : {item.FirstName}, Title : {item.Title} ,DOB:{item.DOB},DOJ : {item.DOJ.ToShortDateString()} , City : {item.City}");
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("total number of employee whose designation is not “Associate”");

            var j = Emplist.Where(e => e.Title != "Associate").Select(n => n);
            var k = j.Count();
            Console.WriteLine(k);

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("total number of employee based on City");
            var l = Emplist.GroupBy(e => e.City);
            foreach (var item in l)
            {
                Console.WriteLine($"{item.Key} : {item.Count()}");
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("total number of employee based on City and Title");
            var m = Emplist.GroupBy(e => (e.City, e.Title));
            foreach (var item in m)
            {
                Console.WriteLine($"{item.Key.City},{item.Key.Title} : {item.Count()}");


            }


            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("employee who is youngest in the list:");
            var z = Emplist.OrderByDescending(e => e.DOB.ToShortDateString()).Last();

            Console.WriteLine($"Employee Id : {z.EmployeeID} , Employee Name : {z.FirstName}, Title : {z.Title} ,DOB:{z.DOB}, DOJ : {z.DOJ.ToShortDateString()} , City : {z.City}");


            Console.Read();
        }

    }
}


