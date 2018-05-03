namespace President_Me
{
    partial class Entrar_Partida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrar_Partida));
            this.txtJogador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha_Entrar = new System.Windows.Forms.TextBox();
            this.lblEntrou1 = new System.Windows.Forms.Label();
            this.listPartidas = new System.Windows.Forms.ListBox();
            this.btn_voltar = new System.Windows.Forms.PictureBox();
            this.btn_iniciar = new System.Windows.Forms.PictureBox();
            this.btn_entrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblnumJog = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_iniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_entrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJogador
            // 
            this.txtJogador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJogador.Location = new System.Drawing.Point(26, 249);
            this.txtJogador.Name = "txtJogador";
            this.txtJogador.Size = new System.Drawing.Size(182, 22);
            this.txtJogador.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Jogador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Senha da Partida";
            // 
            // txtSenha_Entrar
            // 
            this.txtSenha_Entrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha_Entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha_Entrar.Location = new System.Drawing.Point(220, 249);
            this.txtSenha_Entrar.Name = "txtSenha_Entrar";
            this.txtSenha_Entrar.Size = new System.Drawing.Size(182, 22);
            this.txtSenha_Entrar.TabIndex = 16;
            this.txtSenha_Entrar.UseSystemPasswordChar = true;
            // 
            // lblEntrou1
            // 
            this.lblEntrou1.AutoSize = true;
            this.lblEntrou1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrou1.Location = new System.Drawing.Point(119, 353);
            this.lblEntrou1.Name = "lblEntrou1";
            this.lblEntrou1.Size = new System.Drawing.Size(0, 20);
            this.lblEntrou1.TabIndex = 18;
            // 
            // listPartidas
            // 
            this.listPartidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPartidas.FormattingEnabled = true;
            this.listPartidas.ItemHeight = 20;
            this.listPartidas.Location = new System.Drawing.Point(26, 32);
            this.listPartidas.Name = "listPartidas";
            this.listPartidas.Size = new System.Drawing.Size(376, 180);
            this.listPartidas.TabIndex = 21;
            this.listPartidas.SelectedIndexChanged += new System.EventHandler(this.listPartidas_SelectedIndexChanged);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.Transparent;
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.Location = new System.Drawing.Point(348, 505);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(112, 49);
            this.btn_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_voltar.TabIndex = 27;
            this.btn_voltar.TabStop = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.BackColor = System.Drawing.Color.Transparent;
            this.btn_iniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_iniciar.Image = ((System.Drawing.Image)(resources.GetObject("btn_iniciar.Image")));
            this.btn_iniciar.Location = new System.Drawing.Point(31, 500);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(175, 54);
            this.btn_iniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_iniciar.TabIndex = 28;
            this.btn_iniciar.TabStop = false;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_entrar.Image = global::President_Me.Properties.Resources.button_entrar;
            this.btn_entrar.Location = new System.Drawing.Point(125, 288);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(175, 54);
            this.btn_entrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_entrar.TabIndex = 29;
            this.btn_entrar.TabStop = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_entrar);
            this.panel1.Controls.Add(this.listPartidas);
            this.panel1.Controls.Add(this.txtSenha_Entrar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtJogador);
            this.panel1.Controls.Add(this.lblEntrou1);
            this.panel1.Location = new System.Drawing.Point(31, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 385);
            this.panel1.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "Selecione a Partida";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(150, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 31);
            this.label5.TabIndex = 33;
            this.label5.Text = "ENTRAR PARTIDA";
            // 
            // lblnumJog
            // 
            this.lblnumJog.AutoSize = true;
            this.lblnumJog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumJog.Location = new System.Drawing.Point(117, 564);
            this.lblnumJog.Name = "lblnumJog";
            this.lblnumJog.Size = new System.Drawing.Size(0, 20);
            this.lblnumJog.TabIndex = 34;
            // 
            // Entrar_Partida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(491, 593);
            this.Controls.Add(this.lblnumJog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.btn_voltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Entrar_Partida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrar";
            ((System.ComponentModel.ISupportInitialize)(this.btn_voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_iniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_entrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtJogador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenha_Entrar;
        private System.Windows.Forms.Label lblEntrou1;
        private System.Windows.Forms.ListBox listPartidas;
        private System.Windows.Forms.PictureBox btn_voltar;
        private System.Windows.Forms.PictureBox btn_iniciar;
        private System.Windows.Forms.PictureBox btn_entrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblnumJog;
        private System.Windows.Forms.Label label7;
    }
}