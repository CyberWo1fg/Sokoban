using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokoban
{
    public struct Place
    {
        public int x;
        public int y;

        public Place(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public enum Cell
    {
        none,
        wall,
        abox,
        done,
        here,
        user1,
        user2
    }
    static class Program
    {
       
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
