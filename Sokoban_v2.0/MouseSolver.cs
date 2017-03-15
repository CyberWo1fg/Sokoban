using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
 
    class MouseSolver
    {
        Cell [,] map;
        Cell [,] top;       

        List<Brain> Directions;

        int w, h;

        public struct Brain
        {
            public int x;
            public int y;
            public string path;

            public Brain(int x, int y, string p)
            {

                this.x = x;
                this.y = y;
                this.path = p;
            }

            public Brain(Place place, string p)
            {

                this.x = place.x;
                this.y = place.y;
                this.path = p;
            }
        }

        public MouseSolver(Cell[,] map, Cell[,] top)
        {
            this.map = map;
            this.top = top;
            w = map.GetLength(0);
            h = map.GetLength(1);

            Directions = new List<Brain>();
            Directions.Add(new Brain(-1, 0, "4"));
            Directions.Add(new Brain(1, 0, "6"));
            Directions.Add(new Brain(0, 1, "2"));
            Directions.Add(new Brain(0, -1, "8"));
        }

        public string MoveMouse(Place start, Place finish)
        {
            Queue<Brain> queue = new Queue<Brain>();
            List<Place> visited = new List<Place>();

            queue.Clear();
            visited.Clear();

            Brain brain;
            brain.x = start.x;
            brain.y = start.y;
            brain.path = "";

            Place place;

            queue.Enqueue(brain);

            while (queue.Count > 0)
            {
                brain = queue.Dequeue();
                foreach (Brain side in Directions)
                {
                    place.x = brain.x + side.x;
                    place.y = brain.y + side.y;
                    if (!InRange(place))
                        continue;

                    if (visited.Contains(place))
                        continue;
                    visited.Add(place);

                    Brain step = new Brain(place, brain.path + side.path);
                    queue.Enqueue(step);

                    if (place.Equals(finish))
                        return step.path;

                    queue.Enqueue(step);
                }
            }
            return "";
        }

        public bool InRange(Place place)
        {
            if (place.x < 0 || place.x >= w || place.y < 0 || place.y >= h)
                return false;
            if (map[place.x, place.y] == Cell.none &&
                top[place.x, place.y] == Cell.none)
                return true;            
            if (map[place.x, place.y] == Cell.here &&
                top[place.x, place.y] == Cell.none)
                return true;
            return false;
        }

    }
}
