namespace Sokoban
{
    partial class SokobanEditor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SokobanEditor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolMode = new System.Windows.Forms.ToolStripComboBox();
            this.toolNone = new System.Windows.Forms.ToolStripButton();
            this.toolWall = new System.Windows.Forms.ToolStripButton();
            this.toolAbox = new System.Windows.Forms.ToolStripButton();
            this.toolHere = new System.Windows.Forms.ToolStripButton();
            this.toolDone = new System.Windows.Forms.ToolStripButton();
            this.toolSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolUser1 = new System.Windows.Forms.ToolStripButton();
            this.toolUser2 = new System.Windows.Forms.ToolStripButton();
            this.toolSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolPrev = new System.Windows.Forms.ToolStripButton();
            this.toolLevelNumber = new System.Windows.Forms.ToolStripTextBox();
            this.toolNext = new System.Windows.Forms.ToolStripButton();
            this.toolSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolLevelSave = new System.Windows.Forms.ToolStripButton();
            this.toolLevelResize = new System.Windows.Forms.ToolStripButton();
            this.toolLevelDelete = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel = new System.Windows.Forms.Panel();
            this.panelColTrack = new System.Windows.Forms.Panel();
            this.trackBarCols = new System.Windows.Forms.TrackBar();
            this.numericUpDownCols = new System.Windows.Forms.NumericUpDown();
            this.panelRowTrack = new System.Windows.Forms.Panel();
            this.trackBarRows = new System.Windows.Forms.TrackBar();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAbox = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAboxCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusHere = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusHereCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLevelSaveStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.panelColTrack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols)).BeginInit();
            this.panelRowTrack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackgroundImage = global::Sokoban.Properties.Resources.button_large_normal;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMode,
            this.toolNone,
            this.toolWall,
            this.toolAbox,
            this.toolHere,
            this.toolDone,
            this.toolSeparator1,
            this.toolUser1,
            this.toolUser2,
            this.toolSeparator2,
            this.toolPrev,
            this.toolLevelNumber,
            this.toolNext,
            this.toolSeparator3,
            this.toolLevelSave,
            this.toolLevelResize,
            this.toolLevelDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1111, 44);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Сохранить текущий уровень";
            // 
            // toolMode
            // 
            this.toolMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolMode.Name = "toolMode";
            this.toolMode.Size = new System.Drawing.Size(121, 44);
            this.toolMode.Text = "1 Игрок";
            this.toolMode.SelectedIndexChanged += new System.EventHandler(this.toolMode_SelectedIndexChanged);
            // 
            // toolNone
            // 
            this.toolNone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNone.Image = global::Sokoban.Properties.Resources.none;
            this.toolNone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNone.Name = "toolNone";
            this.toolNone.Size = new System.Drawing.Size(36, 41);
            this.toolNone.Text = "Земля (none)";
            this.toolNone.Click += new System.EventHandler(this.toolNone_Click);
            // 
            // toolWall
            // 
            this.toolWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolWall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolWall.Image = ((System.Drawing.Image)(resources.GetObject("toolWall.Image")));
            this.toolWall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolWall.Name = "toolWall";
            this.toolWall.Size = new System.Drawing.Size(36, 41);
            this.toolWall.Text = "Развалины (wall)";
            this.toolWall.Click += new System.EventHandler(this.toolWall_Click);
            // 
            // toolAbox
            // 
            this.toolAbox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAbox.Image = global::Sokoban.Properties.Resources.face_abox;
            this.toolAbox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAbox.Name = "toolAbox";
            this.toolAbox.Size = new System.Drawing.Size(36, 41);
            this.toolAbox.Text = "Монумент (box)";
            this.toolAbox.Click += new System.EventHandler(this.toolAbox_Click);
            // 
            // toolHere
            // 
            this.toolHere.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolHere.Image = global::Sokoban.Properties.Resources.face_here;
            this.toolHere.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolHere.Name = "toolHere";
            this.toolHere.Size = new System.Drawing.Size(36, 41);
            this.toolHere.Text = "Место активации монумента (here)";
            this.toolHere.Click += new System.EventHandler(this.toolHere_Click);
            // 
            // toolDone
            // 
            this.toolDone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDone.Image = global::Sokoban.Properties.Resources.face_done;
            this.toolDone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDone.Name = "toolDone";
            this.toolDone.Size = new System.Drawing.Size(36, 41);
            this.toolDone.Text = "Активированный монумент (done)";
            this.toolDone.Click += new System.EventHandler(this.toolDone_Click);
            // 
            // toolSeparator1
            // 
            this.toolSeparator1.Name = "toolSeparator1";
            this.toolSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // toolUser1
            // 
            this.toolUser1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolUser1.Image = global::Sokoban.Properties.Resources.face_user1;
            this.toolUser1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUser1.Name = "toolUser1";
            this.toolUser1.Size = new System.Drawing.Size(36, 41);
            this.toolUser1.Text = "Герой (user)";
            this.toolUser1.Click += new System.EventHandler(this.toolUser1_Click);
            // 
            // toolUser2
            // 
            this.toolUser2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolUser2.Image = global::Sokoban.Properties.Resources.face_user2;
            this.toolUser2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUser2.Name = "toolUser2";
            this.toolUser2.Size = new System.Drawing.Size(36, 41);
            this.toolUser2.Text = "Герой (user)";
            this.toolUser2.Visible = false;
            this.toolUser2.Click += new System.EventHandler(this.toolUser2_Click);
            // 
            // toolSeparator2
            // 
            this.toolSeparator2.Name = "toolSeparator2";
            this.toolSeparator2.Size = new System.Drawing.Size(6, 44);
            // 
            // toolPrev
            // 
            this.toolPrev.AutoSize = false;
            this.toolPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPrev.Image = global::Sokoban.Properties.Resources.LevelPrev;
            this.toolPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPrev.Name = "toolPrev";
            this.toolPrev.Size = new System.Drawing.Size(36, 24);
            this.toolPrev.Text = "Пред. уровень";
            this.toolPrev.Click += new System.EventHandler(this.toolPrev_Click);
            // 
            // toolLevelNumber
            // 
            this.toolLevelNumber.AutoSize = false;
            this.toolLevelNumber.Name = "toolLevelNumber";
            this.toolLevelNumber.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolLevelNumber.ReadOnly = true;
            this.toolLevelNumber.Size = new System.Drawing.Size(40, 37);
            this.toolLevelNumber.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolNext
            // 
            this.toolNext.AutoSize = false;
            this.toolNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNext.Image = global::Sokoban.Properties.Resources.LevelNext;
            this.toolNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNext.Name = "toolNext";
            this.toolNext.Size = new System.Drawing.Size(36, 24);
            this.toolNext.Text = "След. уровень";
            this.toolNext.Click += new System.EventHandler(this.toolNext_Click);
            // 
            // toolSeparator3
            // 
            this.toolSeparator3.Name = "toolSeparator3";
            this.toolSeparator3.Size = new System.Drawing.Size(6, 44);
            // 
            // toolLevelSave
            // 
            this.toolLevelSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolLevelSave.Image = global::Sokoban.Properties.Resources.LevelSaveIcon;
            this.toolLevelSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLevelSave.Name = "toolLevelSave";
            this.toolLevelSave.Size = new System.Drawing.Size(36, 41);
            this.toolLevelSave.Text = "Записать уровень";
            this.toolLevelSave.Click += new System.EventHandler(this.toolLevelSave_Click);
            // 
            // toolLevelResize
            // 
            this.toolLevelResize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolLevelResize.Image = global::Sokoban.Properties.Resources.LevelResize;
            this.toolLevelResize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLevelResize.Name = "toolLevelResize";
            this.toolLevelResize.Size = new System.Drawing.Size(36, 41);
            this.toolLevelResize.Text = "Изменить размер";
            this.toolLevelResize.Click += new System.EventHandler(this.toolLevelResize_Click);
            // 
            // toolLevelDelete
            // 
            this.toolLevelDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolLevelDelete.Image = global::Sokoban.Properties.Resources.LevelDeleteIcon;
            this.toolLevelDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLevelDelete.Name = "toolLevelDelete";
            this.toolLevelDelete.Size = new System.Drawing.Size(36, 41);
            this.toolLevelDelete.Text = "Удалить уровень";
            this.toolLevelDelete.Click += new System.EventHandler(this.toolLevelDelete_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackgroundImage = global::Sokoban.Properties.Resources.none;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Controls.Add(this.panel, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.panelColTrack, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.panelRowTrack, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 44);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1111, 518);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // panel
            // 
            this.panel.BackgroundImage = global::Sokoban.Properties.Resources.none;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(46, 35);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1062, 463);
            this.panel.TabIndex = 8;
            // 
            // panelColTrack
            // 
            this.panelColTrack.BackgroundImage = global::Sokoban.Properties.Resources.none;
            this.panelColTrack.Controls.Add(this.trackBarCols);
            this.panelColTrack.Controls.Add(this.numericUpDownCols);
            this.panelColTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelColTrack.Location = new System.Drawing.Point(43, 0);
            this.panelColTrack.Margin = new System.Windows.Forms.Padding(0);
            this.panelColTrack.Name = "panelColTrack";
            this.panelColTrack.Size = new System.Drawing.Size(1068, 32);
            this.panelColTrack.TabIndex = 11;
            // 
            // trackBarCols
            // 
            this.trackBarCols.AutoSize = false;
            this.trackBarCols.Location = new System.Drawing.Point(46, 3);
            this.trackBarCols.Maximum = 99;
            this.trackBarCols.Minimum = 5;
            this.trackBarCols.Name = "trackBarCols";
            this.trackBarCols.Size = new System.Drawing.Size(167, 21);
            this.trackBarCols.TabIndex = 1;
            this.trackBarCols.TabStop = false;
            this.trackBarCols.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarCols.Value = 5;
            this.trackBarCols.Scroll += new System.EventHandler(this.trackBarCols_Scroll);
            // 
            // numericUpDownCols
            // 
            this.numericUpDownCols.Location = new System.Drawing.Point(3, 3);
            this.numericUpDownCols.Name = "numericUpDownCols";
            this.numericUpDownCols.Size = new System.Drawing.Size(32, 20);
            this.numericUpDownCols.TabIndex = 0;
            this.numericUpDownCols.TabStop = false;
            this.numericUpDownCols.ValueChanged += new System.EventHandler(this.numericUpDownCols_ValueChanged);
            // 
            // panelRowTrack
            // 
            this.panelRowTrack.BackgroundImage = global::Sokoban.Properties.Resources.none;
            this.panelRowTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRowTrack.Controls.Add(this.trackBarRows);
            this.panelRowTrack.Controls.Add(this.numericUpDownRows);
            this.panelRowTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRowTrack.Location = new System.Drawing.Point(0, 32);
            this.panelRowTrack.Margin = new System.Windows.Forms.Padding(0);
            this.panelRowTrack.Name = "panelRowTrack";
            this.panelRowTrack.Size = new System.Drawing.Size(43, 486);
            this.panelRowTrack.TabIndex = 13;
            // 
            // trackBarRows
            // 
            this.trackBarRows.AutoSize = false;
            this.trackBarRows.Location = new System.Drawing.Point(9, 29);
            this.trackBarRows.Maximum = 99;
            this.trackBarRows.Minimum = 5;
            this.trackBarRows.Name = "trackBarRows";
            this.trackBarRows.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarRows.Size = new System.Drawing.Size(21, 167);
            this.trackBarRows.TabIndex = 2;
            this.trackBarRows.TabStop = false;
            this.trackBarRows.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRows.Value = 5;
            this.trackBarRows.ValueChanged += new System.EventHandler(this.trackBarRows_ValueChanged);
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Location = new System.Drawing.Point(3, 3);
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(32, 20);
            this.numericUpDownRows.TabIndex = 1;
            this.numericUpDownRows.TabStop = false;
            this.numericUpDownRows.ValueChanged += new System.EventHandler(this.numericUpDownRows_ValueChanged);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status,
            this.statusAbox,
            this.statusAboxCounter,
            this.statusHere,
            this.statusHereCounter,
            this.statusLevelSaveStatus});
            this.statusBar.Location = new System.Drawing.Point(0, 540);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1111, 22);
            this.statusBar.TabIndex = 11;
            this.statusBar.Text = "Строка состояния";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // statusAbox
            // 
            this.statusAbox.Name = "statusAbox";
            this.statusAbox.Size = new System.Drawing.Size(81, 17);
            this.statusAbox.Text = "Монументов:";
            // 
            // statusAboxCounter
            // 
            this.statusAboxCounter.Name = "statusAboxCounter";
            this.statusAboxCounter.Size = new System.Drawing.Size(13, 17);
            this.statusAboxCounter.Text = "0";
            // 
            // statusHere
            // 
            this.statusHere.Name = "statusHere";
            this.statusHere.Size = new System.Drawing.Size(170, 17);
            this.statusHere.Text = "Мест активации монументов:";
            // 
            // statusHereCounter
            // 
            this.statusHereCounter.Name = "statusHereCounter";
            this.statusHereCounter.Size = new System.Drawing.Size(13, 17);
            this.statusHereCounter.Text = "0";
            // 
            // statusLevelSaveStatus
            // 
            this.statusLevelSaveStatus.Name = "statusLevelSaveStatus";
            this.statusLevelSaveStatus.Size = new System.Drawing.Size(819, 17);
            this.statusLevelSaveStatus.Spring = true;
            this.statusLevelSaveStatus.Text = "Уровень сохранен!!!";
            this.statusLevelSaveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.statusLevelSaveStatus.Visible = false;
            // 
            // SokobanEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 562);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "SokobanEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор";
            this.Load += new System.EventHandler(this.SokobanEditor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SokobanEditor_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SokobanEditor_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SokobanEditor_KeyUp);
            this.Resize += new System.EventHandler(this.SokobanEditor_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.panelColTrack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols)).EndInit();
            this.panelRowTrack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolWall;
        private System.Windows.Forms.ToolStripButton toolAbox;
        private System.Windows.Forms.ToolStripButton toolHere;
        private System.Windows.Forms.ToolStripButton toolDone;
        private System.Windows.Forms.ToolStripButton toolNone;
        private System.Windows.Forms.ToolStripButton toolUser2;
        private System.Windows.Forms.ToolStripSeparator toolSeparator2;
        private System.Windows.Forms.ToolStripButton toolPrev;
        private System.Windows.Forms.ToolStripButton toolNext;
        private System.Windows.Forms.ToolStripButton toolLevelSave;
        private System.Windows.Forms.ToolStripSeparator toolSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolLevelNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panelColTrack;
        private System.Windows.Forms.Panel panelRowTrack;
        private System.Windows.Forms.TrackBar trackBarCols;
        private System.Windows.Forms.NumericUpDown numericUpDownCols;
        private System.Windows.Forms.TrackBar trackBarRows;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.ToolStripButton toolLevelResize;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStripStatusLabel statusAbox;
        private System.Windows.Forms.ToolStripStatusLabel statusAboxCounter;
        private System.Windows.Forms.ToolStripStatusLabel statusHere;
        private System.Windows.Forms.ToolStripStatusLabel statusHereCounter;
        private System.Windows.Forms.ToolStripStatusLabel statusLevelSaveStatus;
        private System.Windows.Forms.ToolStripButton toolUser1;
        private System.Windows.Forms.ToolStripSeparator toolSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolMode;
        private System.Windows.Forms.ToolStripButton toolLevelDelete;
    }
}

