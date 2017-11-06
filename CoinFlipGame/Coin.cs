using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipGame
{
    public class Coin
    {
        private string coinOption = string.Empty;
        public string[] coinValue = { "Heads", "Tails" };

        public Coin()
        {
            coinOption = coinValue[new Random().Next(0, 2)];
        }

        public string GetCoinOption()
        {
            return coinOption;
        }
    }
}
