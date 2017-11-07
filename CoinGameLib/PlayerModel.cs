using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinGameLib
{
    internal class PlayerModel
    {
        internal string Name { get; set; }
        internal CoinState CoinOption { get; set; }

        internal bool DidPlayerWin(CoinState winningFlip)
        {
            return winningFlip == CoinOption ? true : false;
        }
    }
}
