using System;

namespace CoinGameLib
{
    internal class CoinModel
    {
        internal CoinState GetCoinOption()
        {
            Console.WriteLine("\n\nTossing the coin...");

            // number 0 is Heads, number 1 is Tails.
            return new Random().Next(0, 2) == 0 ? CoinState.Heads : CoinState.Tails;
        }
    }
}
