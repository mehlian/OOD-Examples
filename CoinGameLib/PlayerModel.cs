using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinGameLib
{
    internal class PlayerModel
    {
        internal string Name { get; set; } = String.Empty;
        internal CoinState CoinOption { get; set; } = CoinState.None;

        internal bool DidPlayerWin(CoinState winningFlip)
        {
            return winningFlip == CoinOption ? true : false;
        }
    }
}
