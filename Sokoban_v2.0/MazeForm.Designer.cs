namespace Sokoban
{
    partial class MazeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.fillerRight = new System.Windows.Forms.Panel();
            this.fillerTop = new System.Windows.Forms.Panel();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolButtonPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNextLevel = new System.Windows.Forms.Button();
            this.labelLevelInfo = new System.Windows.Forms.Label();
            this.btnPrevLevel = new System.Windows.Forms.Button();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.pictureBoxDones = new System.Windows.Forms.PictureBox();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelDoneCounter = new System.Windows.Forms.Label();
            this.pictureBoxPlaces = new System.Windows.Forms.PictureBox();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelPlaceCounter = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.toolButtonPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Controls.Add(this.contentPanel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.fillerRight, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.fillerTop, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusBar, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.toolButtonPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 562);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // contentPanel
            // 
            this.contentPanel.BackgroundImage = global::Sokoban.Properties.Resources.none;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(150, 25);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(609, 512);
            this.contentPanel.TabIndex = 0;
            // 
            // fillerRight
            // 
            this.fillerRight.BackgroundImage = global::Sokoban.Properties.Resources.filler_right;
            this.fillerRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fillerRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillerRight.Location = new System.Drawing.Point(759, 0);
            this.fillerRight.Margin = new System.Windows.Forms.Padding(0);
            this.fillerRight.Name = "fillerRight";
            this.tableLayoutPanel1.SetRowSpan(this.fillerRight, 3);
            this.fillerRight.Size = new System.Drawing.Size(25, 562);
            this.fillerRight.TabIndex = 1;
            // 
            // fillerTop
            // 
            this.fillerTop.BackgroundImage = global::Sokoban.Properties.Resources.resource;
            this.fillerTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fillerTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillerTop.Location = new System.Drawing.Point(150, 0);
            this.fillerTop.Margin = new System.Windows.Forms.Padding(0);
            this.fillerTop.Name = "fillerTop";
            this.fillerTop.Size = new System.Drawing.Size(609, 25);
            this.fillerTop.TabIndex = 3;
            // 
            // statusBar
            // 
            this.statusBar.BackgroundImage = global::Sokoban.Properties.Resources.statusline;
            this.statusBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusBar.Location = new System.Drawing.Point(150, 537);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(609, 25);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // toolButtonPanel
            // 
            this.toolButtonPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolButtonPanel.Controls.Add(this.tableLayoutPanel2);
            this.toolButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.toolButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.toolButtonPanel.Name = "toolButtonPanel";
            this.tableLayoutPanel1.SetRowSpan(this.toolButtonPanel, 3);
            this.toolButtonPanel.Size = new System.Drawing.Size(150, 562);
            this.toolButtonPanel.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImage = global::Sokoban.Properties.Resources.buttonpanel;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.btnNextLevel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelLevelInfo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPrevLevel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxLevel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxDones, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelX2, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelDoneCounter, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxPlaces, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelX1, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelPlaceCounter, 2, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(150, 562);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnNextLevel
            // 
            this.btnNextLevel.BackColor = System.Drawing.Color.Transparent;
            this.btnNextLevel.BackgroundImage = global::Sokoban.Properties.Resources.LevelNext;
            this.btnNextLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNextLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNextLevel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNextLevel.Location = new System.Drawing.Point(99, 25);
            this.btnNextLevel.Margin = new System.Windows.Forms.Padding(0);
            this.btnNextLevel.Name = "btnNextLevel";
            this.btnNextLevel.Size = new System.Drawing.Size(51, 30);
            this.btnNextLevel.TabIndex = 5;
            this.btnNextLevel.UseVisualStyleBackColor = false;
            this.btnNextLevel.Click += new System.EventHandler(this.btnNextLevel_Click);
            // 
            // labelLevelInfo
            // 
            this.labelLevelInfo.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.SetColumnSpan(this.labelLevelInfo, 3);
            this.labelLevelInfo.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelInfo.ForeColor = System.Drawing.Color.White;
            this.labelLevelInfo.Location = new System.Drawing.Point(3, 0);
            this.labelLevelInfo.Name = "labelLevelInfo";
            this.labelLevelInfo.Size = new System.Drawing.Size(144, 25);
            this.labelLevelInfo.TabIndex = 0;
            this.labelLevelInfo.Text = "УРОВЕНЬ";
            this.labelLevelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrevLevel
            // 
            this.btnPrevLevel.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevLevel.BackgroundImage = global::Sokoban.Properties.Resources.LevelPrev;
            this.btnPrevLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrevLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevLevel.Location = new System.Drawing.Point(0, 25);
            this.btnPrevLevel.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrevLevel.Name = "btnPrevLevel";
            this.btnPrevLevel.Size = new System.Drawing.Size(49, 30);
            this.btnPrevLevel.TabIndex = 1;
            this.btnPrevLevel.UseVisualStyleBackColor = false;
            this.btnPrevLevel.Click += new System.EventHandler(this.btnPrevLevel_Click);
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLevel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLevel.Location = new System.Drawing.Point(49, 25);
            this.textBoxLevel.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(50, 25);
            this.textBoxLevel.TabIndex = 3;
            this.textBoxLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxDones
            // 
            this.pictureBoxDones.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDones.BackgroundImage = global::Sokoban.Properties.Resources.face_done;
            this.pictureBoxDones.Location = new System.Drawing.Point(3, 118);
            this.pictureBoxDones.Name = "pictureBoxDones";
            this.pictureBoxDones.Size = new System.Drawing.Size(43, 24);
            this.pictureBoxDones.TabIndex = 11;
            this.pictureBoxDones.TabStop = false;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX2.ForeColor = System.Drawing.Color.White;
            this.labelX2.Location = new System.Drawing.Point(52, 115);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(44, 30);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "x";
            this.labelX2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDoneCounter
            // 
            this.labelDoneCounter.BackColor = System.Drawing.Color.Transparent;
            this.labelDoneCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDoneCounter.ForeColor = System.Drawing.Color.White;
            this.labelDoneCounter.Location = new System.Drawing.Point(102, 115);
            this.labelDoneCounter.Name = "labelDoneCounter";
            this.labelDoneCounter.Size = new System.Drawing.Size(44, 30);
            this.labelDoneCounter.TabIndex = 9;
            this.labelDoneCounter.Text = "2";
            this.labelDoneCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxPlaces
            // 
            this.pictureBoxPlaces.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlaces.BackgroundImage = global::Sokoban.Properties.Resources.face_here;
            this.pictureBoxPlaces.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPlaces.Location = new System.Drawing.Point(3, 88);
            this.pictureBoxPlaces.Name = "pictureBoxPlaces";
            this.pictureBoxPlaces.Size = new System.Drawing.Size(43, 24);
            this.pictureBoxPlaces.TabIndex = 10;
            this.pictureBoxPlaces.TabStop = false;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(52, 85);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(44, 30);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "x";
            this.labelX1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlaceCounter
            // 
            this.labelPlaceCounter.BackColor = System.Drawing.Color.Transparent;
            this.labelPlaceCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlaceCounter.ForeColor = System.Drawing.Color.White;
            this.labelPlaceCounter.Location = new System.Drawing.Point(102, 85);
            this.labelPlaceCounter.Name = "labelPlaceCounter";
            this.labelPlaceCounter.Size = new System.Drawing.Size(44, 30);
            this.labelPlaceCounter.TabIndex = 8;
            this.labelPlaceCounter.Text = "3";
            this.labelPlaceCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MazeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sokoban.Properties.Resources.TheEnd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MazeForm";
            this.ShowIcon = false;
            this.Text = "Sokoban WCII Edition";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MazeForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MazeForm_KeyDown);
            this.Resize += new System.EventHandler(this.MazeForm_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolButtonPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlaces)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel fillerRight;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.Panel fillerTop;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label labelLevelInfo;
        private System.Windows.Forms.Panel toolButtonPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnPrevLevel;
        private System.Windows.Forms.TextBox textBoxLevel;
        private System.Windows.Forms.Button btnNextLevel;
        private System.Windows.Forms.PictureBox pictureBoxDones;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelPlaceCounter;
        private System.Windows.Forms.Label labelDoneCounter;
        private System.Windows.Forms.PictureBox pictureBoxPlaces;
        private System.Windows.Forms.Timer timer;
    }
}