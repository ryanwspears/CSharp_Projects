using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcme to the Grand Hotel Casino! Let's start by telling me your name...");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name + "! How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Awesome! Would you like to join a game of 21?");
            string answer = Console.ReadLine().ToLower();

            if(answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(name, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isPlaying = true;

                while(player.isPlaying && player.Balance > 0)
                {
                    game.Play();
                }

                game -= player;
                Console.WriteLine("Thank you for playing!");
            }

            Console.WriteLine("Feel free to look around the casino. Goodbye, for now!");
            Console.Read();
        }
    }
}
