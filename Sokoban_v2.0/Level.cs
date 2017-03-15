using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokoban
{
    public class Level
    {
        public Cell[,] map;
        public Cell[,] top;

        public int number, width, height;
        public int boxCounter, placeCounter, doneCounter;
        public PictureBox[,] boxes;

        public int userX, userY;

        public Level (int n, int w, int h, Cell[,] cells)
        {
            number = n;
            width = w;
            height = h;
            map = cells;
            RecalcStats();
        }

        public void RecalcStats()
        {
            userX = 0;
            userY = 0;
            boxCounter = 0;
            placeCounter = 0;
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    if (map[x, y] == Cell.abox || map[x, y] == Cell.done)
                        boxCounter++;
                    if (map[x, y] == Cell.here || map[x, y] == Cell.done)
                        placeCounter++;
                    if (map[x, y] == Cell.done)
                        doneCounter++;
                    if (map[x, y] == Cell.user1)
                    {
                        userX = x;
                        userY = y;
                    }
                }
        }

        private void ResizeLevel(int w, int h)
        {
            Cell[,] newMap = new Cell[w, h];
            for (int x = 0; x < Math.Min(w, width); x++)
                for (int y = 0; y < Math.Min(h, height); y++)
                    newMap[x, y] = map[x, y];

            width = w;
            height = h;
            RecalcStats();
        }

        private string IsGoodLevel()
        {
            string errorText = "";

            if (userX == 0 && userY == 0)
                errorText += "Нужно указать начальное место игрока\n";
            if (boxCounter == 0)
                errorText += "Не обнаружено ни одного монумента\n";
            if (placeCounter == 0)
                errorText += "Не обнаружено ни одного места активации монумента\n";
            if (boxCounter != placeCounter)
                errorText += "Количество монументов должно соответствовать количеству мест для них\n";
            
            return errorText;
        }
    }
}
