namespace BlackJack
{
	partial class Options
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
			this._animateRoundsCheckBox = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this._statLabel2 = new System.Windows.Forms.Label();
			this._statRefreshingSpin = new System.Windows.Forms.NumericUpDown();
			this._statLabel1 = new System.Windows.Forms.Label();
			this._ok = new System.Windows.Forms.Button();
			this._cancel = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this._decksCombo = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this._roundsSpin = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._statRefreshingSpin)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._roundsSpin)).BeginInit();
			this.SuspendLayout();
			// 
			// _animateRoundsCheckBox
			// 
			this._animateRoundsCheckBox.AutoSize = true;
			this._animateRoundsCheckBox.Location = new System.Drawing.Point(6, 19);
			this._animateRoundsCheckBox.Name = "_animateRoundsCheckBox";
			this._animateRoundsCheckBox.Size = new System.Drawing.Size(99, 17);
			this._animateRoundsCheckBox.TabIndex = 0;
			this._animateRoundsCheckBox.Text = "Animate rounds";
			this._animateRoundsCheckBox.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this._statLabel2);
			this.groupBox1.Controls.Add(this._statRefreshingSpin);
			this.groupBox1.Controls.Add(this._statLabel1);
			this.groupBox1.Controls.Add(this._animateRoundsCheckBox);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(245, 81);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Animation";
			// 
			// _statLabel2
			// 
			this._statLabel2.AutoSize = true;
			this._statLabel2.Location = new System.Drawing.Point(186, 43);
			this._statLabel2.Name = "_statLabel2";
			this._statLabel2.Size = new System.Drawing.Size(45, 13);
			this._statLabel2.TabIndex = 3;
			this._statLabel2.Text = "round(s)";
			// 
			// _statRefreshingSpin
			// 
			this._statRefreshingSpin.Location = new System.Drawing.Point(130, 39);
			this._statRefreshingSpin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this._statRefreshingSpin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this._statRefreshingSpin.Name = "_statRefreshingSpin";
			this._statRefreshingSpin.Size = new System.Drawing.Size(49, 20);
			this._statRefreshingSpin.TabIndex = 1;
			this._statRefreshingSpin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// _statLabel1
			// 
			this._statLabel1.AutoSize = true;
			this._statLabel1.Location = new System.Drawing.Point(7, 43);
			this._statLabel1.Name = "_statLabel1";
			this._statLabel1.Size = new System.Drawing.Size(117, 13);
			this._statLabel1.TabIndex = 1;
			this._statLabel1.Text = "Update statistics every:";
			// 
			// _ok
			// 
			this._ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this._ok.Location = new System.Drawing.Point(182, 185);
			this._ok.Name = "_ok";
			this._ok.Size = new System.Drawing.Size(75, 23);
			this._ok.TabIndex = 4;
			this._ok.Text = "OK";
			this._ok.UseVisualStyleBackColor = true;
			// 
			// _cancel
			// 
			this._cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._cancel.Location = new System.Drawing.Point(101, 185);
			this._cancel.Name = "_cancel";
			this._cancel.Size = new System.Drawing.Size(75, 23);
			this._cancel.TabIndex = 5;
			this._cancel.Text = "Cancel";
			this._cancel.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this._decksCombo);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this._roundsSpin);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(12, 100);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(245, 78);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Game";
			// 
			// _decksCombo
			// 
			this._decksCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._decksCombo.FormattingEnabled = true;
			this._decksCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "6",
            "8"});
			this._decksCombo.Location = new System.Drawing.Point(158, 42);
			this._decksCombo.Name = "_decksCombo";
			this._decksCombo.Size = new System.Drawing.Size(73, 21);
			this._decksCombo.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Number of decks:";
			// 
			// _roundsSpin
			// 
			this._roundsSpin.Location = new System.Drawing.Point(158, 16);
			this._roundsSpin.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this._roundsSpin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this._roundsSpin.Name = "_roundsSpin";
			this._roundsSpin.Size = new System.Drawing.Size(73, 20);
			this._roundsSpin.TabIndex = 2;
			this._roundsSpin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Number of rounds per game:";
			// 
			// Options
			// 
			this.AcceptButton = this._ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._cancel;
			this.ClientSize = new System.Drawing.Size(269, 220);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this._cancel);
			this.Controls.Add(this._ok);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Options";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Options";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._statRefreshingSpin)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._roundsSpin)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckBox _animateRoundsCheckBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label _statLabel2;
		private System.Windows.Forms.NumericUpDown _statRefreshingSpin;
		private System.Windows.Forms.Label _statLabel1;
		private System.Windows.Forms.Button _ok;
		private System.Windows.Forms.Button _cancel;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox _decksCombo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown _roundsSpin;
		private System.Windows.Forms.Label label1;
	}
}