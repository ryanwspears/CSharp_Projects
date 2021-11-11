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
            Console.WriteLine("Input an integer.\n");
            int chosenInt = Convert.ToInt32(Console.ReadLine());

            // Call the method on that number.
            method.Method(chosenInt);

            // Have the user enter 2 numbers.
            Console.WriteLine("\nInput an integer.\n");
            int chosenInt2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIf you wish, input another integer.\n");
            int chosenInt3 = Convert.ToInt32(Console.ReadLine());

            // Call the method on that number(Overloaded).
            method.Method(chosenInt2, chosenInt3);

            // Call the method on that number(Output).
            method.OutputMethod(out int num2);

            // Call a method from a static class.
            StatClass.Method2();

            Console.Read();
        }
    }
}
