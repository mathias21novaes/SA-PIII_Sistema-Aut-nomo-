namespace President_Me
{
    partial class Tabuleiro
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
            this.lblListarJogadores = new System.Windows.Forms.Label();
            this.lblsj = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblidj = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListarJogadores
            // 
            this.lblListarJogadores.AutoSize = true;
            this.lblListarJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListarJogadores.Location = new System.Drawing.Point(25, 15);
            this.lblListarJogadores.Name = "lblListarJogadores";
            this.lblListarJogadores.Size = new System.Drawing.Size(60, 24);
            this.lblListarJogadores.TabIndex = 17;
            this.lblListarJogadores.Text = "label2";
            // 
            // lblsj
            // 
            this.lblsj.AutoSize = true;
            this.lblsj.BackColor = System.Drawing.Color.Transparent;
            this.lblsj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblsj.Location = new System.Drawing.Point(336, 14);
            this.lblsj.Name = "lblsj";
            this.lblsj.Size = new System.Drawing.Size(21, 25);
            this.lblsj.TabIndex = 22;
            this.lblsj.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "SENHA DO JOGADOR";
            // 
            // lblidj
            // 
            this.lblidj.AutoSize = true;
            this.lblidj.BackColor = System.Drawing.Color.Transparent;
            this.lblidj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblidj.Location = new System.Drawing.Point(336, 56);
            this.lblidj.Name = "lblidj";
            this.lblidj.Size = new System.Drawing.Size(21, 25);
            this.lblidj.TabIndex = 20;
            this.lblidj.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID DO JOGADOR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(1198, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Location = new System.Drawing.Point(426, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 706);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Location = new System.Drawing.Point(26, 515);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 232);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblsj);
            this.panel3.Controls.Add(this.lblidj);
            this.panel3.Location = new System.Drawing.Point(26, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(379, 123);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CadetBlue;
            this.panel4.Controls.Add(this.lblListarJogadores);
            this.panel4.Location = new System.Drawing.Point(880, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(342, 143);
            this.panel4.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CadetBlue;
            this.panel5.Location = new System.Drawing.Point(26, 212);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(379, 280);
            this.panel5.TabIndex = 28;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(999, 308);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 63);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // Tabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1250, 791);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tabuleiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tab2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblListarJogadores;
        private System.Windows.Forms.Label lblsj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblidj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}