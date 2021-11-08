using System;
using System.Collections.Generic;

namespace array.cs
{
    class Program
    {
        static void Main()
        {
            string[] strArray = { "Hello", "Goodbye", "Have a nice day.", "Good Morning.", "Good Night.", "How are you?" };

            int[] intArray = { 3, 7, 36, 894, 24, 883 };

            List<string> strList = new List<string>
            {
                "Bonjour",
                "Ohayo",
                "Hello",
                "Hola",
                "Ni hao",
                "Anyoung"
            };


            Console.WriteLine("Select an index from our array of strings.\n");
            int strArrayIndex = Convert.ToInt32(Console.ReadLine());

            while(strArray.Length < strArrayIndex)
            {
                Console.WriteLine("\nThat index doesn't exist. Try again...\n");
                strArrayIndex = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n" + strArray[strArrayIndex]);


            Console.WriteLine("\n\nSelect an index from our array of ints.\n");
            int intArrayIndex = Convert.ToInt32(Console.ReadLine());

            while(intArray.Length < intArrayIndex)
            {
                Console.WriteLine("\nThat index doesn't exist. Try again...\n");
                intArrayIndex = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n" + intArray[intArrayIndex]);


            Console.WriteLine("\n\nSelect an index from our list of strings.\n");
            int strListIndex = Convert.ToInt32(Console.ReadLine());

            while(strList.Count < strListIndex)
            {
                Console.WriteLine("\nThat index doesn't exist. Try again...\n");
                strListIndex = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n" + strList[strListIndex]);


            Console.Read();
        }
    }
}
