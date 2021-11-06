using System;

namespace InsuranceApproval.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Car Insurance Approval \n\nWhat is your Age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nHave you ever had a DUI?(type 'true' or 'false')");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("\nHow many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            bool qualified;

            if(age > 15 && dui == false && tickets <= 3)
            {
                qualified = true;
                Console.WriteLine("\nQualified? \n" + qualified);
            }
            else
            {
                qualified = false;
                Console.WriteLine("\nQualified? \n" + qualified);
            }

            Console.Read();
        }
    }
}
