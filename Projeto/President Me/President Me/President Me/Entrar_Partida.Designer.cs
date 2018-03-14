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
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnVoltar_Entrar = new System.Windows.Forms.Button();
            this.txtListarPartidas = new System.Windows.Forms.TextBox();
            this.btnListarPartida = new System.Windows.Forms.Button();
            this.txtJogador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDadosJogadorSenha = new System.Windows.Forms.Label();
            this.lblDadosJogadorId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.txtId_Entrar = new System.Windows.Forms.TextBox();
            this.txtSenha_Entrar = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblEntrou = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbljogador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(199, 22);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 42);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnVoltar_Entrar
            // 
            this.btnVoltar_Entrar.Location = new System.Drawing.Point(12, 315);
            this.btnVoltar_Entrar.Name = "btnVoltar_Entrar";
            this.btnVoltar_Entrar.Size = new System.Drawing.Size(65, 28);
            this.btnVoltar_Entrar.TabIndex = 2;
            this.btnVoltar_Entrar.Text = "VOLTAR";
            this.btnVoltar_Entrar.UseVisualStyleBackColor = true;
            this.btnVoltar_Entrar.Click += new System.EventHandler(this.btnVoltar_Entrar_Click);
            // 
            // txtListarPartidas
            // 
            this.txtListarPartidas.Location = new System.Drawing.Point(322, 91);
            this.txtListarPartidas.Multiline = true;
            this.txtListarPartidas.Name = "txtListarPartidas";
            this.txtListarPartidas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListarPartidas.Size = new System.Drawing.Size(172, 233);
            this.txtListarPartidas.TabIndex = 3;
            // 
            // btnListarPartida
            // 
            this.btnListarPartida.Location = new System.Drawing.Point(322, 46);
            this.btnListarPartida.Name = "btnListarPartida";
            this.btnListarPartida.Size = new System.Drawing.Size(161, 34);
            this.btnListarPartida.TabIndex = 4;
            this.btnListarPartida.Text = "LISTAR PARTIDAS";
            this.btnListarPartida.UseVisualStyleBackColor = true;
            this.btnListarPartida.Click += new System.EventHandler(this.btnListarPartida_Click);
            // 
            // txtJogador
            // 
            this.txtJogador.Location = new System.Drawing.Point(23, 91);
            this.txtJogador.Name = "txtJogador";
            this.txtJogador.Size = new System.Drawing.Size(130, 20);
            this.txtJogador.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID DO JOGADOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "SENHA DO JOGADOR";
            // 
            // lblDadosJogadorSenha
            // 
            this.lblDadosJogadorSenha.AutoSize = true;
            this.lblDadosJogadorSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosJogadorSenha.Location = new System.Drawing.Point(206, 208);
            this.lblDadosJogadorSenha.Name = "lblDadosJogadorSenha";
            this.lblDadosJogadorSenha.Size = new System.Drawing.Size(15, 18);
            this.lblDadosJogadorSenha.TabIndex = 9;
            this.lblDadosJogadorSenha.Text = "*";
            // 
            // lblDadosJogadorId
            // 
            this.lblDadosJogadorId.AutoSize = true;
            this.lblDadosJogadorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosJogadorId.Location = new System.Drawing.Point(55, 208);
            this.lblDadosJogadorId.Name = "lblDadosJogadorId";
            this.lblDadosJogadorId.Size = new System.Drawing.Size(15, 18);
            this.lblDadosJogadorId.TabIndex = 10;
            this.lblDadosJogadorId.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "JOGADOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "SENHA DA PARTIDA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID DA PARTIDA";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(167, 18);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(15, 18);
            this.lblid.TabIndex = 14;
            this.lblid.Text = "*";
            // 
            // txtId_Entrar
            // 
            this.txtId_Entrar.Location = new System.Drawing.Point(112, 19);
            this.txtId_Entrar.Name = "txtId_Entrar";
            this.txtId_Entrar.Size = new System.Drawing.Size(39, 20);
            this.txtId_Entrar.TabIndex = 15;
            // 
            // txtSenha_Entrar
            // 
            this.txtSenha_Entrar.Location = new System.Drawing.Point(159, 91);
            this.txtSenha_Entrar.Name = "txtSenha_Entrar";
            this.txtSenha_Entrar.Size = new System.Drawing.Size(130, 20);
            this.txtSenha_Entrar.TabIndex = 16;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(12, 243);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(105, 49);
            this.btnIniciar.TabIndex = 17;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblEntrou
            // 
            this.lblEntrou.AutoSize = true;
            this.lblEntrou.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrou.Location = new System.Drawing.Point(138, 243);
            this.lblEntrou.Name = "lblEntrou";
            this.lblEntrou.Size = new System.Drawing.Size(15, 18);
            this.lblEntrou.TabIndex = 18;
            this.lblEntrou.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "id do jogador a começar";
            // 
            // lbljogador
            // 
            this.lbljogador.AutoSize = true;
            this.lbljogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljogador.Location = new System.Drawing.Point(138, 306);
            this.lbljogador.Name = "lbljogador";
            this.lbljogador.Size = new System.Drawing.Size(15, 18);
            this.lbljogador.TabIndex = 20;
            this.lbljogador.Text = "*";
            // 
            // Entrar_Partida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 355);
            this.Controls.Add(this.lbljogador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEntrou);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtSenha_Entrar);
            this.Controls.Add(this.txtId_Entrar);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDadosJogadorId);
            this.Controls.Add(this.lblDadosJogadorSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJogador);
            this.Controls.Add(this.btnListarPartida);
            this.Controls.Add(this.txtListarPartidas);
            this.Controls.Add(this.btnVoltar_Entrar);
            this.Controls.Add(this.btnEntrar);
            this.Name = "Entrar_Partida";
            this.Text = "Entrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnVoltar_Entrar;
        private System.Windows.Forms.TextBox txtListarPartidas;
        private System.Windows.Forms.Button btnListarPartida;
        private System.Windows.Forms.TextBox txtJogador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDadosJogadorSenha;
        private System.Windows.Forms.Label lblDadosJogadorId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtId_Entrar;
        private System.Windows.Forms.TextBox txtSenha_Entrar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblEntrou;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbljogador;
    }
}