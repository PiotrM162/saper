using System;

namespace tutorial2
{
    internal class TGame
    {
        public static bool IsMinesSet = false;
        public static bool IsRunning = true;
        public static bool IsDefeted = false;
        public static bool IsWin = false;

        public static int Positiony = 0;
        public static int Positionx = 0;

        public static TFields[,] fields;

        public TGame()
        {
            
            TMainMenu menu = new TMainMenu();

            menu.Selecting();
            TGenerator.Generator(TMainMenu.lvl);
            IsOnPosition();
            TDrawer.board(fields);
            do
            {
                movment();

                if (TChecker.CheckWin(fields)) IsRunning = false;

            } while (IsRunning);


            if (IsDefeted)
            {
                TDrawer.Defet();
            }
            else if (IsWin)
            { 
                TDrawer.Win();
            }
        }

        public void movment()
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (Positiony != 0)
                        {
                            Console.Clear();
                            Positiony--;
                            IsOnPosition();
                            TDrawer.board(TGame.fields);
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (Positiony != TGenerator.y-1)
                        {
                            Console.Clear();
                            Positiony++;
                            IsOnPosition();
                            TDrawer.board(TGame.fields);
                        }
                         break;
                    case ConsoleKey.DownArrow:
                        if (Positionx != TGenerator.x-1)
                        {
                            Console.Clear();
                            Positionx++;
                            IsOnPosition();
                            TDrawer.board(TGame.fields);
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (Positionx != 0)
                        {
                            Console.Clear();
                            Positionx--;
                            IsOnPosition();
                            TDrawer.board(TGame.fields);
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (!IsMinesSet)
                        {
                            TGenerator.MinesSet(fields);
                            TChecker.Check(Positionx, Positiony);
                            IsWin = true;
                        }
                        else
                        {
                            if (TChecker.IsDefeted(fields))
                            {
                                IsRunning = false;
                                IsDefeted = true;
                                break;
                            }
                            else
                            {
                                TChecker.Check(Positionx, Positiony);
                            }
                        }
                        Console.Clear();
                        TDrawer.board(fields);
                        break;
                }
            }
        }
        public void IsOnPosition()
        {
            for (int i = 0; i < TGenerator.x; i++)
            {
                for (int j = 0; j < TGenerator.y; j++)
                {
                    TGame.fields[i, j].IsSelected = false;
                }
            }

            TGame.fields[Positionx, Positiony].IsSelected = true;
        }

    }
}
