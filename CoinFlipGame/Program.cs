using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            CoinGame theCoinGame = new CoinGame("Mark", "Tom");

            string usersAnswer;

            do
            {
                theCoinGame.StartGame();

                Console.WriteLine("Play Again?");
                usersAnswer = Console.ReadLine();


            } while (String.Compare(usersAnswer,"y",true)==0);
        }

        static void Esse(IEnumerable<int> enumerator)
        {
            var a = enumerator.GetEnumerator();
        }
    }
    static class TestStat
    {



    }
}
