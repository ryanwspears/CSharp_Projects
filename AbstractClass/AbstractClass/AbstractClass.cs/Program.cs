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

            Console.Read();
        }
    }
}
