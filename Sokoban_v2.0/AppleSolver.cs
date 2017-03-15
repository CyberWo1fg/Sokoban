using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{

    class AppleSolver
    {
        List<Dirs> Directions;
        Cell[,] map;
        Cell[,] top;
        int w, h;

        public struct Brain
        {
            public Place mouse;
            public Place apple;
            public string path;

            public Brain(Place mouse, Place apple, string p)
            {

                this.mouse = mouse;
                this.apple = apple;
                this.path = p;
            }
        }

        public struct Dirs
        {
            public int x;
            public int y;
            public string path;

            public Dirs(int x, int y, string path)
            {
                this.x = x;
                this.y = y;
                this.path = path;
            }

        }

        public AppleSolver(Cell[,] map, Cell[,] top)
        {
            this.map = map;
            this.top = top;
            w = map.GetLength(0);
            h = map.GetLength(1);

            Directions = new List<Dirs>();
            Directions.Add(new Dirs(-1, 0, "4"));
            Directions.Add(new Dirs(1, 0, "6"));
            Directions.Add(new Dirs(0, 1, "2"));
            Directions.Add(new Dirs(0, -1, "8"));
        }

        public string MoveApple(Place mouse, Place start, Place finish)
        {// mouse - мышка, start - яблоко , finish - норка

            if (start.x == finish.x && start.y == finish.y)
                return "";
            top[start.x, start.y] = Cell.none;

            bool[,,,] visited = new bool[w, h, w, h];
            Queue<Brain> queue = new Queue<Brain>();
            //Dictionary<MouseApple, bool> visited = new Dictionary<MouseApple, bool>();

            queue.Clear();
            //visited.Clear();

            Brain brain;
            brain.mouse = mouse;
            brain.apple = start;
            brain.path = "";

            Place newMouse;
            Place newApple;

            queue.Enqueue(brain);

            while (queue.Count > 0)
            {
                brain = queue.Dequeue();
                foreach (Dirs side in Directions)
                {
                    newMouse.x = brain.mouse.x + side.x;
                    newMouse.y = brain.mouse.y + side.y;

                    if (!InRange(newMouse))
                        continue;

                    if (newMouse.x == brain.apple.x && newMouse.y == brain.apple.y)
                    {
                        newApple.x = newMouse.x + side.x;
                        newApple.y = newMouse.y + side.y;
                        if (!InRange(newApple))
                            continue;

                    }
                    else
                        newApple = brain.apple;

                    if (visited[newMouse.x, newMouse.y, newApple.x, newApple.y])
                        continue;
                    visited[newMouse.x, newMouse.y, newApple.x, newApple.y] = true;

                    Brain step = new Brain(newMouse, newApple, brain.path + side.path);
                    if (newApple.x == finish.x && newApple.y == finish.y)
                    {
                        top[start.x, start.y] = Cell.abox;
                        return step.path;
                    }

                    queue.Enqueue(step);
                }
            }
            top[start.x, start.y] = Cell.abox;

            return "-";
        }

        public bool InRange(Place place)
        {
            if (place.x < 0 || place.x >= w || place.y < 0 || place.y >= h)
                return false;
            if (map[place.x, place.y] == Cell.none &&
                (top[place.x, place.y] == Cell.none ||
                 top[place.x, place.y] == Cell.user1))
                return true;
            if (map[place.x, place.y] == Cell.here &&
                (top[place.x, place.y] == Cell.none ||
                 top[place.x, place.y] == Cell.user1))
                return true;

            return false;
        }
    }
}
