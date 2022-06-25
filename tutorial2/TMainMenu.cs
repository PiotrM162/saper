using System;

namespace tutorial2
{
    internal class TMainMenu
    {
        public static bool lvlSelected = false;
        public static int lvl = 0;
        public TMainMenu()
        {
            
        }

        public  void Selecting()
        {
            TDrawer.MenuDraw(lvl);
            while (!lvlSelected)
            {
                if (Console.KeyAvailable) 
                {
                    var key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (TMainMenu.lvl != 0)
                            {
                                TMainMenu.lvl--;
                                TDrawer.MenuDraw(lvl);
                                break;
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            if (TMainMenu.lvl != 2)
                            {
                                TMainMenu.lvl++;
                                TDrawer.MenuDraw(lvl);
                                break;
                            }
                            break;
                        case ConsoleKey.Enter:
                            Console.Clear();
                            lvlSelected = true;
                            break;
                    }
                }

            }
        }
    }
}
