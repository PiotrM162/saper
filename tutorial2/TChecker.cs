using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial2
{
    internal class TChecker
    {

        public static bool CheckWin(TFields[,] fields)
        {
            int count = 0;
            for (int i = 0; i < TGenerator.x; i++)
            {
                for (int j = 0; j < TGenerator.y; j++)
                {
                    if (fields[i, j].IsMine || fields[i, j].IsChecked)
                    {
                        count++;
                    }
                }
            }
            if (count >= TGenerator.x * TGenerator.y)
            { 
                return true;
            }
            return false;
        }

        public static bool IsDefeted(TFields[,] fields)
        {
            return fields[TGame.Positionx, TGame.Positiony].IsMine;
        }

        public static void Check(int x, int y)
        {
            if (x < 0 || x > TGenerator.x-1) return;
            if (y < 0 || y > TGenerator.y-1) return;
            if (TGame.fields[x, y].IsChecked) return;

            TChecker c = new TChecker();
            
            char mask = c.CheckNear(x, y);
            TGame.fields[x, y].displayed = mask;
            if (mask != ' ')
            { 
                TGame.fields[x,y].displayed = mask;
                return;
            }
            if(mask == ' ')
            {
                Check(x - 1, y);
                Check(x + 1, y);
                Check(x, y - 1);
                Check(x, y + 1);
                Check(x - 1, y - 1);
                Check(x + 1, y - 1);
                Check(x - 1, y + 1);
                Check(x + 1, y + 1);
                return;
            }

        }

public char CheckNear(int x, int y)
        {
            int NumberOfMines = 0;

            if (x > 0 && y > 0)
            { 
                if(TGame.fields[x-1,y-1].IsMine) NumberOfMines++; //lewy górny róg
            }

            if (y > 0)
            {
                if (TGame.fields[x, y - 1].IsMine) NumberOfMines++; //góra
            }

            if (x < TGenerator.x-1 && y > 0)
            {
                if (TGame.fields[x + 1, y - 1].IsMine) NumberOfMines++; //prawy górny róg
            }

            if (x < TGenerator.x-1 )
            {
                if (TGame.fields[x + 1, y].IsMine) NumberOfMines++; //prawy 
            }

            if (x < TGenerator.x-1 && y < TGenerator.y-1)
            {
                if (TGame.fields[x + 1, y +1].IsMine) NumberOfMines++; //prawy dolny róg
            }

            if ( y < TGenerator.y-1)
            {
                if (TGame.fields[x, y +1].IsMine) NumberOfMines++; //dolny
            }

            if (x > 0 && y < TGenerator.y-1)
            {
                if (TGame.fields[x -1, y +1].IsMine) NumberOfMines++; //lewy dolny róg
            }

            if (x > 0 )
            {
                if (TGame.fields[x - 1, y].IsMine) NumberOfMines++; //lewy 
            }


            TGame.fields[x,y].IsChecked = true;

            if (NumberOfMines == 0) return ' ';
            if (NumberOfMines == 1) return '1';
            if (NumberOfMines == 2) return '2';
            if (NumberOfMines == 3) return '3';
            if (NumberOfMines == 4) return '4';
            if (NumberOfMines == 5) return '5';
            if (NumberOfMines == 6) return '6';
            if (NumberOfMines == 7) return '7';
            if (NumberOfMines == 8) return '8';

            return (char)NumberOfMines;
        }



    }
}
