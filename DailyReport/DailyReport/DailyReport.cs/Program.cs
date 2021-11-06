using System;

namespace DailyReport.cs
{
    class Program
    {
        static void Main()
        {
            // Asks the user a question and stores their answer in a string variable.
            Console.WriteLine("The Tech Academy \nStudent Daily Report \n\nWhat is your name?");
            string name = Console.ReadLine();

            // Asks the user a question and stores their answer in a string variable.
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            // Asks the user a question and stores their answer in a string variable that gets converted to an integer.
            Console.WriteLine("What page number?");
            int page = Convert.ToInt32(Console.ReadLine());

            // Asks the user a question and stores their answer in a string variable that gets converted to a boolean.
            Console.WriteLine("Do you need help with anything? Answer with 'true' or 'false'.");
            bool help = Convert.ToBoolean(Console.ReadLine());

            // Asks the user a question and stores their answer in a string variable.
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experiences = Console.ReadLine();

            // Asks the user a question and stores their answer in a string variable.
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            // Asks the user a question and stores their answer in a string variable that gets converted to an integer.
            Console.WriteLine("How many hours did you study?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());

            // Prints a line of text and waits for the user's input.
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
