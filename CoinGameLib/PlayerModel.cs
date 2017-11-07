﻿using System;

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
