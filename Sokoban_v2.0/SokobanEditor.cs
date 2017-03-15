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
    public enum EditMode
    {
        Single,
        Coop
    }

    public struct EditObject
    {
        public int x;
        public int y;
        public Cell item;
        public bool single;

        public EditObject(int x, int y, Cell item, bool single)
        {
            this.x = x;
            this.y = y;
            this.item = item;
            this.single = single;
        }
    }

    public partial class SokobanEditor : Form
    {
        PictureBox[,] boxes;
        Cell[,] cells;
        Cell[,] tempCells;
        Stack<EditObject> history = new Stack<EditObject>();
        Stack<EditObject> redoHistory = new Stack<EditObject>();
        Stack<EditObject> rectObjects = new Stack<EditObject>();

        EditObject[,] rects;
        EditObject firstRectObj;
        EditObject lastRectObj;

        int width, height;
        Cell currentCell = Cell.none;
        EditMode mode;

        int currentLevel = 0;
        int here_counter = 0;
        int abox_counter = 0; 

        int minWidth = 5;
        int minHeight = 5;
        int maxWidth = 30;
        int maxHeight = 30;

        LevelFile level;

        bool levelChanged = false;
        bool multipleEdit = false;
        bool singleEdit = false;
        bool erase = false;
        bool rectSelect = false;
        bool paintRect = false;

        public SokobanEditor()
        {
            mode = EditMode.Single;

            InitializeComponent();

            numericUpDownCols.Maximum = maxWidth;
            numericUpDownRows.Maximum = maxHeight;
            numericUpDownCols.Minimum = minWidth;
            numericUpDownRows.Minimum = minHeight;

            trackBarCols.Maximum = maxWidth;
            trackBarCols.Minimum = minWidth;
            trackBarRows.Maximum = maxHeight;
            trackBarRows.Minimum = minHeight;

            RowStyle row1 = tableLayoutPanel.RowStyles[0];
            ColumnStyle col1 = tableLayoutPanel.ColumnStyles[0];

            row1.Height = (toolLevelResize.Checked) ? 32 : 0;
            col1.Width = (toolLevelResize.Checked) ? 43 : 0;

            toolMode.ComboBox.DataSource = Enum.GetValues(typeof(EditMode));
        }

        private void SokobanEditor_Load(object sender, EventArgs e)
        {
            level = new LevelFile(0);
            currentLevel = 1;
            LoadLevel();
        }

        public void InitPictures()
        {
            int bs = Math.Min(panel.Width / width, panel.Height / height );
            panel.Visible = false;
            panel.Controls.Clear();
            boxes = new PictureBox[width, height];

            int dw = (panel.ClientSize.Width - ((bs) * width)) / 2;
            int dh = (panel.ClientSize.Height - ((bs) * height)) / 2;

            panel.Visible = false;
            panel.Controls.Clear();

            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                {
                    PictureBox picture = new PictureBox();
                    picture.BackgroundImage = Properties.Resources.none;
                    picture.BackgroundImageLayout = ImageLayout.Zoom;
                    picture.BorderStyle = BorderStyle.FixedSingle;
                    picture.Location = new Point(x * (bs) + dw, y * (bs) + dh);
                    picture.Size = new Size(bs, bs);
                    picture.SizeMode = PictureBoxSizeMode.Zoom;
                    picture.TabIndex = 0;
                    picture.TabStop = false;
                    //picture.MouseClick += new MouseEventHandler(picture_MouseClick);
                    picture.MouseEnter += new EventHandler(picture_MouseEnter);
                    //picture.MouseLeave += new EventHandler(picture_MouseLeave);
                    picture.MouseDown += new MouseEventHandler(picture_MouseDown);
                    picture.MouseUp += new MouseEventHandler(picture_MouseUp);
                    picture.MouseMove += new MouseEventHandler(picture_MouseMove);
                    picture.Tag = new Point(x, y);
                    panel.Controls.Add(picture);
                    boxes[x, y] = picture;
                    boxes[x, y].Image = CellToPicture(cells[x, y]);
                }
            panel.Visible = true;
        }
      
        private void ShowCell(int x, int y, Cell cell)
        {
            //statusLevelSaveStatus.Text += cell.ToString();
            history.Push(new EditObject(x, y, cells[x, y], !multipleEdit));
            if (cell == Cell.user1)
                RemoveItem(Cell.user1);
            if (cell == Cell.user2)
                RemoveItem(Cell.user2);

            cells[x, y] = cell;
            boxes[x, y].Image = CellToPicture(cell);
        }

        private void RemoveItem(Cell item)
        {
            for (int xx = 0; xx < width; xx++)
                for (int yy = 0; yy < height; yy++)
                    if (cells[xx, yy] == item)
                    {
                        multipleEdit = !multipleEdit;
                        ShowCell(xx, yy, Cell.none);
                        multipleEdit = !multipleEdit;
                    }
        }

        public void RecalcStats()
        {
            here_counter = 0;
            abox_counter = 0;
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                { 
                    if (cells[x, y] == Cell.abox || cells[x, y] == Cell.done)
                        abox_counter++;
                    if (cells[x, y] == Cell.here || cells[x, y] == Cell.done)
                        here_counter++;
                }
            statusAboxCounter.Text = abox_counter.ToString();
            statusHereCounter.Text = here_counter.ToString();
            if (levelChanged)
                statusLevelSaveStatus.Visible = false;
        }

        public void LoadPictures()
        {

            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                    boxes[x, y].Image = CellToPicture(cells[x, y]);
        }

        private void SokobanEditor_Resize(object sender, EventArgs e)
        {
            panel.Visible = false;
            int bs = Math.Min(panel.Width / width, panel.Height / height);
            int dw = (panel.ClientSize.Width - ((bs) * width)) / 2;
            int dh = (panel.ClientSize.Height - ((bs) * height)) / 2;

            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                {
                    boxes[x, y].Size = new Size(bs, bs);
                    boxes[x, y].Location = new Point(x * bs + dw, y * bs + dh);
                }
            panel.Visible = true;
        }

        private void SetCurrentCell(Cell cell)
        {
            currentCell = cell;
            toolNone.Checked = (currentCell == Cell.none);
            toolWall.Checked = (currentCell == Cell.wall);
            toolAbox.Checked = (currentCell == Cell.abox);
            toolHere.Checked = (currentCell == Cell.here);
            toolDone.Checked = (currentCell == Cell.done);
            toolUser1.Checked = (currentCell == Cell.user1);
            toolUser2.Checked = (currentCell == Cell.user2);
        }

        private void toolWall_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.wall);
        }

        private void toolAbox_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.abox);
        }

        private void toolHere_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.here);
        }

        private void toolDone_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.done);
        }

        private void toolNone_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.none);
        }

        private void toolUser2_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.user2);
        }

        private void toolUser1_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.user1);
        }

        private void ResizeLevel(int w, int h)
        {
            if (w < minWidth) return;
            if (w > maxWidth) return;
            if (h < minHeight) return;
            if (h > maxHeight) return;

            Cell[,] newMap = new Cell[w, h];
            rects = new EditObject[w, h];

            for (int x = 0; x < Math.Min(w, width); x++)
                for (int y = 0; y < Math.Min(h, height); y++)
                    newMap[x, y] = cells[x, y];

            levelChanged = true;
            width = w;
            height = h;
            cells = newMap;
            tempCells = new Cell[width, height];

            InitPictures();
            RecalcStats();
        }

        private string IsGoodLevel()
        {
            int users = CountItems(Cell.user1);
            if (users == 0)
                return "Нужно указать начальное место ПЕРВОГО игрока";
            if (users > 1)
                return "Нужно указать только одного ПЕРВОГО игрока";

            if (mode == EditMode.Coop)
            {
                users = CountItems(Cell.user2);
                if (users == 0)
                    return "Нужно указать начальное место ВТОРОГО игрока";
                if (users > 1)
                    return "Нужно указать только одного ВТОРОГО игрока";
            }

            int aboxes = CountItems(Cell.abox);
            int heres = CountItems(Cell.here);

            if (aboxes == 0)
                return "Не обнаружено ни одного ящика";
            if (aboxes != heres)
                return "Количество ящиков должно соответствовать количеству мест для них";

            return "";
        }

        private int CountItems(Cell item)
        {
            int count = 0;
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                    if (cells[x, y] == item)
                        count++;
            return count;
        }

        private bool SaveLevel()
        {
            string error = IsGoodLevel();
            if (error != "")
            {
                MessageBox.Show(error, "Ошибка");
                return false;
            }

            level.SaveLevel(currentLevel, cells);
            statusLevelSaveStatus.Visible = true;
            levelChanged = false;
            return true;
        }

        private void toolPrev_Click(object sender, EventArgs e)
        {
            if (currentLevel > 1)
            {
                if (!SaveLevel())
                    return;
                currentLevel--;
                LoadLevel();
            }
        }

        private void toolNext_Click(object sender, EventArgs e)
        {

            if (!SaveLevel())
                return;
            currentLevel++;
            LoadLevel();
        }

        private void toolLevelSave_Click(object sender, EventArgs e)
        {
            SaveLevel();
        }

        private void toolLevelDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы действительно хотите удалить уровень?", "Внимание", MessageBoxButtons.YesNo);
            if (res != DialogResult.Yes)
                return;

            level.DeleteLevel(currentLevel);
            if (currentLevel == level.levelsTotal)
                currentLevel--;
            LoadLevel();
            levelChanged = false;
        }

        private void toolLevelResize_Click(object sender, EventArgs e)
        {
            toolLevelResize.Checked = !toolLevelResize.Checked;

            RowStyle row1 = tableLayoutPanel.RowStyles[0];
            ColumnStyle col1 = tableLayoutPanel.ColumnStyles[0];

            row1.Height = (toolLevelResize.Checked) ? 32 : 0;
            col1.Width = (toolLevelResize.Checked) ? 43 : 0;

            panelColTrack.Visible = toolLevelResize.Checked;
            panelRowTrack.Visible = toolLevelResize.Checked;

            InitPictures();
            RecalcStats();
        }

        private void LoadLevel()
        {

            cells = level.LoadLevelCells(currentLevel);

            toolLevelNumber.Text = string.Format("{0} / {1}", currentLevel, level.levelsTotal);
            width = cells.GetLength(0);
            height = cells.GetLength(1);
            tempCells = new Cell[width, height];

            trackBarCols.Value = width;
            trackBarRows.Value = height;

            numericUpDownRows.Value = height;
            numericUpDownCols.Value = width;


            InitPictures();
            RecalcStats();
        }

        private void numericUpDownRows_ValueChanged(object sender, EventArgs e)
        {
            trackBarRows.Value = Convert.ToInt32(numericUpDownRows.Value);
            //ResizeLevel(width, trackBarRows.Value);
        }

        private void trackBarRows_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownRows.Value = trackBarRows.Value;
            ResizeLevel(width, trackBarRows.Value);

        }

        private void trackBarCols_Scroll(object sender, EventArgs e)
        {
            numericUpDownCols.Value = trackBarCols.Value;
            //ResizeLevel(trackBarCols.Value, height);
        }

        private void numericUpDownCols_ValueChanged(object sender, EventArgs e)
        {
            trackBarCols.Value = Convert.ToInt32(numericUpDownCols.Value);
            ResizeLevel(trackBarCols.Value, height);

        }

        private void SokobanEditor_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1': SetCurrentCell(Cell.none); break;
                case '2': SetCurrentCell(Cell.wall); break;
                case '3': SetCurrentCell(Cell.abox); break;
                case '4': SetCurrentCell(Cell.here); break;
                case '5': SetCurrentCell(Cell.done); break;
                case '6': SetCurrentCell(Cell.user1); break;
                case '7': if (mode == EditMode.Single) return; SetCurrentCell(Cell.user2); break;

                default:
                    break;
            }
        }

        private void picture_MouseEnter(object sender, EventArgs e)
        {

            if (!statusLevelSaveStatus.Visible)
                statusLevelSaveStatus.Visible = true;
            int x, y;
            x = ((Point)((PictureBox)sender).Tag).X;
            y = ((Point)((PictureBox)sender).Tag).Y;
            statusLevelSaveStatus.Text = String.Format("{0} {1}", x, y);
            if (rectSelect)
            {
                multipleEdit = true;
                RedrawRectSelect(x, y);
                RecalcStats();
                return;
            } 
            if (singleEdit)
            {
                multipleEdit = true;
                ShowCell(x, y, currentCell);
            }
            else if (erase)
            {
                multipleEdit = true;
                ShowCell(x, y, Cell.none);
            }
            RecalcStats();
        }

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            panel.Focus();
            int x, y;
            x = ((Point)((PictureBox)sender).Tag).X;
            y = ((Point)((PictureBox)sender).Tag).Y;
            statusLevelSaveStatus.Text = String.Format("{0} {1}", x, y);

            if (e.Button == MouseButtons.Left)
            {
                if (Control.ModifierKeys == Keys.Shift)
                {
                    rectSelect = true;
                    firstRectObj = new EditObject(x, y, cells[x, y], false);
                    lastRectObj = new EditObject(x, y, cells[x, y], false);
                }
                singleEdit = true;
                ShowCell(x, y, currentCell);
                if (erase)
                {
                    EditObject lastObject;
                    do
                    {
                        lastObject = history.Pop();
                        cells[lastObject.x, lastObject.y] = lastObject.item;
                        boxes[lastObject.x, lastObject.y].Image = CellToPicture(lastObject.item);
                    } while (!lastObject.single && history.Count > 0);
                    singleEdit = false;
                    multipleEdit = false;
                    erase = false;
                    
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                erase = true;
                if (singleEdit || multipleEdit)
                {
                    if (rectSelect)
                        RemoveRect();

                    EditObject lastObject;
                    do
                    {
                        lastObject = history.Pop();
                        cells[lastObject.x, lastObject.y] = lastObject.item;
                        boxes[lastObject.x, lastObject.y].Image = CellToPicture(lastObject.item);
                    } while (!lastObject.single && history.Count > 0);
                    singleEdit = false;
                    multipleEdit = false;
                    erase = false;
                    rectSelect = false;
                    paintRect = false;
                }
                else
                    ShowCell(x, y, Cell.none);
            }
            levelChanged = true;
            RecalcStats();
            
        }

        private void RemoveRect()
        {
            int minX = Math.Min(firstRectObj.x, lastRectObj.x);
            int minY = Math.Min(firstRectObj.y, lastRectObj.y);
            int maxX = Math.Max(firstRectObj.x, lastRectObj.x);
            int maxY = Math.Max(firstRectObj.y, lastRectObj.y);
            for (int x = minX; x <= maxX; x++)
                for (int y = minY; y <= maxY; y++)
                    boxes[x, y].Image = CellToPicture(cells[x, y]);
        }

        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            if (rectSelect)
                ApplyRect();
            multipleEdit = false;
            singleEdit = false;
            erase = false;
            rectSelect = false;
            rectObjects.Clear(); 
        }

        private void ApplyRect()
        {
            int minX = Math.Min(firstRectObj.x, lastRectObj.x);
            int minY = Math.Min(firstRectObj.y, lastRectObj.y);
            int maxX = Math.Max(firstRectObj.x, lastRectObj.x);
            int maxY = Math.Max(firstRectObj.y, lastRectObj.y);

            for (int x = minX; x <= maxX; x++)
                for (int y = minY; y <= maxY; y++)
                {
                    history.Push(new EditObject(x, y, cells[x, y], false));
                    cells[x, y] = tempCells[x, y];
                }
        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                Control control = (Control)sender;
                if (control.Capture)
                    control.Capture = false;
            }
        }

        private void SokobanEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                paintRect = true;
                if (rectSelect && rectObjects.Count() > 0)
                {
                    EditObject lastObj = rectObjects.First();
                    RedrawRectSelect(lastObj.x, lastObj.y);
                }

            }
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Z && history.Count > 0)
            {
                EditObject lastObject;
                do
                {
                    lastObject = history.Pop();
                    cells[lastObject.x, lastObject.y] = lastObject.item;
                    boxes[lastObject.x, lastObject.y].Image = CellToPicture(lastObject.item);
                } while (!lastObject.single && history.Count > 0);
                
            }

        }

        private void SokobanEditor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                paintRect = false;
                if (rectSelect && rectObjects.Count() > 0)
                {
                    EditObject lastObj = rectObjects.Last();
                    RedrawRectSelect(lastObj.x, lastObj.y);
                }

            }

        }

        public void RedrawRectSelect(int x, int y)
        {
            
            int dx = x - lastRectObj.x;
            int dy = y - lastRectObj.y;
            int minX = Math.Min(firstRectObj.x, lastRectObj.x);
            int minY = Math.Min(firstRectObj.y, lastRectObj.y);
            int maxX = Math.Max(firstRectObj.x, lastRectObj.x);
            int maxY = Math.Max(firstRectObj.y, lastRectObj.y);

            if (dx < 0) // мышь влево
                for (int i = minY; i <= maxY; i++)
                    if (firstRectObj.x <= x) // квадрат уменьшается
                    {
                        boxes[maxX, i].Image = CellToPicture(cells[maxX, i]);
                        tempCells[maxX, i] = cells[maxX, i];
                        if (!paintRect)
                        {
                            boxes[maxX - 1, i].Image = CellToPicture(currentCell);
                            tempCells[maxX - 1, i] = currentCell;
                        }
                    }
                    else //квадрат увеличивается
                    {
                        boxes[x, i].Image = CellToPicture(currentCell);
                        tempCells[x, i] = currentCell;
                        if (!paintRect && i != minY && i != maxY && x + 1 != maxX)
                        {
                            boxes[x + 1, i].Image = CellToPicture(cells[x + 1, i]);
                            tempCells[x + 1, i] = cells[x + 1, i];
                        }
                    }

            if (dx > 0) //мышь вправо
                for (int i = minY; i <= maxY; i++)
                    if (firstRectObj.x < x) // квадрат увеличивается
                    {
                        boxes[x, i].Image = CellToPicture(currentCell);
                        tempCells[x, i] = currentCell;
                        if (!paintRect && i != minY && i != maxY && x - 1 != minX)
                        {
                            boxes[x - 1, i].Image = CellToPicture(cells[x - 1, i]);
                            tempCells[x - 1, i] = cells[x - 1, i];
                        }
                    }
                    else // квадрат уменьшается
                    {
                        boxes[minX, i].Image = CellToPicture(cells[minX, i]);
                        tempCells[minX, i] = cells[minX, i];
                        if (!paintRect)
                        {
                            boxes[minX + 1, i].Image = CellToPicture(currentCell);
                            tempCells[minX + 1, i] = currentCell;
                        }
                    }

            if (dy < 0) // мышь вверх
                for (int i = minX; i <= maxX; i++)
                    if (firstRectObj.y <= y) // квадрат уменьшается
                    {
                        boxes[i, maxY].Image = CellToPicture(cells[i, maxY]);
                        tempCells[i, maxY] = cells[i, maxY];
                        if (!paintRect)
                        {
                            boxes[i, maxY - 1].Image = CellToPicture(currentCell);
                            tempCells[i, maxY - 1] = currentCell;
                        }
                    }
                    else // квадрат увеличивается
                    {
                        boxes[i, y].Image = CellToPicture(currentCell);
                        tempCells[i, y] = currentCell;
                        if (!paintRect && i != minX && i != maxX && y + 1!= maxY)
                        {
                            boxes[i, y + 1].Image = CellToPicture(cells[i, y + 1]);
                            tempCells[i, y + 1] = cells[i, y + 1];
                        }
                    }

            if (dy > 0) // мышь вниз
                for (int i = minX; i <= maxX; i++)
                    if (firstRectObj.y < y) // квадрат увеличивается 
                    {
                        boxes[i, y].Image = CellToPicture(currentCell);
                        tempCells[i, y] = currentCell;
                        if (!paintRect && i != minX && i != maxX && y - 1 != minY)
                        {
                            boxes[i, y - 1].Image = CellToPicture(cells[i, y - 1]);
                            tempCells[i, y - 1] = cells[i, y - 1];
                        }
                    }
                    else // квадрат уменьшается
                    {
                        boxes[i, minY].Image = CellToPicture(cells[i, minY]);
                        tempCells[i, minY] = cells[i, minY];
                        if (!paintRect)
                        {
                            boxes[i, minY + 1].Image = CellToPicture(currentCell);
                            tempCells[i, minY + 1] = currentCell;
                        }
                    }

            lastRectObj = new EditObject(x, y, cells[x, y], multipleEdit);
        }

        private void toolMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            mode = (EditMode)toolMode.SelectedItem;
            toolUser2.Visible = (mode != EditMode.Single);
            level = new LevelFile(toolMode.SelectedIndex);
            currentLevel = 1;
            LoadLevel();
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

    }
}
