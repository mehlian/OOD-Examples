using System;

namespace CoinGameLib
{
    internal class CoinModel
    {
        internal CoinState GetCoinOption()
        {
            return new Random().Next(0, 2) == 0 ? CoinState.Heads : CoinState.Tails;
        }
    }
}
