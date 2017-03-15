namespace Sokoban
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.btnSingleGame = new System.Windows.Forms.Button();
            this.btnEditor = new System.Windows.Forms.Button();
            this.btnNetworkGame = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabMulti = new System.Windows.Forms.TabPage();
            this.btnNetCustomStart = new System.Windows.Forms.Button();
            this.btnMultiReturn = new System.Windows.Forms.Button();
            this.radioClient = new System.Windows.Forms.RadioButton();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.radioServer = new System.Windows.Forms.RadioButton();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelHost = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.tabSingle = new System.Windows.Forms.TabPage();
            this.btnCustom2P = new System.Windows.Forms.Button();
            this.btnCampaign = new System.Windows.Forms.Button();
            this.btnCustom1P = new System.Windows.Forms.Button();
            this.btnSingleReturn = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetControl2Right = new System.Windows.Forms.Button();
            this.btnSetControl2Down = new System.Windows.Forms.Button();
            this.btnSetControl2Left = new System.Windows.Forms.Button();
            this.btnSetControl2Up = new System.Windows.Forms.Button();
            this.btnSetControl1Right = new System.Windows.Forms.Button();
            this.btnSetControl1Down = new System.Windows.Forms.Button();
            this.btnSetControl1Left = new System.Windows.Forms.Button();
            this.btnSetControl1Up = new System.Windows.Forms.Button();
            this.labelUser2Right = new System.Windows.Forms.Label();
            this.labelUser2Down = new System.Windows.Forms.Label();
            this.labelUser2Left = new System.Windows.Forms.Label();
            this.labelUser2Up = new System.Windows.Forms.Label();
            this.labelUser1Right = new System.Windows.Forms.Label();
            this.labelUser1Down = new System.Windows.Forms.Label();
            this.labelUser1Left = new System.Windows.Forms.Label();
            this.labelUser1Up = new System.Windows.Forms.Label();
            this.labelControlSettings = new System.Windows.Forms.Label();
            this.checkBoxClickMoves = new System.Windows.Forms.CheckBox();
            this.checkBoxSound = new System.Windows.Forms.CheckBox();
            this.btnSettingsReturn = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabMulti.SuspendLayout();
            this.tabSingle.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabMain);
            this.tabControl.Controls.Add(this.tabMulti);
            this.tabControl.Controls.Add(this.tabSingle);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(808, 609);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 22;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.Transparent;
            this.tabMain.BackgroundImage = global::Sokoban.Properties.Resources.MenuBackground;
            this.tabMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabMain.Controls.Add(this.btnSingleGame);
            this.tabMain.Controls.Add(this.btnEditor);
            this.tabMain.Controls.Add(this.btnNetworkGame);
            this.tabMain.Controls.Add(this.btnSettings);
            this.tabMain.Controls.Add(this.btnExit);
            this.tabMain.Location = new System.Drawing.Point(4, 5);
            this.tabMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(800, 600);
            this.tabMain.TabIndex = 0;
            // 
            // btnSingleGame
            // 
            this.btnSingleGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSingleGame.BackgroundImage = global::Sokoban.Properties.Resources.button_large_normal;
            this.btnSingleGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSingleGame.FlatAppearance.BorderSize = 0;
            this.btnSingleGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingleGame.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSingleGame.ForeColor = System.Drawing.Color.Gold;
            this.btnSingleGame.Location = new System.Drawing.Point(232, 199);
            this.btnSingleGame.Name = "btnSingleGame";
            this.btnSingleGame.Size = new System.Drawing.Size(336, 42);
            this.btnSingleGame.TabIndex = 17;
            this.btnSingleGame.Text = "&ОДИНОЧНАЯ ИГРА";
            this.btnSingleGame.UseVisualStyleBackColor = true;
            this.btnSingleGame.Click += new System.EventHandler(this.btnSingleGame_Click);
            this.btnSingleGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseDown);
            this.btnSingleGame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseUp);
            // 
            // btnEditor
            // 
            this.btnEditor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditor.BackgroundImage = global::Sokoban.Properties.Resources.button_large_normal;
            this.btnEditor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditor.FlatAppearance.BorderSize = 0;
            this.btnEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditor.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditor.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnEditor.Location = new System.Drawing.Point(232, 397);
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.Size = new System.Drawing.Size(336, 42);
            this.btnEditor.TabIndex = 20;
            this.btnEditor.Text = "&РЕДАКТОР";
            this.btnEditor.UseVisualStyleBackColor = true;
            this.btnEditor.Click += new System.EventHandler(this.btnEditor_Click);
            this.btnEditor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseDown);
            this.btnEditor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseUp);
            // 
            // btnNetworkGame
            // 
            this.btnNetworkGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNetworkGame.BackgroundImage = global::Sokoban.Properties.Resources.button_large_normal;
            this.btnNetworkGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNetworkGame.FlatAppearance.BorderSize = 0;
            this.btnNetworkGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNetworkGame.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNetworkGame.ForeColor = System.Drawing.Color.Gold;
            this.btnNetworkGame.Location = new System.Drawing.Point(232, 265);
            this.btnNetworkGame.Name = "btnNetworkGame";
            this.btnNetworkGame.Size = new System.Drawing.Size(336, 42);
            this.btnNetworkGame.TabIndex = 18;
            this.btnNetworkGame.Text = "&СЕТЕВАЯ ИГРА";
            this.btnNetworkGame.UseVisualStyleBackColor = true;
            this.btnNetworkGame.Click += new System.EventHandler(this.btnMultiPlayer_Click);
            this.btnNetworkGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseDown);
            this.btnNetworkGame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseUp);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSettings.BackgroundImage = global::Sokoban.Properties.Resources.button_large_normal;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSettings.ForeColor = System.Drawing.Color.Gold;
            this.btnSettings.Location = new System.Drawing.Point(232, 331);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(336, 42);
            this.btnSettings.TabIndex = 19;
            this.btnSettings.Text = "&НАСТРОЙКИ";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseDown);
            this.btnSettings.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExit.BackgroundImage = global::Sokoban.Properties.Resources.button_large_normal;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.Gold;
            this.btnExit.Location = new System.Drawing.Point(232, 463);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(336, 42);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "&ВЫЙТИ ИЗ ПРОГРАММЫ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseDown);
            this.btnExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseUp);
            // 
            // tabMulti
            // 
            this.tabMulti.BackgroundImage = global::Sokoban.Properties.Resources.MenuBackground;
            this.tabMulti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabMulti.Controls.Add(this.btnNetCustomStart);
            this.tabMulti.Controls.Add(this.btnMultiReturn);
            this.tabMulti.Controls.Add(this.radioClient);
            this.tabMulti.Controls.Add(this.textBoxHost);
            this.tabMulti.Controls.Add(this.radioServer);
            this.tabMulti.Controls.Add(this.labelPort);
            this.tabMulti.Controls.Add(this.labelHost);
            this.tabMulti.Controls.Add(this.textBoxPort);
            this.tabMulti.Location = new System.Drawing.Point(4, 5);
            this.tabMulti.Name = "tabMulti";
            this.tabMulti.Padding = new System.Windows.Forms.Padding(3);
            this.tabMulti.Size = new System.Drawing.Size(800, 600);
            this.tabMulti.TabIndex = 1;
            this.tabMulti.Text = "tabPage2";
            this.tabMulti.UseVisualStyleBackColor = true;
            // 
            // btnNetCustomStart
            // 
            this.btnNetCustomStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNetCustomStart.BackgroundImage = global::Sokoban.Properties.Resources.button_large_normal;
            this.btnNetCustomStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNetCustomStart.FlatAppearance.BorderSize = 0;
            this.btnNetCustomStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNetCustomStart.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNetCustomStart.ForeColor = System.Drawing.Color.Gold;
            this.btnNetCustomStart.Location = new System.Drawing.Point(232, 265);
            this.btnNetCustomStart.Name = "btnNetCustomStart";
            this.btnNetCustomStart.Size = new System.Drawing.Size(336, 42);
            this.btnNetCustomStart.TabIndex = 23;
            this.btnNetCustomStart.Text = "&НАЧАТЬ ИГРУ";
            this.btnNetCustomStart.UseVisualStyleBackColor = true;
            this.btnNetCustomStart.Click += new System.EventHandler(this.btnNetCustomStart_Click);
            this.btnNetCustomStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseDown);
            this.btnNetCustomStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseUp);
            // 
            // btnMultiReturn
            // 
            this.btnMultiReturn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMultiReturn.BackgroundImage = global::Sokoban.Properties.Resources.button_large_normal;
            this.btnMultiReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMultiReturn.FlatAppearance.BorderSize = 0;
            this.btnMultiReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiReturn.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMultiReturn.ForeColor = System.Drawing.Color.Gold;
            this.btnMultiReturn.Location = new System.Drawing.Point(232, 463);
            this.btnMultiReturn.Name = "btnMultiReturn";
            this.btnMultiReturn.Size = new System.Drawing.Size(336, 42);
            this.btnMultiReturn.TabIndex = 22;
            this.btnMultiReturn.Text = "&ВЕРНУТЬСЯ";
            this.btnMultiReturn.UseVisualStyleBackColor = true;
            this.btnMultiReturn.Click += new System.EventHandler(this.btnReturn_Click);
            this.btnMultiReturn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseDown);
            this.btnMultiReturn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseUp);
            // 
            // radioClient
            // 
            this.radioClient.AutoSize = true;
            this.radioClient.BackColor = System.Drawing.Color.Transparent;
            this.radioClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioClient.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioClient.ForeColor = System.Drawing.Color.White;
            this.radioClient.Location = new System.Drawing.Point(400, 331);
            this.radioClient.Name = "radioClient";
            this.radioClient.Size = new System.Drawing.Size(105, 30);
            this.radioClient.TabIndex = 12;
            this.radioClient.Text = "  КЛИЕНТ";
            this.radioClient.UseVisualStyleBackColor = false;
            this.radioClient.CheckedChanged += new System.EventHandler(this.radioClient_CheckedChanged);
            this.radioClient.Paint += new System.Windows.Forms.PaintEventHandler(this.radioServer_Paint);
            // 
            // textBoxHost
            // 
            this.textBoxHost.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxHost.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHost.ForeColor = System.Drawing.Color.Gold;
            this.textBoxHost.Location = new System.Drawing.Point(375, 376);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(118, 33);
            this.textBoxHost.TabIndex = 10;
            this.textBoxHost.Text = "127.0.0.1";
            // 
            // radioServer
            // 
            this.radioServer.AutoSize = true;
            this.radioServer.BackColor = System.Drawing.Color.Transparent;
            this.radioServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioServer.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioServer.ForeColor = System.Drawing.Color.White;
            this.radioServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioServer.ImageKey = "(отсутствует)";
            this.radioServer.Location = new System.Drawing.Point(287, 331);
            this.radioServer.Name = "radioServer";
            this.radioServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioServer.Size = new System.Drawing.Size(103, 30);
            this.radioServer.TabIndex = 11;
            this.radioServer.Text = "  СЕРВЕР";
            this.radioServer.UseVisualStyleBackColor = false;
            this.radioServer.CheckedChanged += new System.EventHandler(this.radioServer_CheckedChanged);
            this.radioServer.Paint += new System.Windows.Forms.PaintEventHandler(this.radioServer_Paint);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.BackColor = System.Drawing.Color.Transparent;
            this.labelPort.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPort.ForeColor = System.Drawing.Color.Gold;
            this.labelPort.Location = new System.Drawing.Point(304, 418);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(52, 26);
            this.labelPort.TabIndex = 7;
            this.labelPort.Text = "PORT";
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.BackColor = System.Drawing.Color.Transparent;
            this.labelHost.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHost.ForeColor = System.Drawing.Color.Gold;
            this.labelHost.Location = new System.Drawing.Point(305, 379);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(51, 26);
            this.labelHost.TabIndex = 8;
            this.labelHost.Text = "HOST";
            // 
            // textBoxPort
            // 
            this.textBoxPort.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxPort.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPort.ForeColor = System.Drawing.Color.Gold;
            this.textBoxPort.Location = new System.Drawing.Point(375, 415);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(118, 33);
            this.textBoxPort.TabIndex = 9;
            this.textBoxPort.Text = "8000";
            // 
            // tabSingle
            // 
            this.tabSingle.BackgroundImage = global::Sokoban.Properties.Resources.MenuBackground;
            this.tabSingle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabSingle.Controls.Add(this.btnCustom2P);
            this.tabSingle.Controls.Add(this.btnCampaign);
            this.tabSingle.Controls.Add(this.btnCustom1P);
            this.tabSingle.Controls.Add(this.btnSingleReturn);
            this.tabSingle.Location = new System.Drawing.Point(4, 5);
            this.tabSingle.Name = "tabSingle";
            this.tabSingle.Padding = new System.Windows.Forms.Padding(3);
            this.tabSingle.Size = new System.Drawing.Size(800, 600);
            this.tabSingle.TabIndex = 2;
            this.tabSingle.UseVisualStyleBackColor = true;
            // 
            // btnCustom2P
            // 
            this.btnCustom2P.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCustom2P.BackgroundImage = global::Sokoban.Properties.Resources.button_large_normal;
            this.btnCustom2P.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCustom2P.FlatAppearance.BorderSize = 0;
            this.btnCustom2P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustom2P.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCustom2P.ForeColor = System.Drawing.Color.Gold;
            this.btnCustom2P.Location = new System.Drawing.Point(232, 315);
            this.btnCustom2P.Name = "btnCustom2P";
            this.btnCustom2P.Size = new System.Drawing.Size(336, 42);
            this.btnCustom2P.TabIndex = 27;
            this.btnCustom2P.Text = "&ДВА ИГРОКА";
            this.btnCustom2P.UseVisualStyleBackColor = true;
            this.btnCustom2P.Click += new System.EventHandler(this.btnCustom2P_Click);
            this.btnCustom2P.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseDown);
            this.btnCustom2P.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseUp);
            // 
            // btnCampaign
            // 
            this.btnCampaign.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCampaign.BackgroundImage = global::Sokoban.Properties.Resources.button_large_normal;
            this.btnCampaign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCampaign.Enabled = false;
            this.btnCampaign.FlatAppearance.BorderSize = 0;
            this.btnCampaign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCampaign.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCampaign.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCampaign.Location = new System.Drawing.Point(232, 199);
            this.btnCampaign.Name = "btnCampaign";
            this.btnCampaign.Size = new System.Drawing.Size(336, 42);
            this.btnCampaign.TabIndex = 22;
            this.btnCampaign.Text = "&КАМПАНИЯ";
            this.btnCampaign.UseVisualStyleBackColor = true;
            this.btnCampaign.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseDown);
            this.btnCampaign.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseUp);
            // 
            // btnCustom1P
            // 
            this.btnCustom1P.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCustom1P.BackgroundImage = global::Sokoban.Properties.Resources.button_large_normal;
            this.btnCustom1P.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCustom1P.FlatAppearance.BorderSize = 0;
            this.btnCustom1P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustom1P.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCustom1P.ForeColor = System.Drawing.Color.Gold;
            this.btnCustom1P.Location = new System.Drawing.Point(232, 257);
            this.btnCustom1P.Name = "btnCustom1P";
            this.btnCustom1P.Size = new System.Drawing.Size(336, 42);
            this.btnCustom1P.TabIndex = 23;
            this.btnCustom1P.Text = "&ОДИН ИГРОК";
            this.btnCustom1P.UseVisualStyleBackColor = true;
            this.btnCustom1P.Click += new System.EventHandler(this.btnCustom1P_Click);
            this.btnCustom1P.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseDown);
            this.btnCustom1P.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseUp);
            // 
            // btnSingleReturn
            // 
            this.btnSingleReturn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSingleReturn.BackgroundImage = global::Sokoban.Properties.Resources.button_large_normal;
            this.btnSingleReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSingleReturn.FlatAppearance.BorderSize = 0;
            this.btnSingleReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingleReturn.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSingleReturn.ForeColor = System.Drawing.Color.Gold;
            this.btnSingleReturn.Location = new System.Drawing.Point(232, 463);
            this.btnSingleReturn.Name = "btnSingleReturn";
            this.btnSingleReturn.Size = new System.Drawing.Size(336, 42);
            this.btnSingleReturn.TabIndex = 26;
            this.btnSingleReturn.Text = "&ВЕРНУТЬСЯ";
            this.btnSingleReturn.UseVisualStyleBackColor = true;
            this.btnSingleReturn.Click += new System.EventHandler(this.btnReturn_Click);
            this.btnSingleReturn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseDown);
            this.btnSingleReturn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseUp);
            // 
            // tabSettings
            // 
            this.tabSettings.BackgroundImage = global::Sokoban.Properties.Resources.MenuBackground;
            this.tabSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabSettings.Controls.Add(this.label2);
            this.tabSettings.Controls.Add(this.label1);
            this.tabSettings.Controls.Add(this.btnSetControl2Right);
            this.tabSettings.Controls.Add(this.btnSetControl2Down);
            this.tabSettings.Controls.Add(this.btnSetControl2Left);
            this.tabSettings.Controls.Add(this.btnSetControl2Up);
            this.tabSettings.Controls.Add(this.btnSetControl1Right);
            this.tabSettings.Controls.Add(this.btnSetControl1Down);
            this.tabSettings.Controls.Add(this.btnSetControl1Left);
            this.tabSettings.Controls.Add(this.btnSetControl1Up);
            this.tabSettings.Controls.Add(this.labelUser2Right);
            this.tabSettings.Controls.Add(this.labelUser2Down);
            this.tabSettings.Controls.Add(this.labelUser2Left);
            this.tabSettings.Controls.Add(this.labelUser2Up);
            this.tabSettings.Controls.Add(this.labelUser1Right);
            this.tabSettings.Controls.Add(this.labelUser1Down);
            this.tabSettings.Controls.Add(this.labelUser1Left);
            this.tabSettings.Controls.Add(this.labelUser1Up);
            this.tabSettings.Controls.Add(this.labelControlSettings);
            this.tabSettings.Controls.Add(this.checkBoxClickMoves);
            this.tabSettings.Controls.Add(this.checkBoxSound);
            this.tabSettings.Controls.Add(this.btnSettingsReturn);
            this.tabSettings.Location = new System.Drawing.Point(4, 5);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(800, 600);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(460, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 26);
            this.label2.TabIndex = 44;
            this.label2.Text = "ИГРОК 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(299, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 43;
            this.label1.Text = "ИГРОК 1";
            // 
            // btnSetControl2Right
            // 
            this.btnSetControl2Right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetControl2Right.BackgroundImage")));
            this.btnSetControl2Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetControl2Right.FlatAppearance.BorderSize = 0;
            this.btnSetControl2Right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetControl2Right.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetControl2Right.ForeColor = System.Drawing.Color.Gold;
            this.btnSetControl2Right.Location = new System.Drawing.Point(505, 355);
            this.btnSetControl2Right.Name = "btnSetControl2Right";
            this.btnSetControl2Right.Size = new System.Drawing.Size(73, 26);
            this.btnSetControl2Right.TabIndex = 42;
            this.btnSetControl2Right.Text = "NumPad6";
            this.btnSetControl2Right.UseVisualStyleBackColor = true;
            this.btnSetControl2Right.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSetControl_MouseClick);
            // 
            // btnSetControl2Down
            // 
            this.btnSetControl2Down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetControl2Down.BackgroundImage")));
            this.btnSetControl2Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetControl2Down.FlatAppearance.BorderSize = 0;
            this.btnSetControl2Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetControl2Down.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetControl2Down.ForeColor = System.Drawing.Color.Gold;
            this.btnSetControl2Down.Location = new System.Drawing.Point(505, 320);
            this.btnSetControl2Down.Name = "btnSetControl2Down";
            this.btnSetControl2Down.Size = new System.Drawing.Size(73, 26);
            this.btnSetControl2Down.TabIndex = 41;
            this.btnSetControl2Down.Text = "NumPad2";
            this.btnSetControl2Down.UseVisualStyleBackColor = true;
            this.btnSetControl2Down.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSetControl_MouseClick);
            // 
            // btnSetControl2Left
            // 
            this.btnSetControl2Left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetControl2Left.BackgroundImage")));
            this.btnSetControl2Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetControl2Left.FlatAppearance.BorderSize = 0;
            this.btnSetControl2Left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetControl2Left.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetControl2Left.ForeColor = System.Drawing.Color.Gold;
            this.btnSetControl2Left.Location = new System.Drawing.Point(505, 283);
            this.btnSetControl2Left.Name = "btnSetControl2Left";
            this.btnSetControl2Left.Size = new System.Drawing.Size(73, 26);
            this.btnSetControl2Left.TabIndex = 40;
            this.btnSetControl2Left.Text = "NumPad4";
            this.btnSetControl2Left.UseVisualStyleBackColor = true;
            this.btnSetControl2Left.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSetControl_MouseClick);
            // 
            // btnSetControl2Up
            // 
            this.btnSetControl2Up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetControl2Up.BackgroundImage")));
            this.btnSetControl2Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetControl2Up.FlatAppearance.BorderSize = 0;
            this.btnSetControl2Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetControl2Up.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetControl2Up.ForeColor = System.Drawing.Color.Gold;
            this.btnSetControl2Up.Location = new System.Drawing.Point(505, 245);
            this.btnSetControl2Up.Name = "btnSetControl2Up";
            this.btnSetControl2Up.Size = new System.Drawing.Size(73, 26);
            this.btnSetControl2Up.TabIndex = 39;
            this.btnSetControl2Up.Text = "NumPad8";
            this.btnSetControl2Up.UseVisualStyleBackColor = true;
            this.btnSetControl2Up.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSetControl_MouseClick);
            // 
            // btnSetControl1Right
            // 
            this.btnSetControl1Right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetControl1Right.BackgroundImage")));
            this.btnSetControl1Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetControl1Right.FlatAppearance.BorderSize = 0;
            this.btnSetControl1Right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetControl1Right.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetControl1Right.ForeColor = System.Drawing.Color.Gold;
            this.btnSetControl1Right.Location = new System.Drawing.Point(336, 355);
            this.btnSetControl1Right.Name = "btnSetControl1Right";
            this.btnSetControl1Right.Size = new System.Drawing.Size(73, 26);
            this.btnSetControl1Right.TabIndex = 38;
            this.btnSetControl1Right.Text = "D";
            this.btnSetControl1Right.UseVisualStyleBackColor = true;
            this.btnSetControl1Right.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSetControl_MouseClick);
            // 
            // btnSetControl1Down
            // 
            this.btnSetControl1Down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetControl1Down.BackgroundImage")));
            this.btnSetControl1Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetControl1Down.FlatAppearance.BorderSize = 0;
            this.btnSetControl1Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetControl1Down.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetControl1Down.ForeColor = System.Drawing.Color.Gold;
            this.btnSetControl1Down.Location = new System.Drawing.Point(336, 320);
            this.btnSetControl1Down.Name = "btnSetControl1Down";
            this.btnSetControl1Down.Size = new System.Drawing.Size(73, 26);
            this.btnSetControl1Down.TabIndex = 37;
            this.btnSetControl1Down.Text = "S";
            this.btnSetControl1Down.UseVisualStyleBackColor = true;
            this.btnSetControl1Down.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSetControl_MouseClick);
            // 
            // btnSetControl1Left
            // 
            this.btnSetControl1Left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetControl1Left.BackgroundImage")));
            this.btnSetControl1Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetControl1Left.FlatAppearance.BorderSize = 0;
            this.btnSetControl1Left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetControl1Left.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetControl1Left.ForeColor = System.Drawing.Color.Gold;
            this.btnSetControl1Left.Location = new System.Drawing.Point(336, 283);
            this.btnSetControl1Left.Name = "btnSetControl1Left";
            this.btnSetControl1Left.Size = new System.Drawing.Size(73, 26);
            this.btnSetControl1Left.TabIndex = 36;
            this.btnSetControl1Left.Text = "A";
            this.btnSetControl1Left.UseVisualStyleBackColor = true;
            this.btnSetControl1Left.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSetControl_MouseClick);
            // 
            // btnSetControl1Up
            // 
            this.btnSetControl1Up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetControl1Up.BackgroundImage")));
            this.btnSetControl1Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetControl1Up.FlatAppearance.BorderSize = 0;
            this.btnSetControl1Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetControl1Up.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetControl1Up.ForeColor = System.Drawing.Color.Gold;
            this.btnSetControl1Up.Location = new System.Drawing.Point(336, 245);
            this.btnSetControl1Up.Name = "btnSetControl1Up";
            this.btnSetControl1Up.Size = new System.Drawing.Size(73, 26);
            this.btnSetControl1Up.TabIndex = 35;
            this.btnSetControl1Up.Text = "W";
            this.btnSetControl1Up.UseVisualStyleBackColor = true;
            this.btnSetControl1Up.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSetControl_MouseClick);
            // 
            // labelUser2Right
            // 
            this.labelUser2Right.AutoSize = true;
            this.labelUser2Right.BackColor = System.Drawing.Color.Transparent;
            this.labelUser2Right.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelUser2Right.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUser2Right.Location = new System.Drawing.Point(417, 355);
            this.labelUser2Right.Name = "labelUser2Right";
            this.labelUser2Right.Size = new System.Drawing.Size(78, 26);
            this.labelUser2Right.TabIndex = 34;
            this.labelUser2Right.Text = "ВПРАВО";
            // 
            // labelUser2Down
            // 
            this.labelUser2Down.AutoSize = true;
            this.labelUser2Down.BackColor = System.Drawing.Color.Transparent;
            this.labelUser2Down.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelUser2Down.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUser2Down.Location = new System.Drawing.Point(417, 320);
            this.labelUser2Down.Name = "labelUser2Down";
            this.labelUser2Down.Size = new System.Drawing.Size(57, 26);
            this.labelUser2Down.TabIndex = 33;
            this.labelUser2Down.Text = "ВНИЗ";
            // 
            // labelUser2Left
            // 
            this.labelUser2Left.AutoSize = true;
            this.labelUser2Left.BackColor = System.Drawing.Color.Transparent;
            this.labelUser2Left.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelUser2Left.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUser2Left.Location = new System.Drawing.Point(417, 283);
            this.labelUser2Left.Name = "labelUser2Left";
            this.labelUser2Left.Size = new System.Drawing.Size(69, 26);
            this.labelUser2Left.TabIndex = 32;
            this.labelUser2Left.Text = "ВЛЕВО";
            // 
            // labelUser2Up
            // 
            this.labelUser2Up.AutoSize = true;
            this.labelUser2Up.BackColor = System.Drawing.Color.Transparent;
            this.labelUser2Up.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelUser2Up.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUser2Up.Location = new System.Drawing.Point(417, 245);
            this.labelUser2Up.Name = "labelUser2Up";
            this.labelUser2Up.Size = new System.Drawing.Size(63, 26);
            this.labelUser2Up.TabIndex = 31;
            this.labelUser2Up.Text = "ВВЕРХ";
            // 
            // labelUser1Right
            // 
            this.labelUser1Right.AutoSize = true;
            this.labelUser1Right.BackColor = System.Drawing.Color.Transparent;
            this.labelUser1Right.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelUser1Right.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUser1Right.Location = new System.Drawing.Point(251, 355);
            this.labelUser1Right.Name = "labelUser1Right";
            this.labelUser1Right.Size = new System.Drawing.Size(78, 26);
            this.labelUser1Right.TabIndex = 30;
            this.labelUser1Right.Text = "ВПРАВО";
            // 
            // labelUser1Down
            // 
            this.labelUser1Down.AutoSize = true;
            this.labelUser1Down.BackColor = System.Drawing.Color.Transparent;
            this.labelUser1Down.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelUser1Down.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUser1Down.Location = new System.Drawing.Point(251, 320);
            this.labelUser1Down.Name = "labelUser1Down";
            this.labelUser1Down.Size = new System.Drawing.Size(57, 26);
            this.labelUser1Down.TabIndex = 29;
            this.labelUser1Down.Text = "ВНИЗ";
            // 
            // labelUser1Left
            // 
            this.labelUser1Left.AutoSize = true;
            this.labelUser1Left.BackColor = System.Drawing.Color.Transparent;
            this.labelUser1Left.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelUser1Left.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUser1Left.Location = new System.Drawing.Point(251, 283);
            this.labelUser1Left.Name = "labelUser1Left";
            this.labelUser1Left.Size = new System.Drawing.Size(69, 26);
            this.labelUser1Left.TabIndex = 28;
            this.labelUser1Left.Text = "ВЛЕВО";
            // 
            // labelUser1Up
            // 
            this.labelUser1Up.AutoSize = true;
            this.labelUser1Up.BackColor = System.Drawing.Color.Transparent;
            this.labelUser1Up.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelUser1Up.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUser1Up.Location = new System.Drawing.Point(251, 245);
            this.labelUser1Up.Name = "labelUser1Up";
            this.labelUser1Up.Size = new System.Drawing.Size(63, 26);
            this.labelUser1Up.TabIndex = 27;
            this.labelUser1Up.Text = "ВВЕРХ";
            // 
            // labelControlSettings
            // 
            this.labelControlSettings.AutoSize = true;
            this.labelControlSettings.BackColor = System.Drawing.Color.Transparent;
            this.labelControlSettings.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelControlSettings.ForeColor = System.Drawing.Color.Gold;
            this.labelControlSettings.Location = new System.Drawing.Point(299, 177);
            this.labelControlSettings.Name = "labelControlSettings";
            this.labelControlSettings.Size = new System.Drawing.Size(224, 26);
            this.labelControlSettings.TabIndex = 26;
            this.labelControlSettings.Text = "НАСТРОЙКИ УПРАВЛЕНИЯ";
            // 
            // checkBoxClickMoves
            // 
            this.checkBoxClickMoves.AutoSize = true;
            this.checkBoxClickMoves.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxClickMoves.Checked = true;
            this.checkBoxClickMoves.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxClickMoves.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxClickMoves.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxClickMoves.Location = new System.Drawing.Point(304, 135);
            this.checkBoxClickMoves.Name = "checkBoxClickMoves";
            this.checkBoxClickMoves.Size = new System.Drawing.Size(133, 30);
            this.checkBoxClickMoves.TabIndex = 25;
            this.checkBoxClickMoves.Text = "  АВТОХОДЫ";
            this.checkBoxClickMoves.UseVisualStyleBackColor = false;
            this.checkBoxClickMoves.Paint += new System.Windows.Forms.PaintEventHandler(this.checkBox_Paint);
            // 
            // checkBoxSound
            // 
            this.checkBoxSound.AutoSize = true;
            this.checkBoxSound.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxSound.Enabled = false;
            this.checkBoxSound.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSound.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxSound.Location = new System.Drawing.Point(304, 99);
            this.checkBoxSound.Name = "checkBoxSound";
            this.checkBoxSound.Size = new System.Drawing.Size(83, 30);
            this.checkBoxSound.TabIndex = 24;
            this.checkBoxSound.Text = "  ЗВУК";
            this.checkBoxSound.UseVisualStyleBackColor = false;
            this.checkBoxSound.Paint += new System.Windows.Forms.PaintEventHandler(this.checkBox_Paint);
            // 
            // btnSettingsReturn
            // 
            this.btnSettingsReturn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSettingsReturn.BackgroundImage = global::Sokoban.Properties.Resources.button_large_normal;
            this.btnSettingsReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettingsReturn.FlatAppearance.BorderSize = 0;
            this.btnSettingsReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsReturn.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSettingsReturn.ForeColor = System.Drawing.Color.Gold;
            this.btnSettingsReturn.Location = new System.Drawing.Point(232, 463);
            this.btnSettingsReturn.Name = "btnSettingsReturn";
            this.btnSettingsReturn.Size = new System.Drawing.Size(336, 42);
            this.btnSettingsReturn.TabIndex = 23;
            this.btnSettingsReturn.Text = "&ВЕРНУТЬСЯ";
            this.btnSettingsReturn.UseVisualStyleBackColor = true;
            this.btnSettingsReturn.Click += new System.EventHandler(this.btnReturn_Click);
            this.btnSettingsReturn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseDown);
            this.btnSettingsReturn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseUp);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(808, 609);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sokoban WCII Edition";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainMenu_KeyDown);
            this.tabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMulti.ResumeLayout(false);
            this.tabMulti.PerformLayout();
            this.tabSingle.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSingleGame;
        private System.Windows.Forms.Button btnNetworkGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnEditor;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabMulti;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.RadioButton radioServer;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TabPage tabSingle;
        private System.Windows.Forms.RadioButton radioClient;
        private System.Windows.Forms.Button btnMultiReturn;
        private System.Windows.Forms.Button btnNetCustomStart;
        private System.Windows.Forms.Button btnCampaign;
        private System.Windows.Forms.Button btnCustom1P;
        private System.Windows.Forms.Button btnSingleReturn;
        private System.Windows.Forms.Button btnCustom2P;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Button btnSettingsReturn;
        private System.Windows.Forms.CheckBox checkBoxSound;
        private System.Windows.Forms.CheckBox checkBoxClickMoves;
        private System.Windows.Forms.Label labelUser1Up;
        private System.Windows.Forms.Label labelControlSettings;
        private System.Windows.Forms.Button btnSetControl2Right;
        private System.Windows.Forms.Button btnSetControl2Down;
        private System.Windows.Forms.Button btnSetControl2Left;
        private System.Windows.Forms.Button btnSetControl2Up;
        private System.Windows.Forms.Button btnSetControl1Right;
        private System.Windows.Forms.Button btnSetControl1Down;
        private System.Windows.Forms.Button btnSetControl1Left;
        private System.Windows.Forms.Button btnSetControl1Up;
        private System.Windows.Forms.Label labelUser2Right;
        private System.Windows.Forms.Label labelUser2Down;
        private System.Windows.Forms.Label labelUser2Left;
        private System.Windows.Forms.Label labelUser2Up;
        private System.Windows.Forms.Label labelUser1Right;
        private System.Windows.Forms.Label labelUser1Down;
        private System.Windows.Forms.Label labelUser1Left;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}