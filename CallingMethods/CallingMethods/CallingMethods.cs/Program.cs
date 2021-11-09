using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number that you want to perform the math operations on below.\n");
            int chosenNum = Convert.ToInt32(Console.ReadLine());

            Methods method = new Methods();

            Console.WriteLine("\n" + chosenNum + " + 25 = " + method.Add(chosenNum));
            Console.WriteLine("\n" + chosenNum + " * 5 = " + method.Multiply(chosenNum));
            Console.WriteLine("\n" + chosenNum + " / 2 = " + method.Divide(chosenNum));

            Console.Read();
        }
    }
}
