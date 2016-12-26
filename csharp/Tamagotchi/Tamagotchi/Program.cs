using GameLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Program
    {
        static void Run(Game game)
        {
            game.MainLoop();
        }

        static void Main(string[] args)
        {
            //TamagotchiGame game = new TamagotchiGame();
            //Game game = new TamagotchiGame();
            Run(new TamagotchiGame());

        }
    }
}
