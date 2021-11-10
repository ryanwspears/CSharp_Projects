using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Method method = new Method();

            Console.WriteLine("Please enter a number to use in the operation.");
            int chosenNum1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("If you wish, you may enter a second number. If not, leave blank.");
            string chosenNum2 = Console.ReadLine();

            if (chosenNum2 == "")
            {
                Console.WriteLine("The operation came out to be:");
                Console.WriteLine("(" + chosenNum1 + " * 5) / 2 = " + method.Operation(chosenNum1));
            }
            else
            {
                int chosenNum2Int = Convert.ToInt32(chosenNum2);
                Console.WriteLine("The operation came out to be:");
                Console.WriteLine("(" + chosenNum1 + " * 5) / " + chosenNum2Int + " = " + method.Operation(chosenNum1, chosenNum2Int));
            }

            Console.Read();
        }
    }
}
