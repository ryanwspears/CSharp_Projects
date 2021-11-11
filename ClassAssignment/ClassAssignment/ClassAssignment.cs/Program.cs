using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the Main() method, instantiate that class.
            MethodClass method = new MethodClass();

            // Have the user enter a number.
            Console.WriteLine("Input an integer.");
            int chosenInt = Convert.ToInt32(Console.ReadLine());

            // Call the method on that number.
            method.Method(chosenInt);

            Console.Read();
        }
    }
}
