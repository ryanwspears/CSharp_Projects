using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Method method = new Method();

            Console.WriteLine("Enter an integer.\n");
            int chosenNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n" + chosenNum1 + " * 5 = " + method.Operate(chosenNum1));

            Console.WriteLine("Enter an decimal.\n");
            decimal chosenNum2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\n" + chosenNum2 + " + 15 = " + method.Operate(chosenNum2));

            Console.WriteLine("Enter an number.\n");
            string chosenNum3 = Console.ReadLine();
            Console.WriteLine("\n" + chosenNum3 + " * (5 + 5) = " + method.Operate(chosenNum3));

            Console.Read();
        }
    }
}
