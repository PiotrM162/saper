using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace tutorial2
{
    internal class TMainMenu
    {
        public static bool lvlSelected = false;
        public TMainMenu()
        {
            
        }

        public  void Selecting()
        {

            int lvl = 0;
            TDrawer.MenuDraw(lvl);
            while (!lvlSelected)
            {
                if (Console.KeyAvailable) 
                {
                    var key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (lvl != 0)
                            {
                                lvl--;
                                TDrawer.MenuDraw(lvl);
                                break;
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            if (lvl != 2)
                            {
                                lvl++;
                                TDrawer.MenuDraw(lvl);
                                break;
                            }
                            break;
                        case ConsoleKey.Enter:
                            lvlSelected = true;
                            break;
                    }
                }

            }
        }

/*        public void MenuDraw(int lvl)
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
        }*/


    }
}
