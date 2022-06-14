using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial2
{
    internal class TGame
    {
        public TGame()
        {
            bool IsRunning = true;
            TMainMenu menu = new TMainMenu();
            if (!TMainMenu.lvlSelected)
            {
                menu.Selecting();
            }
            else
            { 
                do
                {

                } while (IsRunning);
            }
        }
    }
}
