using System;
using System.Collections.Generic;

namespace tryCatch.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>
            {
                2,
                4,
                6,
                8,
                10,
                3,
                5,
                7,
                9
            };

            try
            {
                Console.WriteLine("Enter a number to divide list integers by...");
                int num = Convert.ToInt32(Console.ReadLine());
                foreach (int i in intList)
                {
                    int dividend = i / num;
                    Console.WriteLine(i + " divided by " + num + " equals " + dividend);
                }
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Program has completed successfully.");
            Console.Read();
        }
    }
}
