using System;

namespace ShippingQuote.cs
{
    class Program
    {
        static void Main()
        {
            bool eligible = true;

            while(eligible == true)
            {
                Console.WriteLine("Welcome to Package Express. Please follow the instructions below. \n\n");

                Console.WriteLine("What is the weight of your package?");
                int weight = Convert.ToInt32(Console.ReadLine());

                if (weight > 50)
                {
                    eligible = false;
                    Console.WriteLine("\n\nYour package is too heavy to ship with Package Express. Have a good day.");
                    Console.Read();
                    return;
                }

                Console.WriteLine("\nWhat is the width of your package?");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nWhat is the height of your package?");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nWhat is the legnth of your package?");
                int legnth = Convert.ToInt32(Console.ReadLine());

                int demensionsSum = width + height + legnth;

                if (demensionsSum > 50)
                {
                    eligible = false;
                    Console.WriteLine("\n\nYour package is too big to ship with Package Express. Have a good day.");
                    Console.Read();
                    return;
                }

                int quote = ((width * height * legnth) * weight) / 100;

                Console.WriteLine("\n\nYour estimated total for shipping this package is: $" + quote + ".00 \nThank you!");
                Console.Read();
                return;
            }
        }
    }
}
