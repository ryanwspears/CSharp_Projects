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
            int tries = 5;

            while(tries > 0)
            {
                do
                {
                    switch (guess)
                    {
                        case "Saitama":
                            Console.WriteLine("\n\nYou are correct! You win!");
                            guessed = true;
                            Console.Read();
                            return;
                            break;
                        default:
                            tries--;

                            if (tries == 0)
                            {
                                Console.WriteLine("\n\nYou are out of tries. You lose...");
                                Console.Read();
                                return;
                            }

                            Console.WriteLine("\n\nThat is incorrect. Try again. Tries left: " + tries + "\n");
                            Console.WriteLine("Type your guess...");
                            guess = Console.ReadLine();
                            break;
                    }

                }
                while (!guessed);
            }

        }
    }
}
