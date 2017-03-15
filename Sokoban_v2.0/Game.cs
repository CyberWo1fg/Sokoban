using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokoban
{
    public enum GameMode
    {
        Local,
        Network,
        Editor
    }

    class Game
    {
        public Level currentLevel;
        public LevelFile levelReader;
        public GameControls[] controls;
        public int totalLevels;

        deShowItem ShowItem;
        deShowStat ShowStat;

        Cell[,] map;
        Cell[,] top;
        int placed;
        int totals;

        int w, h;
        public Place[] mouse = new Place[3];

        public GameMode mode;

        public Game(deShowItem ShowItem, deShowStat ShowStat, GameMode mode, int players, GameControls[] ctrls)
        {
            this.ShowItem = ShowItem;
            this.ShowStat = ShowStat;

            levelReader = new LevelFile(players);
            this.mode = mode;

            controls = ctrls;
        }

        public bool Init (int level_nr, out int width, out int height)
        {
            currentLevel = levelReader.LoadLevel(level_nr, out totalLevels);
            map = currentLevel.map;
            if (map == null)
            {
                width = 0;
                height = 0;
                return false;
            }

            width = w = map.GetLength(0);
            height = h = map.GetLength(1);
            top = new Cell[width, height];

            for (int x = 0; x < w; x++)
                for (int y = 0; y < h; y++)
                {
                    switch (map[x , y])
                    {
                        case Cell.none:
                            break;
                        case Cell.wall:
                            break;
                        case Cell.abox:
                            top[x, y] = Cell.abox;
                            map[x, y] = Cell.none;
                            break;
                        case Cell.done:
                            top[x, y] = Cell.abox;
                            map[x, y] = Cell.here;
                            break;
                        case Cell.here:
                            top[x, y] = Cell.none;
                            break;
                        case Cell.user1:
                            mouse[1] = new Place(x, y);
                            map[x, y] = Cell.none;
                            top[x, y] = Cell.user1;
                            break;
                        case Cell.user2:
                            mouse[2] = new Place(x, y);
                            map[x, y] = Cell.none;
                            top[x, y] = Cell.user2;
                            break;
                        default:
                            break;
                    }
                }

            //currentLevel.boxes = new PictureBox[currentLevel.width, currentLevel.height];
            return true;

        }

        private Image CellToPicture(Cell cell)
        {
            switch (cell)
            {
                case Cell.none: return Properties.Resources.none;
                case Cell.wall: return Properties.Resources.wall;
                case Cell.abox: return Properties.Resources.abox;
                case Cell.done: return Properties.Resources.done;
                case Cell.here: return Properties.Resources.here;
                case Cell.user1: return Properties.Resources.user1South;
                default: return Properties.Resources.none;
            }
        }
        public void ShowLevel(Level level)
        {
            placed = 0;
            totals = 0;
            currentLevel = level;
            for (int x = 0; x < currentLevel.width; x++)
                for (int y = 0; y < currentLevel.height; y++)
                {
                    ShowMapTop(x, y);
                    if (map[x, y] == Cell.here)
                    {
                        totals++;
                        if (top[x, y] == Cell.abox)
                            placed++;
                    }
                        
                }
            ShowStat(totals, placed);
        }

        public void ShowMapTop(int x, int y)
        {
            if (top[x, y] == Cell.none)
                ShowItem(new Place(x, y), map[x, y]);
            else
                if (top[x, y] == Cell.abox && map[x, y] == Cell.here)
                ShowItem(new Place(x, y), Cell.done);
            else
                ShowItem(new Place(x, y), top[x, y]);

        }

        public void Step(int userNum, int sx, int sy)
        {
            if (userNum < 1 || userNum > 2)
                return;
            Place place = new Place(mouse[userNum].x + sx, mouse[userNum].y + sy);

            if (!InRange(place))
                return;
            if (top[place.x, place.y] == Cell.none)
            {
                top[mouse[userNum].x, mouse[userNum].y] = Cell.none; ShowMapTop(mouse[userNum].x, mouse[userNum].y);
                top[place.x, place.y] = CellUser(userNum); ShowMapTop(place.x, place.y);
                mouse[userNum] = place;
            }

            if (top[place.x, place.y] == Cell.abox)
            {
                Place after = new Place(place.x + sx, place.y + sy);
                if (!InRange(after))
                    return;
                if (top[after.x, after.y] != Cell.none)
                    return;
                if (map[place.x, place.y] == Cell.here) placed--;
                if (map[after.x, after.y] == Cell.here) placed++;
                ShowStat(totals, placed);

                top[mouse[userNum].x, mouse[userNum].y] = Cell.none; ShowMapTop(mouse[userNum].x, mouse[userNum].y);
                top[place.x, place.y] = CellUser(userNum); ShowMapTop(place.x, place.y);
                top[after.x, after.y] = Cell.abox; ShowMapTop(after.x, after.y);
                mouse[userNum] = place;
            }
             
        }

        private Cell CellUser(int userNum)
        {
            if (userNum == 1)
                return Cell.user1;
            else
                return Cell.user2;
        }

        public bool InRange(Place place)
        {
            int x = place.x;
            int y = place.y;

            if (x < 0 || x >= w || y < 0 || y >= h)
                return false;
            if (map[x, y] == Cell.none)
                return true;
            if (map[x, y] == Cell.here)
                return true;
            return false;

        }

        public string SolveMouse(int User, Place target)
        {
            if (!InRange(target))
                return "";
            MouseSolver solver = new MouseSolver(map, top);
            return solver.MoveMouse(mouse[User], target);
            
        }

        public string SolveApple(int User, Place apple, Place target)
        {

            if (top[apple.x, apple.y] != Cell.abox)
                return "";
            if (!InRange(target))
                return "";

            AppleSolver solver = new AppleSolver(map, top);
            return solver.MoveApple(mouse[User], apple, target);

        }
    }

    public class GameControls
    {
        public Keys Up;
        public Keys Down;
        public Keys Left;
        public Keys Right;

        public GameControls(int userNumber, Keys u, Keys d, Keys l, Keys r)
        {
            Up = u;
            Down = d;
            Left = l;
            Right = r;            
        }

        public void setControlUp(Keys key)
        {
            Up = key;
        }
        public void setControlDown(Keys key)
        {
            Down = key;
        }
        public void setControlLeft(Keys key)
        {
            Left = key;
        }
        public void setControlRight(Keys key)
        {
            Right = key;
        }
    }
}
