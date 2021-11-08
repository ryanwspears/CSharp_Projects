using System;

namespace doWhile.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess the anime character\n\nType your guess...");
            string guess = Console.ReadLine();

            bool guessed = guess == "Saitama";

            do
            {
                switch(guess) {
                    case "Saitama":
                        Console.WriteLine("\n\nYou are correct!");
                        guessed = true;
                        Console.Read();
                        break;
                    default:
                        Console.WriteLine("\n\nThat is incorrect. Try again.\n");
                        Console.WriteLine("Type your guess...");
                        guess = Console.ReadLine();
                        break;
                }
            }
            while(!guessed);
        }
    }
}
