namespace President_Me
{
    partial class Criar_Partida
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
            this.btnVoltar_Criar = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.txtNome_Partida = new System.Windows.Forms.TextBox();
            this.txtSenha_Partida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPartidaCriada = new System.Windows.Forms.Label();
            this.lblidc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoltar_Criar
            // 
            this.btnVoltar_Criar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVoltar_Criar.FlatAppearance.BorderSize = 0;
            this.btnVoltar_Criar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar_Criar.Location = new System.Drawing.Point(160, 287);
            this.btnVoltar_Criar.Name = "btnVoltar_Criar";
            this.btnVoltar_Criar.Size = new System.Drawing.Size(101, 64);
            this.btnVoltar_Criar.TabIndex = 0;
            this.btnVoltar_Criar.Text = "VOLTAR";
            this.btnVoltar_Criar.UseVisualStyleBackColor = false;
            this.btnVoltar_Criar.Click += new System.EventHandler(this.btnVoltar_Criar_Click);
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(34, 195);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(88, 45);
            this.btnCriar.TabIndex = 1;
            this.btnCriar.Text = "CRIAR";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // txtNome_Partida
            // 
            this.txtNome_Partida.Location = new System.Drawing.Point(34, 103);
            this.txtNome_Partida.Name = "txtNome_Partida";
            this.txtNome_Partida.Size = new System.Drawing.Size(158, 20);
            this.txtNome_Partida.TabIndex = 2;
            // 
            // txtSenha_Partida
            // 
            this.txtSenha_Partida.Location = new System.Drawing.Point(34, 160);
            this.txtSenha_Partida.Name = "txtSenha_Partida";
            this.txtSenha_Partida.Size = new System.Drawing.Size(158, 20);
            this.txtSenha_Partida.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "nome da partida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "senha da partida";
            // 
            // lblPartidaCriada
            // 
            this.lblPartidaCriada.AutoSize = true;
            this.lblPartidaCriada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidaCriada.Location = new System.Drawing.Point(107, 259);
            this.lblPartidaCriada.Name = "lblPartidaCriada";
            this.lblPartidaCriada.Size = new System.Drawing.Size(15, 18);
            this.lblPartidaCriada.TabIndex = 6;
            this.lblPartidaCriada.Text = "*";
            // 
            // lblidc
            // 
            this.lblidc.AutoSize = true;
            this.lblidc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidc.Location = new System.Drawing.Point(31, 297);
            this.lblidc.Name = "lblidc";
            this.lblidc.Size = new System.Drawing.Size(15, 18);
            this.lblidc.TabIndex = 7;
            this.lblidc.Text = "*";
            // 
            // Criar_Partida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 372);
            this.Controls.Add(this.lblidc);
            this.Controls.Add(this.lblPartidaCriada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenha_Partida);
            this.Controls.Add(this.txtNome_Partida);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.btnVoltar_Criar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Criar_Partida";
            this.Text = "Criar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar_Criar;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.TextBox txtNome_Partida;
        private System.Windows.Forms.TextBox txtSenha_Partida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPartidaCriada;
        private System.Windows.Forms.Label lblidc;
    }
}