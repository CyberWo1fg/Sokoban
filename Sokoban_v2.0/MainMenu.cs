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
    public partial class MainMenu : Form
    {
        Button curBtn;
        bool ctrlStarted = false;
        GameControls[] controls;

        public MainMenu()
        {
            InitializeComponent();
            radioServer.Checked = true;
            radioServer_CheckedChanged((object)radioServer, new EventArgs());

            controls = new GameControls[3];
            controls[1] = new GameControls(1, Keys.W, Keys.S, Keys.A, Keys.D);
            controls[2] = new GameControls(2, Keys.NumPad8, Keys.NumPad2, Keys.NumPad4, Keys.NumPad6);

        }

        private void MenuButton_MouseDown(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.button_large_pressed;
            ((Button)sender).TextAlign = ContentAlignment.BottomCenter;
        }

        private void MenuButton_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.button_large_normal;
            ((Button)sender).TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            SokobanEditor Editor = new SokobanEditor();
            this.Visible = false;
            Editor.ShowDialog();
            this.Visible = true;
        }

        private void btnSingleGame_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(2);
        }

        private void btnMultiPlayer_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(1);
        }

        private void radioServer_CheckedChanged(object sender, EventArgs e)
        {
            labelHost.Visible = false;
            textBoxHost.Visible = false;
        }

        private void radioClient_CheckedChanged(object sender, EventArgs e)
        {
            labelHost.Visible = true;
            textBoxHost.Visible = true;

        }

        private void radioServer_Paint(object sender, PaintEventArgs e)
        { 
            if (((RadioButton)sender).Checked)
                e.Graphics.DrawImage(Properties.Resources.radio_normal_selected, 0, 0, radioServer.Height, radioServer.Height);
            else
                e.Graphics.DrawImage(Properties.Resources.radio_normal_unselected, 0, 0, radioServer.Height, radioServer.Height);           
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(0);
        }

        private void btnNetCustomStart_Click(object sender, EventArgs e)
        {
            MazeForm maze = null;
            if (radioServer.Checked)
                maze = new MazeForm(1, controls, textBoxPort.Text);
            if (radioClient.Checked)
                maze = new MazeForm(2, controls, textBoxHost.Text, textBoxPort.Text);
            this.Opacity = 0;
            maze.fastMoves = checkBoxClickMoves.Checked;
            maze.ShowDialog();
            this.Opacity = 100;
        }

        private void btnCustom1P_Click(object sender, EventArgs e)
        {
            MazeForm maze = new MazeForm(1, controls);
            this.Opacity = 0;
            maze.fastMoves = checkBoxClickMoves.Checked;
            maze.ShowDialog(this);
            this.Opacity = 100;
        }

        private void btnCustom2P_Click(object sender, EventArgs e)
        {
            MazeForm maze = new MazeForm(2, controls);
            this.Opacity = 0;
            maze.fastMoves = checkBoxClickMoves.Checked;
            maze.ShowDialog();
            this.Opacity = 100;
        }

        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (ctrlStarted)
            {
                GameControls curControl = curBtn.Name.Contains("1") ? controls[1] : controls[2];
                curControl.Up = curBtn.Name.Contains("Up") ? e.KeyCode : curControl.Up;
                curControl.Left = curBtn.Name.Contains("Left") ? e.KeyCode : curControl.Left;
                curControl.Down = curBtn.Name.Contains("Down") ? e.KeyCode : curControl.Down;
                curControl.Right = curBtn.Name.Contains("Right") ? e.KeyCode : curControl.Right;
                curBtn.Text = e.KeyCode.ToString();
                curBtn.BackgroundImage = Properties.Resources.textBoxPanel;
                return;
            }
            if (e.KeyCode == Keys.Escape && tabControl.SelectedIndex > 0)
                tabControl.SelectTab(0);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(3);
        }

        private void btnSetControl_MouseClick(object sender, MouseEventArgs e)
        {
            curBtn = (Button)sender;
            curBtn.BackgroundImage = Properties.Resources.textBoxPanelPressed;
            curBtn.Text = "";
            ctrlStarted = true;
        }

        private void checkBox_Paint(object sender, PaintEventArgs e)
        {
            CheckBox curObject = (CheckBox)sender;
            if (curObject.Checked)
                e.Graphics.DrawImage(Properties.Resources.checkbox_normal_selected, 0, 0, curObject.Height, curObject.Height);
            else
                e.Graphics.DrawImage(Properties.Resources.checkbox_normal_unselected, 0, 0, curObject.Height, curObject.Height);

            if (!curObject.Enabled)
                e.Graphics.DrawImage(Properties.Resources.checkbox_grayed, 0, 0, curObject.Height, curObject.Height);
        }
    }
}
