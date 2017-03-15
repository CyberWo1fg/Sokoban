using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokoban
{
    public delegate void deShowItem(Place place, Cell item);
    public delegate void deShowStat(int placed, int totals);
    public delegate void deLog(string text);
    public delegate void deLogging();
    public delegate void deRecv(string data);

    public partial class MazeForm : Form
    {
        Level level;
        Game game;
        PictureBox[,] boxes;
        public bool fastMoves = true;
        int last_level_nr;
        string path = "";
        //bool Selecting = false;
        //int selStartX, selStartY, selFinX, selFinY;
        int width, height;
        Place apple = new Place(-1, -1);
        PhoneSock phone;
        int myUser;
        int otUser;
        //Rectangle selRect;
        //Point orig;
        //Pen pen = new Pen(Brushes.Blue, 0.8f) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };

        public MazeForm(int player, GameControls[] ctrls)
        {
            Init(player, GameMode.Local, ctrls);
        }

        public MazeForm(int player, GameControls[] ctrls, string port)
        {
            phone = new PhoneSockServer(int.Parse(port));
            phone.Recv += Recv;
            phone.Start();
            Init(player, GameMode.Network, ctrls);
        }

        public MazeForm(int player, GameControls[] ctrls, string host, string port)
        {
            phone = new PhoneSockClient(host, int.Parse(port));
            phone.Recv += Recv;
            phone.Start();
            Init(player, GameMode.Network, ctrls);
        }

        public void Init(int player, GameMode mode, GameControls[] ctrls)
        {
            InitializeComponent();
            last_level_nr = 1;
            game = new Game(ShowItem, ShowStats, mode, player - 1, ctrls);
            OpenLevel(1);
            
            myUser = 1;
            otUser = 2;
        }

        private void OpenLevel(int number)
        {
            if (number < 1 || number > last_level_nr)
                return;
            if (!game.Init(number, out width, out height))
            {
                this.DialogResult = DialogResult.OK;
                return;
            }
            level = game.currentLevel;
            InitPictures();
            game.ShowLevel(level);
        }

        private void btnNextLevel_Click(object sender, EventArgs e)
        {
            if (game.mode == GameMode.Network && !phone.Send("11"))
                return;
            OpenLevel(level.number + 1);
        }

        private void btnPrevLevel_Click(object sender, EventArgs e)
        {
            if (game.mode == GameMode.Network && !phone.Send("12"))
                return;
            OpenLevel(level.number - 1);
        }

        private void MazeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (path != "")
            {
                path = "";
                return;
            }

            if (e.KeyCode == game.controls[1].Up && (game.mode == GameMode.Network && phone.Send("8") || game.mode == GameMode.Local))
            {
                game.Step(myUser, 0, -1);
                ChangePic(myUser, '8');
            }
            if (e.KeyCode == game.controls[1].Left && (game.mode == GameMode.Network && phone.Send("4") || game.mode == GameMode.Local))
            {
                game.Step(myUser, -1, 0);
                ChangePic(myUser, '4');
            }
            if (e.KeyCode == game.controls[1].Down && (game.mode == GameMode.Network && phone.Send("2") || game.mode == GameMode.Local))
            {
                game.Step(myUser, 0, 1);
                ChangePic(myUser, '2');
            }
            if (e.KeyCode == game.controls[1].Right && (game.mode == GameMode.Network && phone.Send("6") || game.mode == GameMode.Local))
            {
                game.Step(myUser, 1, 0);
                ChangePic(myUser, '6');
            }
            if (e.KeyCode == game.controls[2].Up && game.mode != GameMode.Network)
            {
                game.Step(otUser, 0, -1);
                ChangePic(otUser, '8');
            }
            if (e.KeyCode == game.controls[2].Left && game.mode != GameMode.Network)
            {
                game.Step(otUser, -1, 0);
                ChangePic(otUser, '4');
            }
            if (e.KeyCode == game.controls[2].Down && game.mode != GameMode.Network)
            {
                game.Step(otUser, 0, 1);
                ChangePic(otUser, '2');
            }
            if (e.KeyCode == game.controls[2].Right && game.mode != GameMode.Network)
            {
                game.Step(otUser, 1, 0);
                ChangePic(otUser, '6');
            }
            
            if (e.KeyCode == Keys.Escape && game.mode == GameMode.Network && phone.Send("0"))
                RestartLevel();
            //switch (e.KeyCode)
            //{
            //    //case game.controls[1].Up : if (game.mode == GameMode.Network && !phone.Send("8")) return; game.Step(myUser, 0, -1); ChangePic(myUser, '8'); break;
            //    case Keys.A: if (game.mode == GameMode.Network && !phone.Send("4")) return; game.Step(myUser, -1, 0); ChangePic(myUser, '4'); break;
            //    case Keys.S: if (game.mode == GameMode.Network && !phone.Send("2")) return; game.Step(myUser, 0, 1);  ChangePic(myUser, '2'); break;
            //    case Keys.D: if (game.mode == GameMode.Network && !phone.Send("6")) return; game.Step(myUser, 1, 0);  ChangePic(myUser, '6'); break;

            //    case Keys.NumPad8: if (game.mode == GameMode.Network) return; game.Step(otUser, 0, -1); ChangePic(otUser, '8'); break;
            //    case Keys.NumPad4: if (game.mode == GameMode.Network) return; game.Step(otUser, -1, 0); ChangePic(otUser, '4'); break;
            //    case Keys.NumPad2: if (game.mode == GameMode.Network) return; game.Step(otUser, 0, 1); ChangePic(otUser, '2'); break;
            //    case Keys.NumPad6: if (game.mode == GameMode.Network) return; game.Step(otUser, 1, 0); ChangePic(otUser, '6'); break;
            //    case Keys.Escape: if (game.mode == GameMode.Network && !phone.Send("0")) return; RestartLevel(); break;
            //}
        }

        private void Recv(string data)
        {
            switch (data)
            {
                case "8": game.Step(otUser, 0, -1); ChangePic(otUser, '8'); break;
                case "4": game.Step(otUser, -1, 0); ChangePic(otUser, '4'); break;
                case "2": game.Step(otUser, 0, 1); ChangePic(otUser, '2'); break;
                case "6": game.Step(otUser, 1, 0); ChangePic(otUser, '6'); break;
                case "0": RestartLevel(); break;
                case "3": OpenLevel(level.number + 1); break;
                case "9": OpenLevel(level.number - 1); break;
            }
        }

        private void ChangePic(int userNum, char m)
        {
            switch (m)
            {
                case '8': boxes[game.mouse[userNum].x, game.mouse[userNum].y].Image = (userNum == 1 ? Properties.Resources.user1North : Properties.Resources.user2North); break;
                case '2': boxes[game.mouse[userNum].x, game.mouse[userNum].y].Image = (userNum == 1 ? Properties.Resources.user1South : Properties.Resources.user2South); break;
                case '4': boxes[game.mouse[userNum].x, game.mouse[userNum].y].Image = (userNum == 1 ? Properties.Resources.user1West : Properties.Resources.user2West); break;
                case '6': boxes[game.mouse[userNum].x, game.mouse[userNum].y].Image = (userNum == 1 ? Properties.Resources.user1East : Properties.Resources.user2East); break;
                default:
                    break;
            }
        }

        public void InitPictures()
        {
            boxes = new PictureBox[width, height];
            int bs = Math.Min(contentPanel.Width / level.width, contentPanel.Height / level.height);
            int dw = (contentPanel.Width - ((bs - 1) * level.width)) / 2;
            int dh = (contentPanel.Height - ((bs - 1) * level.height)) / 2;

            contentPanel.Visible = false;
            contentPanel.Controls.Clear();

            for (int x = 0; x < level.width; x++)
                for (int y = 0; y < level.height; y++)
                {
                    PictureBox picture = new PictureBox();
                    picture.BackgroundImage = Properties.Resources.none;
                    picture.BackgroundImageLayout = ImageLayout.Zoom;
                    picture.BorderStyle = BorderStyle.None;
                    picture.Location = new Point(x * (bs) + dw, y * (bs) + dh);
                    picture.Size = new Size(bs, bs);
                    picture.SizeMode = PictureBoxSizeMode.Zoom;
                    picture.TabIndex = 0;
                    picture.TabStop = false;
                    picture.Tag = new Place(x, y);
                    picture.MouseClick += new MouseEventHandler(this.picture_MouseClick);
                    picture.MouseDoubleClick += new MouseEventHandler(this.picture_MouseDoubleClick);
                    contentPanel.Controls.Add(picture);
                    boxes[x, y] = picture;
                }
            contentPanel.Visible = true;
        }

        private void ShowItem(Place place, Cell item)
        {
            boxes[place.x, place.y].Image = CellToPicture(item);
        }

        public void ShowStats(int places, int dones)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new deLogging(() =>
                {
                    labelPlaceCounter.Text = places.ToString();
                    labelDoneCounter.Text = dones.ToString();
                    textBoxLevel.Text = String.Format("{0} / {1}", level.number, game.totalLevels);
                    if (places == dones && level.number == last_level_nr)
                    {
                        last_level_nr++;
                        //tableLayoutPanel1.Visible = false;
                    }
                }));
                return;
            }
            labelPlaceCounter.Text = places.ToString();
            labelDoneCounter.Text = dones.ToString();
            textBoxLevel.Text = String.Format("{0} / {1}", level.number, game.totalLevels);
            if (places == dones && level.number == last_level_nr)
            {
                last_level_nr++;
                //tableLayoutPanel1.Visible = false;
            }
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
                case Cell.user2: return Properties.Resources.user2South;
                default: return Properties.Resources.none;
            }
        }

        private void MazeForm_Resize(object sender, EventArgs e)
        {
            int bs = Math.Min(contentPanel.Width / level.width, contentPanel.Height / level.height);
            int dw = (contentPanel.Width - ((bs - 1) * level.width)) / 2;
            int dh = (contentPanel.Height - ((bs - 1) * level.height)) / 2;

            contentPanel.Visible = false;
            for (int x = 0; x < level.width; x++)
                for (int y = 0; y < level.height; y++)
                {
                    boxes[x, y].Location = new Point(x * (bs) + dw, y * (bs) + dh);
                    boxes[x, y].Size = new Size(bs, bs);
                }
            contentPanel.Visible = true;
        }

        private void RestartLevel()
        {
            game.Init(level.number, out width, out height);
            game.ShowLevel(level);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (path == "")
                return;
            switch (path[0])
            {
                case '8': if (game.mode == GameMode.Network && !phone.Send("8")) return; game.Step(myUser, 0, -1); break;
                case '4': if (game.mode == GameMode.Network && !phone.Send("4")) return; game.Step(myUser, -1, 0); break;
                case '2': if (game.mode == GameMode.Network && !phone.Send("2")) return; game.Step(myUser, 0, 1); break;
                case '6': if (game.mode == GameMode.Network && !phone.Send("6")) return; game.Step(myUser, 1, 0); break;
            }
            ChangePic(myUser, path[0]);
            path = path.Substring(1);
        }

        private void picture_MouseClick(object sender, MouseEventArgs e)
        {
            if (!fastMoves)
                return;
            Place place = (Place)((PictureBox)sender).Tag;
            string my_path = "";
            if (apple.x == -1)
            {
                my_path = game.SolveMouse(myUser, place);
            } else
            {
                my_path = game.SolveApple(myUser, apple, place);
                apple.x = -1;
                apple.y = -1;
            }
            
            path = my_path;
        }

        private void MazeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (game.mode == GameMode.Network)
                phone.Send("disconnect");
        }

        private void picture_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            apple = (Place)((PictureBox)sender).Tag;
        }
    }
}
