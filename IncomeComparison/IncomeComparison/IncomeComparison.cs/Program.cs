using System;

namespace IncomeComparison.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program \n\n");

            Console.WriteLine("Person 1: \nWhat is the hourly rate?");
            decimal rate1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("How many hours worked per week?");
            int hours1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            Console.WriteLine("Person 2: \nWhat is the hourly rate?");
            decimal rate2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("How many hours worked per week?");
            int hours2 = Convert.ToInt32(Console.ReadLine());

            decimal annualPay1 = (rate1 * hours1) * 52;
            decimal annualPay2 = (rate2 * hours2) * 52;

            Console.WriteLine("\n\n");

            Console.WriteLine("Annual salary of Person 1: \n" + annualPay1);
            Console.WriteLine("Annual salary of Person 2: \n" + annualPay2);

            Console.WriteLine("\n\n");

            Console.WriteLine("Does Person 1 make more money than person 2?");

            if(annualPay1 > annualPay2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            Console.Read();
        }
    }
}
