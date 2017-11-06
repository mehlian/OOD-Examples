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
            string usersAnswer;

            do
            {
                new CoinGame("Mark", "Tom").StartGame();

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
