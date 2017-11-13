using System;
using CoinGameLib;

namespace CoinFlipGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICoinGame theGame = new CoinGame();
            Console.WriteLine(theGame.ShowGameRules());

            SetPlayersNames(theGame);
            StartGame(theGame);
        }

        private static void SetPlayersNames(ICoinGame game)
        {
            string[] name = new string[2];

            Console.WriteLine("Please enter name for player 1");
            name[0] = Console.ReadLine();
            Console.WriteLine("Please enter name for player 2");
            name[1] = Console.ReadLine();

            game.SetPlayersNames(name);
        }

        private static void StartGame(ICoinGame game)
        {
            string key = String.Empty;

            do
            {
                string pickedPlayer = game.PickPlayerAtRandom();
                bool isInputValid = false;

                do
                {
                    Console.WriteLine($"\n{pickedPlayer}, select coin's side by pressing");
                    Console.WriteLine("H for Heads or T for Tails.");

                    string input = Console.ReadKey().KeyChar.ToString();

                    if (String.Compare(input, "H", true) == 0)
                    {
                        game.SetCoinOption(CoinState.Heads);
                        isInputValid = true;
                    }
                    else if (String.Compare(input, "T", true) == 0)
                    {
                        game.SetCoinOption(CoinState.Tails);
                        isInputValid = true;
                    }
                    else
                    {
                        Console.WriteLine("\nWrong key, please try again.");
                    }

                } while (!isInputValid);

                Console.WriteLine();
                Console.WriteLine(game.TossTheCoinAndShowResults());

                Console.WriteLine("\nPlay again? Press Y for Yes.");
                key = Console.ReadKey().KeyChar.ToString();

            } while (String.Compare(key, "Y", true) == 0);
        }
    }
}
