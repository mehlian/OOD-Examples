using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinGameLib
{
    public class CoinGame
    {
        private PlayerModel[] players = new PlayerModel[2];
        private CoinModel theCoin;

        /// <summary>
        /// Start new Coin Flipping Game for two players.
        /// </summary>
        public void StartGame()
        {
            string key = String.Empty;

            ShowGameRules();
            SetPlayerName();

            do
            {
                SetCoinOption();
                ShowResults();
                Console.WriteLine("Play again? Press Y for Yes.");
                key = Console.ReadKey().ToString();
            } while (String.Compare(key, "Y", true) == 0);

            Console.WriteLine("Goodbye!");
        }

        private void ShowGameRules()
        {
            Console.WriteLine("Welcome in Coin Game!");
            Console.WriteLine("Rules:");
            Console.WriteLine("1. Two players guess Coin side.");
            Console.WriteLine("2. The Coin is flipped.");
            Console.WriteLine("3. Correct guess wins.");
            Console.WriteLine("---------------------------------");
        }

        private void SetPlayerName()
        {
            for (int i = 1; i <= players.Count(); i++)
            {
                string name = String.Empty;

                do
                {
                    Console.WriteLine($"Please enter name for player {i}: ");
                    name = Console.ReadLine();
                } while (name.Length == 0);

                players[i].Name = name;
            }

        }

        private void SetCoinOption()
        {
            int playerIndex = new Random().Next(0, 2);
            int opponentIndex = playerIndex == 0 ? 1 : 0;
            CoinState coinOption = CoinState.None;

            do
            {
                Console.WriteLine($"{players[playerIndex].Name}, select coin's side by pressing:");
                Console.WriteLine("H for Heads or T for Tails.");

                string input = Console.ReadKey().ToString();

                if (String.Compare(input, "H", true) == 0)
                    coinOption = CoinState.Heads;
                else if (String.Compare(input, "T", true) == 0)
                    coinOption = CoinState.Tails;
                else
                    Console.WriteLine("Wrong key, please try again.");

            } while (coinOption == CoinState.None);

            players[playerIndex].CoinOption = coinOption;
            players[opponentIndex].CoinOption = coinOption == CoinState.Heads ? CoinState.Tails : CoinState.Heads;
        }

        private void ShowResults()
        {
            CoinState tossResult = theCoin.GetCoinOption();
            Console.WriteLine($"Toss result: {tossResult.ToString()}");

            if (players[0].DidPlayerWin(tossResult))
            {
                Console.WriteLine($"{players[0].Name} won with {players[0].CoinOption} pick!");
            }
            else
            {
                Console.WriteLine($"{players[1].Name} won with {players[1].CoinOption} pick!");
            }

        }
    }
}
