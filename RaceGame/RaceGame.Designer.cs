namespace Race
{
	partial class RaceGame
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaceGame));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            timerRoad = new System.Windows.Forms.Timer(components);
            timerTowardCars = new System.Windows.Forms.Timer(components);
            timerMenu = new System.Windows.Forms.Timer(components);
            MiddleLane = new Label();
            LaneOne1 = new Label();
            LaneOne2 = new Label();
            LaneOne3 = new Label();
            LaneOne4 = new Label();
            LaneOne5 = new Label();
            LaneTwo1 = new Label();
            LaneTwo2 = new Label();
            LaneTwo3 = new Label();
            LaneTwo4 = new Label();
            LaneTwo5 = new Label();
            mainCar = new PictureBox();
            buttonPause = new Button();
            Coin1 = new PictureBox();
            Coin2 = new PictureBox();
            Coin3 = new PictureBox();
            towardCar3 = new PictureBox();
            towardCar1 = new PictureBox();
            towardCar2 = new PictureBox();
            label = new Label();
            labelCoins = new Label();
            labelScore = new Label();
            panelGame = new Panel();
            panelPause = new Panel();
            panelMenu = new Panel();
            panelStatistics = new Panel();
            labelStatisticsText = new Label();
            buttonReturnToMenu = new Button();
            dataGridViewStatistics = new DataGridView();
            textBoxName = new TextBox();
            buttonStatistics = new Button();
            buttonHelp = new Button();
            buttonMenuExit = new Button();
            buttonStart = new Button();
            label3 = new Label();
            CarMenu1 = new PictureBox();
            CarMenu3 = new PictureBox();
            CarMenu2 = new PictureBox();
            MenuTwoLane5 = new Label();
            MenuTwoLane4 = new Label();
            MenuTwoLane3 = new Label();
            MenuTwoLane2 = new Label();
            MenuTwoLane1 = new Label();
            MenuOneLane5 = new Label();
            MenuOneLane4 = new Label();
            MenuOneLane3 = new Label();
            MenuOneLane2 = new Label();
            MenuOneLane1 = new Label();
            label12 = new Label();
            buttonExit = new Button();
            buttonResume = new Button();
            pictureFlag = new PictureBox();
            labelPause = new Label();
            columnName = new DataGridViewTextBoxColumn();
            Scores = new DataGridViewTextBoxColumn();
            Coins = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)mainCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Coin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Coin2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Coin3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)towardCar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)towardCar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)towardCar2).BeginInit();
            panelGame.SuspendLayout();
            panelPause.SuspendLayout();
            panelMenu.SuspendLayout();
            panelStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatistics).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CarMenu1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CarMenu3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CarMenu2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureFlag).BeginInit();
            SuspendLayout();
            // 
            // timerRoad
            // 
            timerRoad.Enabled = true;
            timerRoad.Interval = 1;
            timerRoad.Tick += TimerRoadTick;
            // 
            // timerTowardCars
            // 
            timerTowardCars.Enabled = true;
            timerTowardCars.Interval = 1;
            timerTowardCars.Tick += TimerTowardCarsTick;
            // 
            // timerMenu
            // 
            timerMenu.Enabled = true;
            timerMenu.Interval = 1;
            timerMenu.Tick += TimerMenuTick;
            // 
            // MiddleLane
            // 
            MiddleLane.BackColor = Color.White;
            MiddleLane.ForeColor = SystemColors.Control;
            MiddleLane.Location = new Point(214, -4);
            MiddleLane.Margin = new Padding(4, 0, 4, 0);
            MiddleLane.Name = "MiddleLane";
            MiddleLane.Size = new Size(20, 654);
            MiddleLane.TabIndex = 33;
            MiddleLane.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LaneOne1
            // 
            LaneOne1.BackColor = Color.White;
            LaneOne1.ForeColor = SystemColors.Control;
            LaneOne1.Location = new Point(104, -37);
            LaneOne1.Margin = new Padding(4, 0, 4, 0);
            LaneOne1.Name = "LaneOne1";
            LaneOne1.Size = new Size(18, 104);
            LaneOne1.TabIndex = 34;
            LaneOne1.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneOne2
            // 
            LaneOne2.BackColor = Color.White;
            LaneOne2.ForeColor = SystemColors.Control;
            LaneOne2.Location = new Point(104, 124);
            LaneOne2.Margin = new Padding(4, 0, 4, 0);
            LaneOne2.Name = "LaneOne2";
            LaneOne2.Size = new Size(18, 104);
            LaneOne2.TabIndex = 35;
            LaneOne2.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneOne3
            // 
            LaneOne3.BackColor = Color.White;
            LaneOne3.ForeColor = SystemColors.Control;
            LaneOne3.Location = new Point(104, 286);
            LaneOne3.Margin = new Padding(4, 0, 4, 0);
            LaneOne3.Name = "LaneOne3";
            LaneOne3.Size = new Size(18, 104);
            LaneOne3.TabIndex = 36;
            LaneOne3.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneOne4
            // 
            LaneOne4.BackColor = Color.White;
            LaneOne4.ForeColor = SystemColors.Control;
            LaneOne4.Location = new Point(104, 448);
            LaneOne4.Margin = new Padding(4, 0, 4, 0);
            LaneOne4.Name = "LaneOne4";
            LaneOne4.Size = new Size(18, 104);
            LaneOne4.TabIndex = 37;
            LaneOne4.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneOne5
            // 
            LaneOne5.BackColor = Color.White;
            LaneOne5.ForeColor = SystemColors.Control;
            LaneOne5.Location = new Point(104, 609);
            LaneOne5.Margin = new Padding(4, 0, 4, 0);
            LaneOne5.Name = "LaneOne5";
            LaneOne5.Size = new Size(18, 104);
            LaneOne5.TabIndex = 38;
            LaneOne5.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneTwo1
            // 
            LaneTwo1.BackColor = Color.White;
            LaneTwo1.ForeColor = SystemColors.Control;
            LaneTwo1.Location = new Point(337, -37);
            LaneTwo1.Margin = new Padding(4, 0, 4, 0);
            LaneTwo1.Name = "LaneTwo1";
            LaneTwo1.Size = new Size(18, 104);
            LaneTwo1.TabIndex = 39;
            LaneTwo1.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneTwo2
            // 
            LaneTwo2.BackColor = Color.White;
            LaneTwo2.ForeColor = SystemColors.Control;
            LaneTwo2.Location = new Point(337, 124);
            LaneTwo2.Margin = new Padding(4, 0, 4, 0);
            LaneTwo2.Name = "LaneTwo2";
            LaneTwo2.Size = new Size(18, 104);
            LaneTwo2.TabIndex = 40;
            LaneTwo2.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneTwo3
            // 
            LaneTwo3.BackColor = Color.White;
            LaneTwo3.ForeColor = SystemColors.Control;
            LaneTwo3.Location = new Point(337, 286);
            LaneTwo3.Margin = new Padding(4, 0, 4, 0);
            LaneTwo3.Name = "LaneTwo3";
            LaneTwo3.Size = new Size(18, 104);
            LaneTwo3.TabIndex = 41;
            LaneTwo3.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneTwo4
            // 
            LaneTwo4.BackColor = Color.White;
            LaneTwo4.ForeColor = SystemColors.Control;
            LaneTwo4.Location = new Point(337, 447);
            LaneTwo4.Margin = new Padding(4, 0, 4, 0);
            LaneTwo4.Name = "LaneTwo4";
            LaneTwo4.Size = new Size(18, 104);
            LaneTwo4.TabIndex = 42;
            LaneTwo4.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneTwo5
            // 
            LaneTwo5.BackColor = Color.White;
            LaneTwo5.ForeColor = SystemColors.Control;
            LaneTwo5.Location = new Point(337, 609);
            LaneTwo5.Margin = new Padding(4, 0, 4, 0);
            LaneTwo5.Name = "LaneTwo5";
            LaneTwo5.Size = new Size(18, 104);
            LaneTwo5.TabIndex = 43;
            LaneTwo5.TextAlign = ContentAlignment.TopCenter;
            // 
            // mainCar
            // 
            mainCar.BackColor = Color.Transparent;
            mainCar.BackgroundImageLayout = ImageLayout.None;
            mainCar.Image = (Image)resources.GetObject("mainCar.Image");
            mainCar.Location = new Point(258, 508);
            mainCar.Margin = new Padding(4);
            mainCar.Name = "mainCar";
            mainCar.Size = new Size(59, 127);
            mainCar.SizeMode = PictureBoxSizeMode.Zoom;
            mainCar.TabIndex = 47;
            mainCar.TabStop = false;
            // 
            // buttonPause
            // 
            buttonPause.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPause.Location = new Point(0, 602);
            buttonPause.Margin = new Padding(4);
            buttonPause.Name = "buttonPause";
            buttonPause.Size = new Size(95, 44);
            buttonPause.TabIndex = 1;
            buttonPause.Text = "Pause";
            buttonPause.UseVisualStyleBackColor = true;
            buttonPause.Click += ButtonPauseClick;
            // 
            // Coin1
            // 
            Coin1.BackColor = Color.Transparent;
            Coin1.Image = (Image)resources.GetObject("Coin1.Image");
            Coin1.Location = new Point(129, 291);
            Coin1.Margin = new Padding(4);
            Coin1.Name = "Coin1";
            Coin1.Size = new Size(39, 37);
            Coin1.SizeMode = PictureBoxSizeMode.Zoom;
            Coin1.TabIndex = 52;
            Coin1.TabStop = false;
            // 
            // Coin2
            // 
            Coin2.BackColor = Color.Transparent;
            Coin2.Image = (Image)resources.GetObject("Coin2.Image");
            Coin2.Location = new Point(258, 180);
            Coin2.Margin = new Padding(4);
            Coin2.Name = "Coin2";
            Coin2.Size = new Size(39, 37);
            Coin2.SizeMode = PictureBoxSizeMode.Zoom;
            Coin2.TabIndex = 53;
            Coin2.TabStop = false;
            // 
            // Coin3
            // 
            Coin3.BackColor = Color.Transparent;
            Coin3.Image = (Image)resources.GetObject("Coin3.Image");
            Coin3.Location = new Point(375, 257);
            Coin3.Margin = new Padding(4);
            Coin3.Name = "Coin3";
            Coin3.Size = new Size(39, 37);
            Coin3.SizeMode = PictureBoxSizeMode.Zoom;
            Coin3.TabIndex = 54;
            Coin3.TabStop = false;
            // 
            // towardCar3
            // 
            towardCar3.BackColor = Color.Transparent;
            towardCar3.Image = (Image)resources.GetObject("towardCar3.Image");
            towardCar3.Location = new Point(375, 41);
            towardCar3.Margin = new Padding(4);
            towardCar3.Name = "towardCar3";
            towardCar3.Size = new Size(59, 127);
            towardCar3.SizeMode = PictureBoxSizeMode.Zoom;
            towardCar3.TabIndex = 50;
            towardCar3.TabStop = false;
            // 
            // towardCar1
            // 
            towardCar1.BackColor = Color.Transparent;
            towardCar1.Image = (Image)resources.GetObject("towardCar1.Image");
            towardCar1.Location = new Point(150, 15);
            towardCar1.Margin = new Padding(4);
            towardCar1.Name = "towardCar1";
            towardCar1.Size = new Size(59, 127);
            towardCar1.SizeMode = PictureBoxSizeMode.Zoom;
            towardCar1.TabIndex = 48;
            towardCar1.TabStop = false;
            // 
            // towardCar2
            // 
            towardCar2.BackColor = Color.Transparent;
            towardCar2.Image = (Image)resources.GetObject("towardCar2.Image");
            towardCar2.Location = new Point(14, 26);
            towardCar2.Margin = new Padding(4);
            towardCar2.Name = "towardCar2";
            towardCar2.Size = new Size(59, 127);
            towardCar2.SizeMode = PictureBoxSizeMode.Zoom;
            towardCar2.TabIndex = 49;
            towardCar2.TabStop = false;
            // 
            // label
            // 
            label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label.BackColor = SystemColors.ActiveCaptionText;
            label.Font = new Font("Microsoft Sans Serif", 100F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = SystemColors.ControlText;
            label.Location = new Point(-3, 0);
            label.Margin = new Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new Size(451, 68);
            label.TabIndex = 55;
            // 
            // labelCoins
            // 
            labelCoins.AutoSize = true;
            labelCoins.BackColor = Color.Black;
            labelCoins.Font = new Font("Microsoft YaHei", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelCoins.ForeColor = SystemColors.ButtonHighlight;
            labelCoins.Location = new Point(242, 10);
            labelCoins.Margin = new Padding(4, 0, 4, 0);
            labelCoins.Name = "labelCoins";
            labelCoins.Size = new Size(109, 40);
            labelCoins.TabIndex = 57;
            labelCoins.Text = "Coins:";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.BackColor = Color.Black;
            labelScore.Font = new Font("Microsoft YaHei", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelScore.ForeColor = SystemColors.ButtonHighlight;
            labelScore.Location = new Point(14, 10);
            labelScore.Margin = new Padding(4, 0, 4, 0);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(110, 40);
            labelScore.TabIndex = 56;
            labelScore.Text = "Score:";
            // 
            // panelGame
            // 
            panelGame.BackColor = SystemColors.ControlDarkDark;
            panelGame.Controls.Add(panelPause);
            panelGame.Controls.Add(labelScore);
            panelGame.Controls.Add(labelCoins);
            panelGame.Controls.Add(label);
            panelGame.Controls.Add(towardCar2);
            panelGame.Controls.Add(towardCar1);
            panelGame.Controls.Add(towardCar3);
            panelGame.Controls.Add(Coin3);
            panelGame.Controls.Add(Coin2);
            panelGame.Controls.Add(Coin1);
            panelGame.Controls.Add(buttonPause);
            panelGame.Controls.Add(mainCar);
            panelGame.Controls.Add(LaneTwo5);
            panelGame.Controls.Add(LaneTwo4);
            panelGame.Controls.Add(LaneTwo3);
            panelGame.Controls.Add(LaneTwo2);
            panelGame.Controls.Add(LaneTwo1);
            panelGame.Controls.Add(LaneOne5);
            panelGame.Controls.Add(LaneOne4);
            panelGame.Controls.Add(LaneOne3);
            panelGame.Controls.Add(LaneOne2);
            panelGame.Controls.Add(LaneOne1);
            panelGame.Controls.Add(MiddleLane);
            panelGame.Location = new Point(0, 0);
            panelGame.Margin = new Padding(4);
            panelGame.Name = "panelGame";
            panelGame.Size = new Size(448, 650);
            panelGame.TabIndex = 0;
            // 
            // panelPause
            // 
            panelPause.BackColor = SystemColors.ControlDarkDark;
            panelPause.Controls.Add(panelMenu);
            panelPause.Controls.Add(buttonExit);
            panelPause.Controls.Add(buttonResume);
            panelPause.Controls.Add(pictureFlag);
            panelPause.Controls.Add(labelPause);
            panelPause.Location = new Point(0, 0);
            panelPause.Margin = new Padding(4);
            panelPause.Name = "panelPause";
            panelPause.Size = new Size(451, 654);
            panelPause.TabIndex = 57;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ControlDarkDark;
            panelMenu.Controls.Add(panelStatistics);
            panelMenu.Controls.Add(textBoxName);
            panelMenu.Controls.Add(buttonStatistics);
            panelMenu.Controls.Add(buttonHelp);
            panelMenu.Controls.Add(buttonMenuExit);
            panelMenu.Controls.Add(buttonStart);
            panelMenu.Controls.Add(label3);
            panelMenu.Controls.Add(CarMenu1);
            panelMenu.Controls.Add(CarMenu3);
            panelMenu.Controls.Add(CarMenu2);
            panelMenu.Controls.Add(MenuTwoLane5);
            panelMenu.Controls.Add(MenuTwoLane4);
            panelMenu.Controls.Add(MenuTwoLane3);
            panelMenu.Controls.Add(MenuTwoLane2);
            panelMenu.Controls.Add(MenuTwoLane1);
            panelMenu.Controls.Add(MenuOneLane5);
            panelMenu.Controls.Add(MenuOneLane4);
            panelMenu.Controls.Add(MenuOneLane3);
            panelMenu.Controls.Add(MenuOneLane2);
            panelMenu.Controls.Add(MenuOneLane1);
            panelMenu.Controls.Add(label12);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(451, 650);
            panelMenu.TabIndex = 57;
            // 
            // panelStatistics
            // 
            panelStatistics.Controls.Add(labelStatisticsText);
            panelStatistics.Controls.Add(buttonReturnToMenu);
            panelStatistics.Controls.Add(dataGridViewStatistics);
            panelStatistics.Location = new Point(0, 0);
            panelStatistics.Name = "panelStatistics";
            panelStatistics.Size = new Size(451, 650);
            panelStatistics.TabIndex = 85;
            // 
            // labelStatisticsText
            // 
            labelStatisticsText.AutoSize = true;
            labelStatisticsText.BackColor = SystemColors.ButtonFace;
            labelStatisticsText.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelStatisticsText.ForeColor = SystemColors.ActiveCaptionText;
            labelStatisticsText.Location = new Point(166, 10);
            labelStatisticsText.Name = "labelStatisticsText";
            labelStatisticsText.Size = new Size(109, 17);
            labelStatisticsText.TabIndex = 1;
            labelStatisticsText.Text = "Статистика игр";
            // 
            // buttonReturnToMenu
            // 
            buttonReturnToMenu.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReturnToMenu.Location = new Point(176, 612);
            buttonReturnToMenu.Name = "buttonReturnToMenu";
            buttonReturnToMenu.Size = new Size(75, 34);
            buttonReturnToMenu.TabIndex = 0;
            buttonReturnToMenu.Text = "Return";
            buttonReturnToMenu.UseVisualStyleBackColor = true;
            buttonReturnToMenu.Click += ButtonReturnToMenuClick;
            // 
            // dataGridViewStatistics
            // 
            dataGridViewStatistics.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewStatistics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewStatistics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStatistics.Columns.AddRange(new DataGridViewColumn[] { columnName, Scores, Coins, Date });
            dataGridViewStatistics.Location = new Point(0, 30);
            dataGridViewStatistics.Name = "dataGridViewStatistics";
            dataGridViewStatistics.RowHeadersVisible = false;
            dataGridViewStatistics.RowTemplate.Height = 25;
            dataGridViewStatistics.Size = new Size(448, 576);
            dataGridViewStatistics.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(150, 299);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(152, 25);
            textBoxName.TabIndex = 84;
            textBoxName.Text = "guest";
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonStatistics
            // 
            buttonStatistics.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStatistics.Location = new Point(150, 380);
            buttonStatistics.Margin = new Padding(4);
            buttonStatistics.Name = "buttonStatistics";
            buttonStatistics.Size = new Size(152, 43);
            buttonStatistics.TabIndex = 83;
            buttonStatistics.Text = "Statistics";
            buttonStatistics.UseVisualStyleBackColor = true;
            buttonStatistics.Click += ButtonStatisticsClick;
            // 
            // buttonHelp
            // 
            buttonHelp.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHelp.Location = new Point(361, 609);
            buttonHelp.Margin = new Padding(4);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(81, 37);
            buttonHelp.TabIndex = 82;
            buttonHelp.Text = "Help";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += ButtonHelpClick;
            // 
            // buttonMenuExit
            // 
            buttonMenuExit.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMenuExit.Location = new Point(166, 431);
            buttonMenuExit.Margin = new Padding(4);
            buttonMenuExit.Name = "buttonMenuExit";
            buttonMenuExit.Size = new Size(118, 40);
            buttonMenuExit.TabIndex = 67;
            buttonMenuExit.Text = "Exit";
            buttonMenuExit.UseVisualStyleBackColor = true;
            buttonMenuExit.Click += ButtonMenuExitClick;
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.Location = new Point(139, 329);
            buttonStart.Margin = new Padding(4);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(172, 43);
            buttonStart.TabIndex = 65;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += ButtonStartClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 64, 64);
            label3.Font = new Font("Microsoft Tai Le", 105F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(384, 178);
            label3.TabIndex = 66;
            label3.Text = "Race";
            // 
            // CarMenu1
            // 
            CarMenu1.BackColor = Color.Transparent;
            CarMenu1.Image = (Image)resources.GetObject("CarMenu1.Image");
            CarMenu1.Location = new Point(14, 15);
            CarMenu1.Margin = new Padding(4);
            CarMenu1.Name = "CarMenu1";
            CarMenu1.Size = new Size(59, 127);
            CarMenu1.SizeMode = PictureBoxSizeMode.Zoom;
            CarMenu1.TabIndex = 80;
            CarMenu1.TabStop = false;
            // 
            // CarMenu3
            // 
            CarMenu3.BackColor = Color.Transparent;
            CarMenu3.Image = (Image)resources.GetObject("CarMenu3.Image");
            CarMenu3.Location = new Point(375, 30);
            CarMenu3.Margin = new Padding(4);
            CarMenu3.Name = "CarMenu3";
            CarMenu3.Size = new Size(59, 127);
            CarMenu3.SizeMode = PictureBoxSizeMode.Zoom;
            CarMenu3.TabIndex = 81;
            CarMenu3.TabStop = false;
            // 
            // CarMenu2
            // 
            CarMenu2.BackColor = Color.Transparent;
            CarMenu2.Image = (Image)resources.GetObject("CarMenu2.Image");
            CarMenu2.Location = new Point(150, 4);
            CarMenu2.Margin = new Padding(4);
            CarMenu2.Name = "CarMenu2";
            CarMenu2.Size = new Size(59, 127);
            CarMenu2.SizeMode = PictureBoxSizeMode.Zoom;
            CarMenu2.TabIndex = 79;
            CarMenu2.TabStop = false;
            // 
            // MenuTwoLane5
            // 
            MenuTwoLane5.BackColor = Color.White;
            MenuTwoLane5.ForeColor = SystemColors.Control;
            MenuTwoLane5.Location = new Point(337, 598);
            MenuTwoLane5.Margin = new Padding(4, 0, 4, 0);
            MenuTwoLane5.Name = "MenuTwoLane5";
            MenuTwoLane5.Size = new Size(18, 104);
            MenuTwoLane5.TabIndex = 78;
            MenuTwoLane5.TextAlign = ContentAlignment.TopCenter;
            // 
            // MenuTwoLane4
            // 
            MenuTwoLane4.BackColor = Color.White;
            MenuTwoLane4.ForeColor = SystemColors.Control;
            MenuTwoLane4.Location = new Point(337, 436);
            MenuTwoLane4.Margin = new Padding(4, 0, 4, 0);
            MenuTwoLane4.Name = "MenuTwoLane4";
            MenuTwoLane4.Size = new Size(18, 104);
            MenuTwoLane4.TabIndex = 77;
            MenuTwoLane4.TextAlign = ContentAlignment.TopCenter;
            // 
            // MenuTwoLane3
            // 
            MenuTwoLane3.BackColor = Color.White;
            MenuTwoLane3.ForeColor = SystemColors.Control;
            MenuTwoLane3.Location = new Point(337, 274);
            MenuTwoLane3.Margin = new Padding(4, 0, 4, 0);
            MenuTwoLane3.Name = "MenuTwoLane3";
            MenuTwoLane3.Size = new Size(18, 104);
            MenuTwoLane3.TabIndex = 76;
            MenuTwoLane3.TextAlign = ContentAlignment.TopCenter;
            // 
            // MenuTwoLane2
            // 
            MenuTwoLane2.BackColor = Color.White;
            MenuTwoLane2.ForeColor = SystemColors.Control;
            MenuTwoLane2.Location = new Point(337, 113);
            MenuTwoLane2.Margin = new Padding(4, 0, 4, 0);
            MenuTwoLane2.Name = "MenuTwoLane2";
            MenuTwoLane2.Size = new Size(18, 104);
            MenuTwoLane2.TabIndex = 75;
            MenuTwoLane2.TextAlign = ContentAlignment.TopCenter;
            // 
            // MenuTwoLane1
            // 
            MenuTwoLane1.BackColor = Color.White;
            MenuTwoLane1.ForeColor = SystemColors.Control;
            MenuTwoLane1.Location = new Point(337, -49);
            MenuTwoLane1.Margin = new Padding(4, 0, 4, 0);
            MenuTwoLane1.Name = "MenuTwoLane1";
            MenuTwoLane1.Size = new Size(18, 104);
            MenuTwoLane1.TabIndex = 74;
            MenuTwoLane1.TextAlign = ContentAlignment.TopCenter;
            // 
            // MenuOneLane5
            // 
            MenuOneLane5.BackColor = Color.White;
            MenuOneLane5.ForeColor = SystemColors.Control;
            MenuOneLane5.Location = new Point(104, 598);
            MenuOneLane5.Margin = new Padding(4, 0, 4, 0);
            MenuOneLane5.Name = "MenuOneLane5";
            MenuOneLane5.Size = new Size(18, 104);
            MenuOneLane5.TabIndex = 73;
            MenuOneLane5.TextAlign = ContentAlignment.TopCenter;
            // 
            // MenuOneLane4
            // 
            MenuOneLane4.BackColor = Color.White;
            MenuOneLane4.ForeColor = SystemColors.Control;
            MenuOneLane4.Location = new Point(104, 436);
            MenuOneLane4.Margin = new Padding(4, 0, 4, 0);
            MenuOneLane4.Name = "MenuOneLane4";
            MenuOneLane4.Size = new Size(18, 104);
            MenuOneLane4.TabIndex = 72;
            MenuOneLane4.TextAlign = ContentAlignment.TopCenter;
            // 
            // MenuOneLane3
            // 
            MenuOneLane3.BackColor = Color.White;
            MenuOneLane3.ForeColor = SystemColors.Control;
            MenuOneLane3.Location = new Point(104, 274);
            MenuOneLane3.Margin = new Padding(4, 0, 4, 0);
            MenuOneLane3.Name = "MenuOneLane3";
            MenuOneLane3.Size = new Size(18, 104);
            MenuOneLane3.TabIndex = 71;
            MenuOneLane3.TextAlign = ContentAlignment.TopCenter;
            // 
            // MenuOneLane2
            // 
            MenuOneLane2.BackColor = Color.White;
            MenuOneLane2.ForeColor = SystemColors.Control;
            MenuOneLane2.Location = new Point(104, 113);
            MenuOneLane2.Margin = new Padding(4, 0, 4, 0);
            MenuOneLane2.Name = "MenuOneLane2";
            MenuOneLane2.Size = new Size(18, 104);
            MenuOneLane2.TabIndex = 70;
            MenuOneLane2.TextAlign = ContentAlignment.TopCenter;
            // 
            // MenuOneLane1
            // 
            MenuOneLane1.BackColor = Color.White;
            MenuOneLane1.ForeColor = SystemColors.Control;
            MenuOneLane1.Location = new Point(104, -49);
            MenuOneLane1.Margin = new Padding(4, 0, 4, 0);
            MenuOneLane1.Name = "MenuOneLane1";
            MenuOneLane1.Size = new Size(18, 104);
            MenuOneLane1.TabIndex = 69;
            MenuOneLane1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label12
            // 
            label12.BackColor = Color.White;
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(214, -4);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(20, 654);
            label12.TabIndex = 68;
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(139, 555);
            buttonExit.Margin = new Padding(4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(178, 46);
            buttonExit.TabIndex = 53;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += ButtonExitClick;
            // 
            // buttonResume
            // 
            buttonResume.Font = new Font("Microsoft YaHei", 22F, FontStyle.Bold, GraphicsUnit.Point);
            buttonResume.Location = new Point(139, 469);
            buttonResume.Margin = new Padding(4);
            buttonResume.Name = "buttonResume";
            buttonResume.Size = new Size(178, 67);
            buttonResume.TabIndex = 52;
            buttonResume.Text = "Resume";
            buttonResume.UseVisualStyleBackColor = true;
            buttonResume.Click += ButtonResumeClick;
            // 
            // pictureFlag
            // 
            pictureFlag.BackColor = SystemColors.ControlDarkDark;
            pictureFlag.Image = (Image)resources.GetObject("pictureFlag.Image");
            pictureFlag.Location = new Point(-3, 124);
            pictureFlag.Margin = new Padding(4);
            pictureFlag.Name = "pictureFlag";
            pictureFlag.Size = new Size(451, 364);
            pictureFlag.SizeMode = PictureBoxSizeMode.Zoom;
            pictureFlag.TabIndex = 55;
            pictureFlag.TabStop = false;
            // 
            // labelPause
            // 
            labelPause.AutoSize = true;
            labelPause.Font = new Font("Microsoft YaHei", 90F, FontStyle.Bold, GraphicsUnit.Point);
            labelPause.Location = new Point(0, 0);
            labelPause.Margin = new Padding(4, 0, 4, 0);
            labelPause.Name = "labelPause";
            labelPause.Size = new Size(422, 159);
            labelPause.TabIndex = 54;
            labelPause.Text = "Pause";
            // 
            // columnName
            // 
            columnName.HeaderText = "Никнейм";
            columnName.Name = "columnName";
            // 
            // Scores
            // 
            Scores.HeaderText = "Количество очков";
            Scores.Name = "Scores";
            // 
            // Coins
            // 
            Coins.HeaderText = "Количество монет";
            Coins.Name = "Coins";
            // 
            // Date
            // 
            Date.HeaderText = "Дата";
            Date.Name = "Date";
            Date.Width = 145;
            // 
            // RaceGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(448, 649);
            Controls.Add(panelGame);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "RaceGame";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Race";
            Load += RaceGameLoad;
            KeyDown += RaceGameKeyDown;
            ((System.ComponentModel.ISupportInitialize)mainCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Coin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Coin2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Coin3).EndInit();
            ((System.ComponentModel.ISupportInitialize)towardCar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)towardCar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)towardCar2).EndInit();
            panelGame.ResumeLayout(false);
            panelGame.PerformLayout();
            panelPause.ResumeLayout(false);
            panelPause.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelStatistics.ResumeLayout(false);
            panelStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatistics).EndInit();
            ((System.ComponentModel.ISupportInitialize)CarMenu1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CarMenu3).EndInit();
            ((System.ComponentModel.ISupportInitialize)CarMenu2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureFlag).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timerRoad;
		private System.Windows.Forms.Timer timerTowardCars;
		private System.Windows.Forms.Timer timerMenu;
        private Label MiddleLane;
        private Label LaneOne1;
        private Label LaneOne2;
        private Label LaneOne3;
        private Label LaneOne4;
        private Label LaneOne5;
        private Label LaneTwo1;
        private Label LaneTwo2;
        private Label LaneTwo3;
        private Label LaneTwo4;
        private Label LaneTwo5;
        private PictureBox mainCar;
        private Button buttonPause;
        private PictureBox Coin1;
        private PictureBox Coin2;
        private PictureBox Coin3;
        private PictureBox towardCar3;
        private PictureBox towardCar1;
        private PictureBox towardCar2;
        private Label label;
        private Label labelCoins;
        private Label labelScore;
        private Panel panelGame;
        private Panel panelPause;
        private Panel panelMenu;
        private TextBox textBoxName;
        private Button buttonStatistics;
        private Button buttonHelp;
        private Button buttonMenuExit;
        private Button buttonStart;
        private Label label3;
        private PictureBox CarMenu1;
        private PictureBox CarMenu3;
        private PictureBox CarMenu2;
        private Label MenuTwoLane5;
        private Label MenuTwoLane4;
        private Label MenuTwoLane3;
        private Label MenuTwoLane2;
        private Label MenuTwoLane1;
        private Label MenuOneLane5;
        private Label MenuOneLane4;
        private Label MenuOneLane3;
        private Label MenuOneLane2;
        private Label MenuOneLane1;
        private Label label12;
        private Button buttonExit;
        private Button buttonResume;
        private PictureBox pictureFlag;
        private Label labelPause;
        private Panel panelStatistics;
        private Button buttonReturnToMenu;
        private DataGridView dataGridViewStatistics;
        private Label labelStatisticsText;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn Scores;
        private DataGridViewTextBoxColumn Coins;
        private DataGridViewTextBoxColumn Date;
    }
}