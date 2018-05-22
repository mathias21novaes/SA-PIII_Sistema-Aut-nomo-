namespace BlackJack
{
	partial class MainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this._statistics = new System.Windows.Forms.ListView();
			this._playerName = new System.Windows.Forms.ColumnHeader();
			this._wins = new System.Windows.Forms.ColumnHeader();
			this._draws = new System.Windows.Forms.ColumnHeader();
			this._looses = new System.Windows.Forms.ColumnHeader();
			this._toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this._newGameButton = new System.Windows.Forms.ToolStripButton();
			this._stopGameButton = new System.Windows.Forms.ToolStripButton();
			this._pauseGameButton = new System.Windows.Forms.ToolStripButton();
			this._continueGameButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this._playersButton = new System.Windows.Forms.ToolStripButton();
			this._optionsButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
			this._aboutButton = new System.Windows.Forms.ToolStripButton();
			this._statusStrip = new System.Windows.Forms.StatusStrip();
			this._gameStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this._currentRoundStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this._progressLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this._gameProgressStatus = new System.Windows.Forms.ToolStripProgressBar();
			this._menuStrip = new System.Windows.Forms.MenuStrip();
			this._gameMenu = new System.Windows.Forms.ToolStripMenuItem();
			this._newGameMenu = new System.Windows.Forms.ToolStripMenuItem();
			this._stopGameMenu = new System.Windows.Forms.ToolStripMenuItem();
			this._pauseGameMenu = new System.Windows.Forms.ToolStripMenuItem();
			this._continueGameMenu = new System.Windows.Forms.ToolStripMenuItem();
			this._exitMenu = new System.Windows.Forms.ToolStripMenuItem();
			this._settingsMenu = new System.Windows.Forms.ToolStripMenuItem();
			this._playersMenu = new System.Windows.Forms.ToolStripMenuItem();
			this._optionsMenu = new System.Windows.Forms.ToolStripMenuItem();
			this._helpMenu = new System.Windows.Forms.ToolStripMenuItem();
			this._aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
			this._roundLabel = new System.Windows.Forms.Label();
			this._playerNameLabel = new System.Windows.Forms.Label();
			this._sumLabel = new System.Windows.Forms.Label();
			this._winnerNameLabel = new System.Windows.Forms.Label();
			this._toolStrip.SuspendLayout();
			this._statusStrip.SuspendLayout();
			this._menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// _statistics
			// 
			this._statistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this._statistics.BackColor = System.Drawing.Color.Green;
			this._statistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._playerName,
            this._wins,
            this._draws,
            this._looses});
			this._statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._statistics.ForeColor = System.Drawing.Color.PowderBlue;
			this._statistics.FullRowSelect = true;
			this._statistics.GridLines = true;
			this._statistics.Location = new System.Drawing.Point(12, 368);
			this._statistics.Name = "_statistics";
			this._statistics.Size = new System.Drawing.Size(848, 207);
			this._statistics.TabIndex = 0;
			this._statistics.UseCompatibleStateImageBehavior = false;
			this._statistics.View = System.Windows.Forms.View.Details;
			// 
			// _playerName
			// 
			this._playerName.Text = "Player\'s Name";
			this._playerName.Width = 400;
			// 
			// _wins
			// 
			this._wins.Text = "Wins";
			this._wins.Width = 100;
			// 
			// _draws
			// 
			this._draws.Text = "Draws";
			this._draws.Width = 100;
			// 
			// _looses
			// 
			this._looses.Text = "Looses";
			this._looses.Width = 100;
			// 
			// _toolStrip
			// 
			this._toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
			this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this._newGameButton,
            this._stopGameButton,
            this._pauseGameButton,
            this._continueGameButton,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this._playersButton,
            this._optionsButton,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this._aboutButton});
			this._toolStrip.Location = new System.Drawing.Point(0, 24);
			this._toolStrip.Name = "_toolStrip";
			this._toolStrip.Size = new System.Drawing.Size(873, 39);
			this._toolStrip.TabIndex = 1;
			this._toolStrip.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(41, 36);
			this.toolStripLabel1.Text = "Game:";
			// 
			// _newGameButton
			// 
			this._newGameButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._newGameButton.Image = ((System.Drawing.Image)(resources.GetObject("_newGameButton.Image")));
			this._newGameButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._newGameButton.Name = "_newGameButton";
			this._newGameButton.Size = new System.Drawing.Size(36, 36);
			this._newGameButton.Text = "New Game";
			this._newGameButton.Click += new System.EventHandler(this._newGameButton_Click);
			// 
			// _stopGameButton
			// 
			this._stopGameButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._stopGameButton.Image = ((System.Drawing.Image)(resources.GetObject("_stopGameButton.Image")));
			this._stopGameButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._stopGameButton.Name = "_stopGameButton";
			this._stopGameButton.Size = new System.Drawing.Size(36, 36);
			this._stopGameButton.Text = "Stop Game";
			this._stopGameButton.Click += new System.EventHandler(this._stopGameButton_Click);
			// 
			// _pauseGameButton
			// 
			this._pauseGameButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._pauseGameButton.Image = ((System.Drawing.Image)(resources.GetObject("_pauseGameButton.Image")));
			this._pauseGameButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._pauseGameButton.Name = "_pauseGameButton";
			this._pauseGameButton.Size = new System.Drawing.Size(36, 36);
			this._pauseGameButton.Text = "Pause Game";
			this._pauseGameButton.Click += new System.EventHandler(this._pauseGameButton_Click);
			// 
			// _continueGameButton
			// 
			this._continueGameButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._continueGameButton.Image = ((System.Drawing.Image)(resources.GetObject("_continueGameButton.Image")));
			this._continueGameButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._continueGameButton.Name = "_continueGameButton";
			this._continueGameButton.Size = new System.Drawing.Size(36, 36);
			this._continueGameButton.Text = "Continue Game";
			this._continueGameButton.Click += new System.EventHandler(this._continueGameButton_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(52, 36);
			this.toolStripLabel2.Text = "Settings:";
			// 
			// _playersButton
			// 
			this._playersButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._playersButton.Image = ((System.Drawing.Image)(resources.GetObject("_playersButton.Image")));
			this._playersButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._playersButton.Name = "_playersButton";
			this._playersButton.Size = new System.Drawing.Size(36, 36);
			this._playersButton.Text = "Players";
			this._playersButton.Click += new System.EventHandler(this._playersButton_Click);
			// 
			// _optionsButton
			// 
			this._optionsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._optionsButton.Image = ((System.Drawing.Image)(resources.GetObject("_optionsButton.Image")));
			this._optionsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._optionsButton.Name = "_optionsButton";
			this._optionsButton.Size = new System.Drawing.Size(36, 36);
			this._optionsButton.Text = "Options";
			this._optionsButton.Click += new System.EventHandler(this._optionsButton_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
			// 
			// toolStripLabel3
			// 
			this.toolStripLabel3.Name = "toolStripLabel3";
			this.toolStripLabel3.Size = new System.Drawing.Size(35, 36);
			this.toolStripLabel3.Text = "Help:";
			// 
			// _aboutButton
			// 
			this._aboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("_aboutButton.Image")));
			this._aboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._aboutButton.Name = "_aboutButton";
			this._aboutButton.Size = new System.Drawing.Size(36, 36);
			this._aboutButton.Text = "About";
			this._aboutButton.Click += new System.EventHandler(this._aboutButton_Click);
			// 
			// _statusStrip
			// 
			this._statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._gameStatus,
            this._currentRoundStatus,
            this._progressLabelStatus,
            this._gameProgressStatus});
			this._statusStrip.Location = new System.Drawing.Point(0, 594);
			this._statusStrip.Name = "_statusStrip";
			this._statusStrip.Size = new System.Drawing.Size(873, 27);
			this._statusStrip.TabIndex = 2;
			this._statusStrip.Text = "statusStrip1";
			// 
			// _gameStatus
			// 
			this._gameStatus.AutoSize = false;
			this._gameStatus.BackColor = System.Drawing.SystemColors.Control;
			this._gameStatus.Name = "_gameStatus";
			this._gameStatus.Size = new System.Drawing.Size(250, 22);
			this._gameStatus.Text = "Game Stopped";
			// 
			// _currentRoundStatus
			// 
			this._currentRoundStatus.AutoSize = false;
			this._currentRoundStatus.BackColor = System.Drawing.SystemColors.Control;
			this._currentRoundStatus.Name = "_currentRoundStatus";
			this._currentRoundStatus.Size = new System.Drawing.Size(200, 22);
			this._currentRoundStatus.Text = "Current Round: 0";
			this._currentRoundStatus.Visible = false;
			// 
			// _progressLabelStatus
			// 
			this._progressLabelStatus.BackColor = System.Drawing.SystemColors.Control;
			this._progressLabelStatus.Name = "_progressLabelStatus";
			this._progressLabelStatus.Size = new System.Drawing.Size(89, 22);
			this._progressLabelStatus.Text = "Game Progress:";
			this._progressLabelStatus.Visible = false;
			// 
			// _gameProgressStatus
			// 
			this._gameProgressStatus.AutoSize = false;
			this._gameProgressStatus.Name = "_gameProgressStatus";
			this._gameProgressStatus.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this._gameProgressStatus.Size = new System.Drawing.Size(200, 21);
			this._gameProgressStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this._gameProgressStatus.Visible = false;
			// 
			// _menuStrip
			// 
			this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._gameMenu,
            this._settingsMenu,
            this._helpMenu});
			this._menuStrip.Location = new System.Drawing.Point(0, 0);
			this._menuStrip.Name = "_menuStrip";
			this._menuStrip.Size = new System.Drawing.Size(873, 24);
			this._menuStrip.TabIndex = 3;
			this._menuStrip.Text = "_menuStrip";
			// 
			// _gameMenu
			// 
			this._gameMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._newGameMenu,
            this._stopGameMenu,
            this._pauseGameMenu,
            this._continueGameMenu,
            this._exitMenu});
			this._gameMenu.Name = "_gameMenu";
			this._gameMenu.Size = new System.Drawing.Size(50, 20);
			this._gameMenu.Text = "&Game";
			// 
			// _newGameMenu
			// 
			this._newGameMenu.Name = "_newGameMenu";
			this._newGameMenu.Size = new System.Drawing.Size(157, 22);
			this._newGameMenu.Text = "&New Game";
			this._newGameMenu.Click += new System.EventHandler(this._newGameMenu_Click);
			// 
			// _stopGameMenu
			// 
			this._stopGameMenu.Name = "_stopGameMenu";
			this._stopGameMenu.Size = new System.Drawing.Size(157, 22);
			this._stopGameMenu.Text = "&Stop Game";
			this._stopGameMenu.Click += new System.EventHandler(this._stopGameMenu_Click);
			// 
			// _pauseGameMenu
			// 
			this._pauseGameMenu.Name = "_pauseGameMenu";
			this._pauseGameMenu.Size = new System.Drawing.Size(157, 22);
			this._pauseGameMenu.Text = "&Pause Game";
			this._pauseGameMenu.Click += new System.EventHandler(this._pauseGameMenu_Click);
			// 
			// _continueGameMenu
			// 
			this._continueGameMenu.Name = "_continueGameMenu";
			this._continueGameMenu.Size = new System.Drawing.Size(157, 22);
			this._continueGameMenu.Text = "&Continue Game";
			this._continueGameMenu.Click += new System.EventHandler(this._continueGameMenu_Click);
			// 
			// _exitMenu
			// 
			this._exitMenu.Image = ((System.Drawing.Image)(resources.GetObject("_exitMenu.Image")));
			this._exitMenu.Name = "_exitMenu";
			this._exitMenu.Size = new System.Drawing.Size(157, 22);
			this._exitMenu.Text = "E&xit";
			// 
			// _settingsMenu
			// 
			this._settingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._playersMenu,
            this._optionsMenu});
			this._settingsMenu.Name = "_settingsMenu";
			this._settingsMenu.Size = new System.Drawing.Size(61, 20);
			this._settingsMenu.Text = "&Settings";
			// 
			// _playersMenu
			// 
			this._playersMenu.Image = ((System.Drawing.Image)(resources.GetObject("_playersMenu.Image")));
			this._playersMenu.Name = "_playersMenu";
			this._playersMenu.Size = new System.Drawing.Size(125, 22);
			this._playersMenu.Text = "&Players...";
			this._playersMenu.Click += new System.EventHandler(this._playersMenu_Click);
			// 
			// _optionsMenu
			// 
			this._optionsMenu.Image = ((System.Drawing.Image)(resources.GetObject("_optionsMenu.Image")));
			this._optionsMenu.Name = "_optionsMenu";
			this._optionsMenu.Size = new System.Drawing.Size(125, 22);
			this._optionsMenu.Text = "&Options...";
			this._optionsMenu.Click += new System.EventHandler(this._optionsMenu_Click);
			// 
			// _helpMenu
			// 
			this._helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._aboutMenu});
			this._helpMenu.Name = "_helpMenu";
			this._helpMenu.Size = new System.Drawing.Size(44, 20);
			this._helpMenu.Text = "&Help";
			// 
			// _aboutMenu
			// 
			this._aboutMenu.Image = ((System.Drawing.Image)(resources.GetObject("_aboutMenu.Image")));
			this._aboutMenu.Name = "_aboutMenu";
			this._aboutMenu.Size = new System.Drawing.Size(107, 22);
			this._aboutMenu.Text = "&About";
			this._aboutMenu.Click += new System.EventHandler(this._aboutMenu_Click);
			// 
			// _roundLabel
			// 
			this._roundLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this._roundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._roundLabel.ForeColor = System.Drawing.Color.Red;
			this._roundLabel.Location = new System.Drawing.Point(0, 112);
			this._roundLabel.Name = "_roundLabel";
			this._roundLabel.Size = new System.Drawing.Size(873, 79);
			this._roundLabel.TabIndex = 4;
			this._roundLabel.Text = "Round";
			this._roundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._roundLabel.Visible = false;
			// 
			// _playerNameLabel
			// 
			this._playerNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this._playerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._playerNameLabel.Location = new System.Drawing.Point(0, 78);
			this._playerNameLabel.Name = "_playerNameLabel";
			this._playerNameLabel.Size = new System.Drawing.Size(873, 39);
			this._playerNameLabel.TabIndex = 5;
			this._playerNameLabel.Text = "Player:";
			this._playerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._playerNameLabel.Visible = false;
			// 
			// _sumLabel
			// 
			this._sumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this._sumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._sumLabel.Location = new System.Drawing.Point(0, 324);
			this._sumLabel.Name = "_sumLabel";
			this._sumLabel.Size = new System.Drawing.Size(873, 39);
			this._sumLabel.TabIndex = 7;
			this._sumLabel.Text = "Sum:";
			this._sumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._sumLabel.Visible = false;
			// 
			// _winnerNameLabel
			// 
			this._winnerNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this._winnerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._winnerNameLabel.ForeColor = System.Drawing.Color.Red;
			this._winnerNameLabel.Location = new System.Drawing.Point(0, 214);
			this._winnerNameLabel.Name = "_winnerNameLabel";
			this._winnerNameLabel.Size = new System.Drawing.Size(873, 79);
			this._winnerNameLabel.TabIndex = 8;
			this._winnerNameLabel.Text = "The Winner is ";
			this._winnerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._winnerNameLabel.Visible = false;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGreen;
			this.ClientSize = new System.Drawing.Size(873, 621);
			this.Controls.Add(this._winnerNameLabel);
			this.Controls.Add(this._sumLabel);
			this.Controls.Add(this._playerNameLabel);
			this.Controls.Add(this._roundLabel);
			this.Controls.Add(this._statusStrip);
			this.Controls.Add(this._toolStrip);
			this.Controls.Add(this._menuStrip);
			this.Controls.Add(this._statistics);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this._menuStrip;
			this.Name = "MainWindow";
			this.Text = "BlackJack";
			this._toolStrip.ResumeLayout(false);
			this._toolStrip.PerformLayout();
			this._statusStrip.ResumeLayout(false);
			this._statusStrip.PerformLayout();
			this._menuStrip.ResumeLayout(false);
			this._menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView _statistics;
		private System.Windows.Forms.ColumnHeader _playerName;
		private System.Windows.Forms.ColumnHeader _wins;
		private System.Windows.Forms.ColumnHeader _draws;
		private System.Windows.Forms.ColumnHeader _looses;
		private System.Windows.Forms.ToolStrip _toolStrip;
		private System.Windows.Forms.StatusStrip _statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel _gameStatus;
		private System.Windows.Forms.ToolStripStatusLabel _currentRoundStatus;
		private System.Windows.Forms.ToolStripProgressBar _gameProgressStatus;
		private System.Windows.Forms.MenuStrip _menuStrip;
		private System.Windows.Forms.ToolStripMenuItem _gameMenu;
		private System.Windows.Forms.ToolStripMenuItem _newGameMenu;
		private System.Windows.Forms.ToolStripMenuItem _stopGameMenu;
		private System.Windows.Forms.ToolStripMenuItem _pauseGameMenu;
		private System.Windows.Forms.ToolStripMenuItem _helpMenu;
		private System.Windows.Forms.ToolStripMenuItem _aboutMenu;
		private System.Windows.Forms.ToolStripButton _newGameButton;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripButton _stopGameButton;
		private System.Windows.Forms.ToolStripButton _pauseGameButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel2;
		private System.Windows.Forms.ToolStripButton _playersButton;
		private System.Windows.Forms.ToolStripButton _optionsButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripLabel toolStripLabel3;
		private System.Windows.Forms.ToolStripButton _aboutButton;
		private System.Windows.Forms.ToolStripMenuItem _exitMenu;
		private System.Windows.Forms.ToolStripMenuItem _continueGameMenu;
		private System.Windows.Forms.ToolStripMenuItem _settingsMenu;
		private System.Windows.Forms.ToolStripMenuItem _playersMenu;
		private System.Windows.Forms.ToolStripMenuItem _optionsMenu;
		private System.Windows.Forms.ToolStripButton _continueGameButton;
		private System.Windows.Forms.ToolStripStatusLabel _progressLabelStatus;
		private System.Windows.Forms.Label _roundLabel;
        private System.Windows.Forms.Label _playerNameLabel;
		private System.Windows.Forms.Label _sumLabel;
		private System.Windows.Forms.Label _winnerNameLabel;
	}
}

