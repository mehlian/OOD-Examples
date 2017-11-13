namespace CoinGameLib
{
    public interface ICoinGame
    {
        /// <summary>
        /// Displays game's rules
        /// </summary>
        /// <returns></returns>
        string ShowGameRules();
        /// <summary>
        /// Sets names for players
        /// </summary>
        /// <param name="name">Array oy player's names</param>
        void SetPlayersNames(string[] name);
        /// <summary>
        /// Picks one player at random for next guess
        /// </summary>
        /// <returns></returns>
        string PickPlayerAtRandom();
        /// <summary>
        /// Sets prediction of coin toss, given by a player
        /// </summary>
        /// <param name="coinState">Prediction of coin's side</param>
        void SetCoinOption(CoinState coinState);
        /// <summary>
        /// Gets coin's toss result
        /// </summary>
        /// <returns></returns>
        string TossTheCoinAndShowResults();
    }
}
