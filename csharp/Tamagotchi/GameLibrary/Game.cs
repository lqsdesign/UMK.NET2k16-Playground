using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public abstract class Game
    {
        public void MainLoop()
        {
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Update();
            }
        }

        public abstract void Update(ConsoleKeyInfo keyInfo);



    }
}
