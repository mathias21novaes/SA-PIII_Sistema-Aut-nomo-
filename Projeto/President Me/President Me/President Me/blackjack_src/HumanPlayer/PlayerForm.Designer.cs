namespace HumanPlayer
{
	partial class PlayerForm
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
			this._hit = new System.Windows.Forms.Button();
			this._stand = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this._cards = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _hit
			// 
			this._hit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._hit.DialogResult = System.Windows.Forms.DialogResult.OK;
			this._hit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._hit.ForeColor = System.Drawing.Color.Red;
			this._hit.Location = new System.Drawing.Point(12, 172);
			this._hit.Name = "_hit";
			this._hit.Size = new System.Drawing.Size(132, 72);
			this._hit.TabIndex = 0;
			this._hit.Text = "&Hit";
			this._hit.UseVisualStyleBackColor = true;
			// 
			// _stand
			// 
			this._stand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._stand.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._stand.ForeColor = System.Drawing.Color.Red;
			this._stand.Location = new System.Drawing.Point(201, 172);
			this._stand.Name = "_stand";
			this._stand.Size = new System.Drawing.Size(132, 72);
			this._stand.TabIndex = 1;
			this._stand.Text = "&Stand";
			this._stand.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(321, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Your cards:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _cards
			// 
			this._cards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this._cards.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._cards.ForeColor = System.Drawing.Color.Red;
			this._cards.Location = new System.Drawing.Point(12, 78);
			this._cards.Name = "_cards";
			this._cards.Size = new System.Drawing.Size(321, 38);
			this._cards.TabIndex = 3;
			this._cards.Text = "CARDS";
			this._cards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PlayerForm
			// 
			this.AcceptButton = this._hit;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGreen;
			this.CancelButton = this._stand;
			this.ClientSize = new System.Drawing.Size(345, 256);
			this.ControlBox = false;
			this.Controls.Add(this._cards);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._stand);
			this.Controls.Add(this._hit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.KeyPreview = true;
			this.Name = "PlayerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "PlayerForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button _hit;
		private System.Windows.Forms.Button _stand;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label _cards;
	}
}