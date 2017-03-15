using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sokoban
{
    public class LevelFile
    {
        public int mode;
        string filename;

        public int levelsTotal = -1;

        public LevelFile(int mode)
        {
            this.mode = mode;
            if (mode == 0)
                filename = "levels.txt";
            else
                filename = "levels2.txt";
        }

        public Level LoadLevel(int level_nr, out int total)
        {
            Level level = null;
            Cell[,] cells;
            total = -1;
            string[] lines;
            //string[] nl = { "\r\n" };

            //if (mode == 1)
            //    lines = Properties.Resources.levels.Split(nl, StringSplitOptions.None);
            //else
            //    lines = Properties.Resources.levels2.Split(nl, StringSplitOptions.None);
            try
            {
                lines = File.ReadAllLines(filename);
            }
            catch
            {
                return level;
            }
            
            int curr = 0;
            int curr_level_nr = 0;
            int width;
            int height;
            while (curr < lines.Length)
            {
                ReadLevelHeader(lines[curr], out curr_level_nr, out width, out height);
                if (level_nr == curr_level_nr)
                {
                    cells = new Cell[width, height];
                    for (int y = 0; y < height; y++)
                        for (int x = 0; x < width; x++)
                            cells[x, y] = CharToCell(lines[curr + 1 + y][x]);
                    level = new Level(curr_level_nr, width, height, cells);
                }

                curr += 1 + height;
            }
            levelsTotal = curr_level_nr;
            total = curr_level_nr;

            //if (level == null)
            //{
            //    Array.Resize(ref lines, lines.Length + 6);
            //    lines[curr] = String.Format("{0} {1} {1}", curr_level_nr + 1, 5);
            //    for (int i = 0; i < 5; i++)
            //        lines[curr + i + 1] = new String(' ', 5);
            //    File.WriteAllLines(filename, lines);
            //    return LoadLevel(curr_level_nr + 1, out total);
            //}
            return level;
        }

        public bool DeleteLevel(int level_nr)
        {
            string[] lines;
            try
            {
                lines = File.ReadAllLines(filename);
            }
            catch
            {
                return false;
            }
            int curr = 0;
            int curr_level_nr;
            int width = 0;
            int height = 0;
            while (curr < lines.Length)
            {
                ReadLevelHeader(lines[curr], out curr_level_nr, out width, out height);
                if (level_nr == curr_level_nr)
                    break;
                else
                    curr += 1 + height;
            }
            int oldLength = lines.Length;
            int delta = -(height + 1);
            int newLength = lines.Length + delta;

            for (int z = curr; z < newLength; z++)
                lines[z] = lines[z - delta];
            Array.Resize(ref lines, newLength);

            curr = 0;
            int lvl = 1;
            width = 0;
            height = 0;
            while (curr < newLength)
            {
                ReadLevelHeader(lines[curr], out curr_level_nr, out width, out height);

                if (curr_level_nr != lvl)
                {
                    lines[curr] = String.Format("{0} {1} {2}", lvl, width, height);
                    curr += 1 + height;
                    lvl += 1;
                }
            }
            try
            {
                File.WriteAllLines(filename, lines);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public Cell[,] LoadLevelCells(int level_nr)
        {
            Cell[,] cells = null;
            string[] lines;
            //string[] nl = { "\r\n" };

            //if (mode == 1)
            //    lines = Properties.Resources.levels.Split(nl, StringSplitOptions.None);
            //else
            //    lines = Properties.Resources.levels2.Split(nl, StringSplitOptions.None);

            try
            {
                lines = File.ReadAllLines(filename);
            }
            catch
            {
                return cells;
            }

            int curr = 0;
            int curr_level_nr = 0;
            int width;
            int height;
            while (curr < lines.Length)
            {
                ReadLevelHeader(lines[curr], out curr_level_nr, out width, out height);
                if (level_nr == curr_level_nr)
                {
                    cells = new Cell[width, height];
                    for (int y = 0; y < height; y++)
                        for (int x = 0; x < width; x++)
                            cells[x, y] = CharToCell(lines[curr + 1 + y][x]);
                    
                }

                curr += 1 + height;
            }
            levelsTotal = curr_level_nr;

            if (cells == null)
            {
                Array.Resize(ref lines, lines.Length + 6);
                lines[curr] = String.Format("{0} {1} {1}", curr_level_nr + 1, 5);
                for (int i = 0; i < 5; i++)
                    lines[curr + i + 1] = new String(' ', 5);
                File.WriteAllLines(filename, lines);
                return LoadLevelCells(curr_level_nr + 1);
            }
            return cells;

        }

        public Cell CharToCell(char x)
        {
            switch (x)
            {
                case ' ': return Cell.none;
                case '#': return Cell.wall;
                case '0': return Cell.abox;
                case '.': return Cell.here;
                case 'C': return Cell.done;
                case '1': return Cell.user1;
                case '2': return Cell.user2;
                default: return Cell.none;
            }
        }

        public char CellToChar(Cell c)
        {
            switch (c)
            {
                case Cell.none: return ' '; 
                case Cell.wall: return '#'; 
                case Cell.abox: return '0'; 
                case Cell.done: return 'C'; 
                case Cell.here: return '.';
                case Cell.user1: return '1';
                case Cell.user2: return '2';
                default: return ' ';
            }

        }

        private void ReadLevelHeader(string line, out int level_nr, out int width, out int height)
        {
            string[] parts = line.Split();
            level_nr = 0;
            width = 0;
            height = 0;
            if (parts.Length != 3)
                return;
            int.TryParse(parts[0], out level_nr);
            int.TryParse(parts[1], out width);
            int.TryParse(parts[2], out height);

        }

        public void SaveLevel(int level_nr, Cell[,] cells)
        {
            string[] lines;
            try
            {
                lines = File.ReadAllLines(filename);
            }
            catch
            {
                return;
            }
            int curr = 0;
            int curr_level_nr;
            int width = 0;
            int height = 0;
            while (curr < lines.Length)
            {
                ReadLevelHeader(lines[curr], out curr_level_nr, out width, out height);
                if (level_nr == curr_level_nr)
                    break;
                else
                    curr += 1 + height;
            }

            int oldLength = lines.Length;
            int delta = cells.GetLength(1) - height;
            int newLength = oldLength + delta;
            
            if (newLength > lines.Length)
            {
                Array.Resize(ref lines, newLength);
                for (int z = newLength - 1; z > curr + delta; z--)
                    lines[z] = lines[z - delta];
            }
            if (newLength < oldLength)
            { 
                for (int z = curr; z < newLength; z++)
                    lines[z] = lines[z - delta];
                Array.Resize(ref lines, newLength);
            }
            int w = cells.GetLength(0);
            int h = cells.GetLength(1);

            lines[curr] = String.Format("{0} {1} {2}", level_nr, w, h);
            for (int y = 0; y < h; y++)
            {
                lines[curr + 1 + y] = "";
                for (int x = 0; x < w; x++)
                    lines[curr + 1 + y] += CellToChar(cells[x, y]).ToString();
            }

            try
            {
                File.WriteAllLines(filename, lines);
            }
            catch
            { 
                return;
            }
        }

    }
}
