using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2016.Presentation.Command;
using Linq_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Linq_project
{


    class program
    {
        private string EmployeeID;
        private string FirstName;
        private string LastName;
        private string Title;
        private string DOB;
        private string DOJ;
        private string City;

        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee
            {
                EmployeeID = 1001,
                FirstName = "Malcolm",
                LastName = "Daruwalla",
                Title = "manager",
                DOB = Convert.ToDateTime("11/16/1984"),
                DOJ = Convert.ToDateTime("06/08/2011"),
                City = "Mumbai",

            });
            list.Add(new Employee
            {
                EmployeeID = 1002,
                FirstName = "Asdin",
                LastName = "Dhalla",
                Title = "AsstManager",
                DOB = Convert.ToDateTime("08/20/1984"),
                DOJ = Convert.ToDateTime("07/07/2012"),
                City = "Mumbai",

            });
            list.Add(new Employee
            {
                EmployeeID = 1003,
                FirstName = "Madhavi",
                LastName = "Oza",
                Title = "Consultant",
                DOB = Convert.ToDateTime("11/14/1987"),
                DOJ = Convert.ToDateTime("04/12/2015"),
                City = "Pune",

            });
            list.Add(new Employee
            {
                EmployeeID = 1004,
                FirstName = "Sabha",
                LastName = "Shaik",
                Title = "SE",
                DOB = Convert.ToDateTime("06/03/1990"),
                DOJ = Convert.ToDateTime("02/02/2016"),
                City = "Pune",

            });
            list.Add(new Employee
            {
                EmployeeID = 1005,
                FirstName = "Nazia",
                LastName = "Shaik",
                Title = "SE",
                DOB = Convert.ToDateTime("03/08/1991"),
                DOJ = Convert.ToDateTime("02/02/2016"),
                City = "Mumbai",

            });
            list.Add(new Employee
            {
                EmployeeID = 1006,
                FirstName = "Amit",
                LastName = "Pathakk",
                Title = "Consultant",
                DOB = Convert.ToDateTime("11/07/1989"),
                DOJ = Convert.ToDateTime("08/08/2014"),
                City = "Chennai",

            });
            list.Add(new Employee
            {
                EmployeeID = 1007,
                FirstName = "Vijay",
                LastName = "Natrajan",
                Title = "Consultant",
                DOB = Convert.ToDateTime("12/02/1989"),
                DOJ = Convert.ToDateTime("06/01/2015"),
                City = "Mumbai",

            });
            list.Add(new Employee
            {
                EmployeeID = 1008,
                FirstName = "Rahul",
                LastName = "Dubey",
                Title = "Associate",
                DOB = Convert.ToDateTime("11/11/1993"),
                DOJ = Convert.ToDateTime("11/06/2014"),
                City = "Chennai",

            });
            list.Add(new Employee
            {
                EmployeeID = 1009,
                FirstName = "Suresh",
                LastName = "Mistry",
                Title = "Associate",
                DOB = Convert.ToDateTime("08/12/1992"),
                DOJ = Convert.ToDateTime("12/03/2014"),
                City = "Chennai",

            });
            list.Add(new Employee
            {
                EmployeeID = 1010,
                FirstName = "Sumit",
                LastName = "Shah",
                Title = "Manager",
                DOB = Convert.ToDateTime("04/12/1991"),
                DOJ = Convert.ToDateTime("01/02/2016"),
                City = "Pune",

            });
            IEnumerable<Employee> EmployeeQuery = from Employee in list
                                                  where Employee.EmployeeID > 1000
                                                  select Employee;


            foreach (var employee in EmployeeQuery)
            {
                Console.WriteLine(employee.EmployeeID);
                Console.WriteLine(employee.FirstName);
                Console.WriteLine(employee.LastName);
                Console.WriteLine(employee.Title);
                Console.WriteLine(employee.DOB);
                Console.WriteLine(employee.City);
                Console.WriteLine("**=======*****========********");
            }



            IEnumerable<Employee> EmployeeQuery2 = from Employee in list
                                                   where Employee.City != "Mumbai"
                                                   select Employee;
            Console.WriteLine(" -----------------------------------------------------------------------Employee details whose city is not Mumbai");

            foreach (var employee in EmployeeQuery2)
            {

                Console.WriteLine(employee.EmployeeID);
                Console.WriteLine(employee.FirstName);
                Console.WriteLine(employee.LastName);
                Console.WriteLine(employee.Title);
                Console.WriteLine(employee.DOB);
                Console.WriteLine(employee.City);
                Console.WriteLine("**=======*****========********");
            }
            IEnumerable<Employee> EmployeeQuery3 = from Employee in list
                                                   where Employee.Title == "AsstManager"
                                                   select Employee;
            Console.WriteLine("-----------------------------------------------------------title= AsstManager");
            foreach (var employee in EmployeeQuery3)
            {

                Console.WriteLine(employee.EmployeeID);
                Console.WriteLine(employee.FirstName);
                Console.WriteLine(employee.LastName);
                Console.WriteLine(employee.Title);
                Console.WriteLine(employee.DOB);
                Console.WriteLine(employee.City);
                Console.WriteLine("**=======*****========********");
            }
            IEnumerable<Employee> EmployeeQuery4 = from Employee in list
                                                   where Employee.LastName.StartsWith("S")
                                                   select Employee;
            Console.WriteLine("-------------------------------------------------------------starts with S");
            foreach (var employee in EmployeeQuery4)
            {

                Console.WriteLine(employee.EmployeeID);
                Console.WriteLine(employee.FirstName);
                Console.WriteLine(employee.LastName);
                Console.WriteLine(employee.Title);
                Console.WriteLine(employee.DOB);
                Console.WriteLine(employee.City);
                Console.WriteLine("**=======*****========********");
            }
            IEnumerable<Employee> EmployeeQuery5 = from Employee in list
                                                   where Employee.DOJ < Convert.ToDateTime("01/01/2015")
                                                   select Employee;
            Console.WriteLine("-------------------------------------------------------------Joined before 01/01/2015");
            foreach (var employee in EmployeeQuery5)
            {

                Console.WriteLine(employee.EmployeeID);
                Console.WriteLine(employee.FirstName);
                Console.WriteLine(employee.LastName);
                Console.WriteLine(employee.Title);
                Console.WriteLine(employee.DOB);
                Console.WriteLine(employee.City);
                Console.WriteLine("**=======*****========********");
            }
            IEnumerable<Employee> EmployeeQuery6 = from Employee in list
                                                   where Employee.DOB > Convert.ToDateTime("01/01/1990")
                                                   select Employee;
            Console.WriteLine("-------------------------------------------------------------DOB after 01/01/1990");
            foreach (var employee in EmployeeQuery6)
            {

                Console.WriteLine(employee.EmployeeID);
                Console.WriteLine(employee.FirstName);
                Console.WriteLine(employee.LastName);
                Console.WriteLine(employee.Title);
                Console.WriteLine(employee.DOB);
                Console.WriteLine(employee.City);
                Console.WriteLine("**=======*****========********");
            }
            IEnumerable<Employee> EmployeeQuery7 = from Employee in list
                                                   where Employee.Title == "Consultant" || Employee.Title == "Associate"
                                                   select Employee;
            Console.WriteLine("-----------------------------------------------------------Title= Consultant and Associate");
            foreach (var employee in EmployeeQuery7)
            {

                Console.WriteLine(employee.EmployeeID);
                Console.WriteLine(employee.FirstName);
                Console.WriteLine(employee.LastName);
                Console.WriteLine(employee.Title);
                Console.WriteLine(employee.DOB);
                Console.WriteLine(employee.City);
                Console.WriteLine("**=======*****========********");
            }
     

                                              
            Console.WriteLine("---------------   Query 8     ----------Total number of Employees: {0}", list.Count);
           
            int EmployeeQuery9 = (from Employee in list 
                                  where Employee.City=="Chennai"
                                  select Employee).Count();
            Console.WriteLine("-------------------       Query 9    -------------------------Chennai Employees:{0}", EmployeeQuery9);
            int EmployeeQuery10 = list.Max(x => x.EmployeeID);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("------------------------------------        Query 10     --------------------------Highest Employee Id from the List was : {0}", EmployeeQuery10);



            Console.WriteLine();
            int EmployeeQuery11 = (from Employee in list
                              where Employee.DOJ > new DateTime(2015, 01, 1, 0, 0, 0)
                              select Employee).Count();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Total Number of Employees Joined after 1/1/2015 was : {0}", EmployeeQuery11);
            Console.WriteLine();



            int EmployeeQuery12 = (from Employee in list
                              where Employee.Title != "Associate"
                              select Employee).Count();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Total Number of Employess who are not Associates : {0}", EmployeeQuery12);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();


            var EmployeeQuery15 = list.Select(em => em.DOB);
            Console.WriteLine("Youngest Employee DOB : {0}",EmployeeQuery15.Max());
            Console.WriteLine("--------------------------------------------------------");
                               
            
            Console.WriteLine();

            var EmployeeQuery13 = from Employee in list
                                   group Employee by new

                                   {
                                       Employee.City,

                                   } into Employee1
                                   select new
                                   {
                                       City = Employee1.Key.City,
                                       Count_Cit = Employee1.OrderBy(x => x.City)
                                   };

            foreach(var item in EmployeeQuery13)
            {
                Console.WriteLine($"City: {item.City} Number of Employees = {item.Count_Cit.Count()}");
               

            }
            var EmployeeQuery14 = from Employee in list
                                  group Employee by new

                                  {
                                      Employee.City,
                                      Employee.Title,

                                  } into Employee2
                                  select new
                                  {
                                      City = Employee2.Key.City,
                                      Count_Cit = Employee2.OrderBy(x => x.City),
                                      Title = Employee2.Key.Title,
                                      Count_Tit = Employee2.OrderBy(x => x.Title)
                                  };

            Console.WriteLine("--------------------------------------------------------");

            foreach (var item in EmployeeQuery14)
            {

                Console.WriteLine($"City: {item.City},Title: {item.Title} Number of Employees = {item.Count_Cit.Count()}");

               
                Console.WriteLine("\n");

            }



        }
        public class Employee
        {
            public int EmployeeID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Title { get; set; }
            public DateTime DOB { get; set; }
            public DateTime DOJ { get; set; }
            public string City { get; set; }
        }




    }
}

   


           