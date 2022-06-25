using System;

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

        public static void board(TFields[,] fields)
        {
            for (int i = 0; i < TGenerator.x; i++)
            {
                for (int j = 0; j < TGenerator.y; j++)
                {
                    if (fields[i, j].IsSelected)
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.Write(" " + fields[i, j].displayed + " ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else Console.Write(" " + fields[i, j].displayed + " ");
                }
            Console.WriteLine();
            }
        }

    }
}
