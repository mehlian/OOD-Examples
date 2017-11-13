using System;
using System.Linq;
using System.Text;

namespace CoinGameLib
{
    public class CoinGame : ICoinGame
    {
        private PlayerModel[] players = new PlayerModel[2];
        private CoinModel theCoin = new CoinModel();
        private int pickedPlayer = 0;

        /// <summary>
        /// Starts new coin flip game for two players
        /// </summary>
        public CoinGame()
        {
            players[0] = new PlayerModel();
            players[1] = new PlayerModel();
        }

        /// <summary>
        /// Displays game's rules
        /// </summary>
        /// <returns></returns>
        public string ShowGameRules()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Welcome to the Coin Game!\n");
            sb.Append("Rules:\n");
            sb.Append("1. One player guess Coin's side, other gets opposite.\n");
            sb.Append("2. The Coin is tossed.\n");
            sb.Append("3. If player picked correct side - wins,\n");
            sb.Append("   if not, his opponent wins.\n");
            sb.Append("---------------------------------\n");
            return sb.ToString();
        }

        /// <summary>
        /// Sets names for players
        /// </summary>
        /// <param name="name">Array oy player's names</param>
        public void SetPlayersNames(string[] name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                players[i].Name = name[i];
            }
        }

        /// <summary>
        /// Picks one player at random for next guess
        /// </summary>
        /// <returns></returns>
        public string PickPlayerAtRandom()
        {
            pickedPlayer = new Random().Next(0, 2);
            return players[pickedPlayer].Name;
        }

        /// <summary>
        /// Sets prediction of coin toss, given by a player
        /// </summary>
        /// <param name="coinState">Prediction of coin's side</param>
        public void SetCoinOption(CoinState coinState)
        {
            int opponent = pickedPlayer == 0 ? 1 : 0;
            players[pickedPlayer].CoinOption = coinState;
            players[opponent].CoinOption = coinState == CoinState.Heads ? CoinState.Tails : CoinState.Heads;
        }

        /// <summary>
        /// Gets coin's toss result
        /// </summary>
        /// <returns></returns>
        public string TossTheCoinAndShowResults()
        {
            CoinState tossResult = theCoin.GetCoinOption();
            if (players[0].DidPlayerWin(tossResult))
            {
                return $"{players[0].Name} won with {players[0].CoinOption} pick!";
            }
            else
            {
                return $"{players[1].Name} won with {players[1].CoinOption} pick!";
            }
        }
    }
}
