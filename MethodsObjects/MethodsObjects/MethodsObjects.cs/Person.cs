using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjects.cs
{
    class Person
    {
        public string FirstName;
        public string LastName;

        public void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
