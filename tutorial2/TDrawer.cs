using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial2
{
    internal class TDrawer
    {

        public static void MenuDraw(int lvl)
        {
            Console.Clear();
            if (lvl == 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("easy");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else Console.WriteLine("easy");

            if (lvl == 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Medium");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else Console.WriteLine("Medium");

            if (lvl == 2)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Hard");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else Console.WriteLine("Hard");
        }

    }
}
