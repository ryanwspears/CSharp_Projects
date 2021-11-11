using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the current day of the week.");
                string dayEntered = Console.ReadLine();

                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayEntered);

                if(day == DaysOfTheWeek.Thursday)
                {
                    Console.WriteLine("Today is Thursday.");
                }
                else
                {
                    Console.WriteLine("Today is not " + day);
                }
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.Read();
        }

        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
