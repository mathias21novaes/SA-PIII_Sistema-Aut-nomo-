namespace President_Me
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
            this.btnCriar_partida = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEntrar_Partida = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblversao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCriar_partida
            // 
            this.btnCriar_partida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar_partida.Location = new System.Drawing.Point(73, 85);
            this.btnCriar_partida.Name = "btnCriar_partida";
            this.btnCriar_partida.Size = new System.Drawing.Size(139, 50);
            this.btnCriar_partida.TabIndex = 1;
            this.btnCriar_partida.Text = "ENTRAR";
            this.btnCriar_partida.UseVisualStyleBackColor = true;
            this.btnCriar_partida.Click += new System.EventHandler(this.btnEntrar_partida_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(73, 301);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(139, 50);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEntrar_Partida
            // 
            this.btnEntrar_Partida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar_Partida.Location = new System.Drawing.Point(73, 192);
            this.btnEntrar_Partida.Name = "btnEntrar_Partida";
            this.btnEntrar_Partida.Size = new System.Drawing.Size(139, 50);
            this.btnEntrar_Partida.TabIndex = 3;
            this.btnEntrar_Partida.Text = "CRIAR";
            this.btnEntrar_Partida.UseVisualStyleBackColor = true;
            this.btnEntrar_Partida.Click += new System.EventHandler(this.btnCriar_Partida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "VERSÃO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 5;
            // 
            // lblversao
            // 
            this.lblversao.AutoSize = true;
            this.lblversao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblversao.Location = new System.Drawing.Point(337, 417);
            this.lblversao.Name = "lblversao";
            this.lblversao.Size = new System.Drawing.Size(13, 18);
            this.lblversao.TabIndex = 6;
            this.lblversao.Text = ".";
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 461);
            this.Controls.Add(this.lblversao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEntrar_Partida);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCriar_partida);
            this.Name = "Lobby";
            this.Text = "Lobby";
            this.Load += new System.EventHandler(this.Lobby_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCriar_partida;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEntrar_Partida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblversao;
    }
}