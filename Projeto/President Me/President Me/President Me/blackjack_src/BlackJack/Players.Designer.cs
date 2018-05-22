namespace BlackJack
{
	partial class Players
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
			this._inGamePlayersList = new System.Windows.Forms.ListView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this._removeFromGameButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this._dealerNameText = new System.Windows.Forms.TextBox();
			this._playerModulesList = new System.Windows.Forms.ListView();
			this._addModuleButton = new System.Windows.Forms.Button();
			this._removeModuleButton = new System.Windows.Forms.Button();
			this._setAsDealerButton = new System.Windows.Forms.Button();
			this._addToGameButton = new System.Windows.Forms.Button();
			this._closeButton = new System.Windows.Forms.Button();
			this._openPlayersModuleDialog = new System.Windows.Forms.OpenFileDialog();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// _inGamePlayersList
			// 
			this._inGamePlayersList.Location = new System.Drawing.Point(6, 36);
			this._inGamePlayersList.Name = "_inGamePlayersList";
			this._inGamePlayersList.Size = new System.Drawing.Size(281, 97);
			this._inGamePlayersList.TabIndex = 0;
			this._inGamePlayersList.UseCompatibleStateImageBehavior = false;
			this._inGamePlayersList.View = System.Windows.Forms.View.List;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this._dealerNameText);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this._removeFromGameButton);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this._inGamePlayersList);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(403, 183);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Players In Game";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this._addToGameButton);
			this.groupBox2.Controls.Add(this._setAsDealerButton);
			this.groupBox2.Controls.Add(this._removeModuleButton);
			this.groupBox2.Controls.Add(this._addModuleButton);
			this.groupBox2.Controls.Add(this._playerModulesList);
			this.groupBox2.Location = new System.Drawing.Point(12, 201);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(403, 199);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Player\'s Modules";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Players:";
			// 
			// _removeFromGameButton
			// 
			this._removeFromGameButton.Location = new System.Drawing.Point(293, 36);
			this._removeFromGameButton.Name = "_removeFromGameButton";
			this._removeFromGameButton.Size = new System.Drawing.Size(104, 23);
			this._removeFromGameButton.TabIndex = 2;
			this._removeFromGameButton.Text = "Remove";
			this._removeFromGameButton.UseVisualStyleBackColor = true;
			this._removeFromGameButton.Click += new System.EventHandler(this._removeFromGameButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 140);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Dealer:";
			// 
			// _dealerNameText
			// 
			this._dealerNameText.Location = new System.Drawing.Point(6, 157);
			this._dealerNameText.Name = "_dealerNameText";
			this._dealerNameText.ReadOnly = true;
			this._dealerNameText.Size = new System.Drawing.Size(281, 20);
			this._dealerNameText.TabIndex = 2;
			// 
			// _playerModulesList
			// 
			this._playerModulesList.Location = new System.Drawing.Point(6, 20);
			this._playerModulesList.Name = "_playerModulesList";
			this._playerModulesList.Size = new System.Drawing.Size(281, 173);
			this._playerModulesList.TabIndex = 4;
			this._playerModulesList.UseCompatibleStateImageBehavior = false;
			this._playerModulesList.View = System.Windows.Forms.View.List;
			// 
			// _addModuleButton
			// 
			this._addModuleButton.Location = new System.Drawing.Point(293, 20);
			this._addModuleButton.Name = "_addModuleButton";
			this._addModuleButton.Size = new System.Drawing.Size(104, 23);
			this._addModuleButton.TabIndex = 5;
			this._addModuleButton.Text = "Add Module";
			this._addModuleButton.UseVisualStyleBackColor = true;
			this._addModuleButton.Click += new System.EventHandler(this._addModuleButton_Click);
			// 
			// _removeModuleButton
			// 
			this._removeModuleButton.Enabled = false;
			this._removeModuleButton.Location = new System.Drawing.Point(293, 50);
			this._removeModuleButton.Name = "_removeModuleButton";
			this._removeModuleButton.Size = new System.Drawing.Size(104, 23);
			this._removeModuleButton.TabIndex = 6;
			this._removeModuleButton.Text = "Remove Module";
			this._removeModuleButton.UseVisualStyleBackColor = true;
			this._removeModuleButton.Click += new System.EventHandler(this._removeModuleButton_Click);
			// 
			// _setAsDealerButton
			// 
			this._setAsDealerButton.Location = new System.Drawing.Point(293, 169);
			this._setAsDealerButton.Name = "_setAsDealerButton";
			this._setAsDealerButton.Size = new System.Drawing.Size(103, 23);
			this._setAsDealerButton.TabIndex = 8;
			this._setAsDealerButton.Text = "Set As Dealer";
			this._setAsDealerButton.UseVisualStyleBackColor = true;
			this._setAsDealerButton.Click += new System.EventHandler(this._setAsDealerButton_Click);
			// 
			// _addToGameButton
			// 
			this._addToGameButton.Location = new System.Drawing.Point(293, 140);
			this._addToGameButton.Name = "_addToGameButton";
			this._addToGameButton.Size = new System.Drawing.Size(102, 23);
			this._addToGameButton.TabIndex = 7;
			this._addToGameButton.Text = "Add To Game";
			this._addToGameButton.UseVisualStyleBackColor = true;
			this._addToGameButton.Click += new System.EventHandler(this._addToGameButton_Click);
			// 
			// _closeButton
			// 
			this._closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._closeButton.Location = new System.Drawing.Point(339, 407);
			this._closeButton.Name = "_closeButton";
			this._closeButton.Size = new System.Drawing.Size(75, 23);
			this._closeButton.TabIndex = 9;
			this._closeButton.Text = "Close";
			this._closeButton.UseVisualStyleBackColor = true;
			// 
			// _openPlayersModuleDialog
			// 
			this._openPlayersModuleDialog.FileName = "player.dll";
			this._openPlayersModuleDialog.Filter = "Player\'s Modules(*.dll)|*.dll|All Files(*.*)|*.*";
			// 
			// Players
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._closeButton;
			this.ClientSize = new System.Drawing.Size(427, 443);
			this.Controls.Add(this._closeButton);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Players";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Players";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView _inGamePlayersList;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox _dealerNameText;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button _removeFromGameButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button _addToGameButton;
		private System.Windows.Forms.Button _setAsDealerButton;
		private System.Windows.Forms.Button _removeModuleButton;
		private System.Windows.Forms.Button _addModuleButton;
		private System.Windows.Forms.ListView _playerModulesList;
		private System.Windows.Forms.Button _closeButton;
		private System.Windows.Forms.OpenFileDialog _openPlayersModuleDialog;
	}
}