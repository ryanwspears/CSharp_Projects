using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.cs
{
    public class Employee : Person, IQuittable
    {
        public int ID;

        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

        public void Quit()
        {
            Console.WriteLine("I quit.");
        }

        public static bool operator== (Employee employee1, Employee employee2)
        {
            if(employee1.ID == employee2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator!= (Employee employee1, Employee employee2)
        {
            if (employee1.ID != employee2.ID)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
