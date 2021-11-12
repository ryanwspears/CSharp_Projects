using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student"};
            employee.SayName();
            Console.ReadLine();

            IQuittable quittable = new Employee();

            quittable.Quit();

            Console.ReadLine();

            Employee employee1 = new Employee();
            employee.ID = 2365;
            employee1.ID = 2365;

            if(employee == employee1)
            {
                Console.WriteLine("\nThe IDs are a match.");
            }
            else
            {
                Console.WriteLine("\nThe IDs do not match.");
            }

            Console.ReadLine();

            // Begin Lambda Assignment
            // Creating 10 new Employees
            Employee JoeCruz = new Employee() { FirstName = "Joe", LastName = "Cruz", ID = 1};
            Employee JoeTrellis = new Employee() { FirstName = "Joe", LastName = "Trellis", ID = 2 };
            Employee RobbGreen = new Employee() { FirstName = "Robb", LastName = "Green", ID = 3 };
            Employee DonBrown = new Employee() { FirstName = "Don", LastName = "Brown", ID = 4 };
            Employee JohnCarr = new Employee() { FirstName = "John", LastName = "Carr", ID = 5 };
            Employee HaleyTris = new Employee() { FirstName = "Haley", LastName = "Tris", ID = 6 };
            Employee HannahBronst = new Employee() { FirstName = "Hannah", LastName = "Bronst", ID = 7 };
            Employee TristaDurst = new Employee() { FirstName = "Trista", LastName = "Durst", ID = 8 };
            Employee TerryRodes = new Employee() { FirstName = "Terry", LastName = "Rodes", ID = 9 };
            Employee FrankTalen = new Employee() { FirstName = "Frank", LastName = "Talen", ID = 10 };

            // Adding employees to list
            List<Employee> employees = new List<Employee>()
            {
                JoeCruz, JoeTrellis, RobbGreen, DonBrown, JohnCarr, HaleyTris, HannahBronst, TristaDurst, TerryRodes, FrankTalen
            };

            // foreach loop to find all named "Joe"
            foreach(Employee worker in employees)
            {
                if(worker.FirstName == "Joe")
                {
                    List<Employee> joes = new List<Employee>() { worker };
                    Console.WriteLine("\n-First Name: \"" + worker.FirstName + "\" -Last Name: \"" + worker.LastName + "\" -ID: \"" + worker.ID + "\"");
                }
            }

            Console.ReadLine();

            // Lambda to find all named "Joe" and add them to list
            List<Employee> joes2 = employees.Where(x => x.FirstName == "Joe").ToList();
            
            // Prints them to screen
            foreach(Employee joe in joes2)
            {
                Console.WriteLine("\n-First Name: \"" + joe.FirstName + "\" -Last Name: \"" + joe.LastName + "\" -ID: \"" + joe.ID + "\"");
            }

            Console.ReadLine();

            // Lambda to find all IDs greater than 5
            List<Employee> IDs = employees.Where(x => x.ID > 5).ToList();

            // Prints them to screen
            foreach(Employee id in IDs)
            {
                Console.WriteLine("\n-First Name: \"" + id.FirstName + "\" -Last Name: \"" + id.LastName + "\" -ID: \"" + id.ID + "\"");
            }
            // End Lambda Assignment

            Console.Read();
        }
    }
}
