using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson15
{
    class Program
    {
        static void Main(string[] args)
        {
            Game chess = new Game();

            Game bestGame = new Game("Mygame", 5.5f);

            Game sudoku = new Game("Sudoku", "Japan");

            Game hockey = new Game("hockey", 12, 10, "Canada");

            PrintGame(hockey, hockey.TellMeHowManyPlayers());
        }

        private static void PrintGame(Game game, int tellMeHowManyPlayers)
        {
            Console.WriteLine(game);
            Console.WriteLine($" Tell Me How Many Players {tellMeHowManyPlayers}");
        }

    }
}
