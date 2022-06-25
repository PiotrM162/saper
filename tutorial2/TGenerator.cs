using System;

namespace tutorial2
{
    internal class TGenerator
    {
        public static int x = 0;
        public static int y = 0;
        public static int NumberOfMines = 0;
        public static void Generator(int lvl)
        {
            if (lvl == 0) { TGenerator.x = 8; TGenerator.y = 8; TGenerator.NumberOfMines = 10; };
            if (lvl == 1) { TGenerator.x = 16; TGenerator.y = 16; TGenerator.NumberOfMines = 40; };
            if (lvl == 2) { TGenerator.x = 16; TGenerator.y = 30; TGenerator.NumberOfMines = 99; };

            TFields[,] fields = new TFields[x,y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    fields[i, j] = new TFields();
                }
            }
            TGame.fields = fields;
        }

        public static void MinesSet(TFields[,] fields)
        { 
            Random rand = new Random(0);
            int MineCount = 0;
            do
            {
                int xOfMine = rand.Next(0, TGenerator.x);
                int yOfMine = rand.Next(0, TGenerator.y);
                if ((fields[xOfMine, yOfMine].IsSelected == false) || (fields[xOfMine, yOfMine].IsMine == false))
                {
                    fields[xOfMine, yOfMine].IsMine = true;
                    MineCount++;
                }
            } while (MineCount < TGenerator.NumberOfMines);
            TGame.IsMinesSet = true;

        }
    }
}
