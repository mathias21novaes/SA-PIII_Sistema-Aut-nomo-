﻿namespace President_Me
{
    partial class Lobby
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lobby));
            this.label1 = new System.Windows.Forms.Label();
            this.lblversao = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.PictureBox();
            this.btn_criar = new System.Windows.Forms.PictureBox();
            this.btn_entrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_criar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_entrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "VERSÃO:";
            // 
            // lblversao
            // 
            this.lblversao.AutoSize = true;
            this.lblversao.BackColor = System.Drawing.Color.Transparent;
            this.lblversao.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblversao.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblversao.Location = new System.Drawing.Point(91, 381);
            this.lblversao.Name = "lblversao";
            this.lblversao.Size = new System.Drawing.Size(18, 23);
            this.lblversao.TabIndex = 6;
            this.lblversao.Text = "*";
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Image = ((System.Drawing.Image)(resources.GetObject("btn_fechar.Image")));
            this.btn_fechar.Location = new System.Drawing.Point(785, 7);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(41, 39);
            this.btn_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_fechar.TabIndex = 9;
            this.btn_fechar.TabStop = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_criar
            // 
            this.btn_criar.BackColor = System.Drawing.Color.Transparent;
            this.btn_criar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_criar.Image = ((System.Drawing.Image)(resources.GetObject("btn_criar.Image")));
            this.btn_criar.Location = new System.Drawing.Point(299, 285);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(175, 54);
            this.btn_criar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_criar.TabIndex = 8;
            this.btn_criar.TabStop = false;
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_entrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_entrar.Image")));
            this.btn_entrar.Location = new System.Drawing.Point(84, 285);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(175, 54);
            this.btn_entrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_entrar.TabIndex = 7;
            this.btn_entrar.TabStop = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 409);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.lblversao);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lobby";
            this.Load += new System.EventHandler(this.Lobby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_criar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_entrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblversao;
        private System.Windows.Forms.PictureBox btn_entrar;
        private System.Windows.Forms.PictureBox btn_criar;
        private System.Windows.Forms.PictureBox btn_fechar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}