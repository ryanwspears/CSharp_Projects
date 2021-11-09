using System;
using System.Collections.Generic;

namespace iterateExercise.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            string[] strArray = { "Hello", "Goodbye", "See you later", "Nice to meet you", "Good to see you", "How are you" };

            Console.WriteLine("Input some text below.\n");
            string input = Console.ReadLine();

            for (int i = 0; i < strArray.Length; i++)
            {
                strArray[i] = strArray[i] + " " + input;
            }

            Console.WriteLine("\n");

            for (int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine("\n" + strArray[i]);
            }

            Console.ReadLine();
            // End Part 1

            // Part 2
            int num = 1;

            do
            {
                Console.WriteLine(num++);
            }
            // To make this an inifinite loop, change (num < 5000) ---> (num > 0).
            while (num < 5000);

            Console.WriteLine("Ending number is " + num);
            Console.ReadLine();
            // End Part 2

            // Part 3
            int loopNum = 0;
            int loopNum2 = 0;

            while(loopNum < 10)
            {
                loopNum++;
                Console.WriteLine(loopNum);
            }

            Console.ReadLine();

            while(loopNum2 <= 19)
            {
                loopNum2++;
                Console.WriteLine(loopNum2);
            }
            // End Part 3

            // Part 4
            List<string> wordList = new List<string>
            {
                "soda",
                "mindless",
                "parsimonious",
                "abject",
                "level",
                "opposite",
                "miniature",
                "class",
                "temper",
                "compare",
                "injure",
                "stick",
                "aspiring",
                "flock",
                "imminent",
                "extra-large",
                "spark",
                "lake",
                "passenger",
                "groan",
                "remember",
                "act",
                "plan",
                "clumsy",
                "puffy"
            };

            Console.WriteLine("\n\nSearch the String List. Enter your search term below.\n");
            string searchTerm = Console.ReadLine();

            for(int i = 0; i < wordList.Count; i++)
            {
                if(wordList.Contains(searchTerm))
                {
                    Console.WriteLine("\n\"" + searchTerm + "\" is at indices " + wordList.IndexOf(searchTerm) + ".");
                    break;
                }
                else
                {
                    Console.WriteLine("\n\"" + searchTerm + "\" is not in the list.");
                    break;
                }
            }
            // End Part 4

            // Part 5
            List<string> wordList2 = new List<string>
            {
                "soda",
                "mindless",
                "plan",
                "stick",
                "level",
                "opposite",
                "miniature",
                "act",
                "temper",
                "compare",
                "injure",
                "stick",
                "aspiring",
                "act",
                "imminent",
                "extra-large",
                "spark",
                "lake",
                "soda",
                "groan",
                "level",
                "act",
                "plan",
                "clumsy",
                "level"
            };

            Console.WriteLine("\n\nSearch the String List. Enter your search term below.\n");
            string searchTerm2 = Console.ReadLine();

            for(int i = 0; i < wordList2.Count; i++)
            {
                if(wordList2[i] == searchTerm2)
                {
                    Console.WriteLine("\n\"" + searchTerm2 + "\" is at indices " + i + ".");
                }
                else
                {
                    Console.WriteLine("\n\"" + searchTerm2 + "\" is not in the list.");
                }
            }
            // End Part 5

            Console.WriteLine("\n");
            Console.ReadLine();

            //Part 6
            List<string> wordList3 = new List<string>
            {
                "soda",
                "mindless",
                "plan",
                "stick",
                "level",
                "opposite",
                "miniature",
                "act",
                "temper",
                "compare",
                "injure",
                "stick",
                "aspiring",
                "act",
                "imminent",
                "extra-large",
                "spark",
                "lake",
                "soda",
                "groan",
                "level",
                "act",
                "plan",
                "clumsy",
                "level"
            };

            List<string> dupes = new List<string>();

            foreach(string s in wordList3)
            {
                if(dupes.Contains(s))
                {
                    Console.WriteLine(s + " has already appeared in the list.");
                }
                else
                {
                    dupes.Add(s);
                }
            }
            // End part 6

            Console.Read();
        }
    }
}
