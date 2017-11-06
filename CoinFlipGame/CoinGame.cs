using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipGame
{
    public class CoinGame
    {
        Player[] players = new Player[2];
        Coin theCoin = new Coin();

        public CoinGame(string player1Name, string player2Name)
        {
            players[0] = new Player(player1Name);
            players[1] = new Player(player2Name);
        }

        public void StartGame()
        {
            int randIndex = new Random().Next(0, 2);
            string playersPick = players[randIndex].GetRandCoinOption();

            int opponentsIndex = (randIndex == 0) ? 1 : 0;
            players[opponentsIndex].SetCoinOption(playersPick);

            string winningFlip = theCoin.GetCoinOption();

            players[0].DidPlayerWin(winningFlip);
            players[1].DidPlayerWin(winningFlip);
        }
    }
}
