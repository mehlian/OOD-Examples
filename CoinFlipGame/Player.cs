using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipGame
{
    public class Player
    {
        private string name = string.Empty;
        private string coinOption = string.Empty;

        public string[] coinValue = { "Heads", "Tails" };

        public Player(string newName)
        {
            name = newName;
        }

        public string GetCoinOption()
        {
            return coinOption;
        }

        public void SetCoinOption(string opponentFlip)
        {
            coinOption = (String.Compare(opponentFlip, "Heads", true) == 0) ? "Tails" : "Heads";
        }

        public string GetRandCoinOption()
        {
            return coinOption = coinValue[new Random().Next(0, 2)];
        }

        public void DidPlayerWin(string winningFlip)
        {
            if (coinOption == winningFlip)
            {
                Console.WriteLine(name + " won with a flip of " + coinOption);
            }
            else
            {
                Console.WriteLine(name + " lost with a flip of " + coinOption);
            }
        }
    }
}
