using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.cs
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
