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
            this.lblversao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCriar_partida
            // 
            this.btnCriar_partida.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCriar_partida.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCriar_partida.FlatAppearance.BorderSize = 0;
            this.btnCriar_partida.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar_partida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCriar_partida.Location = new System.Drawing.Point(20, 22);
            this.btnCriar_partida.Name = "btnCriar_partida";
            this.btnCriar_partida.Size = new System.Drawing.Size(139, 50);
            this.btnCriar_partida.TabIndex = 1;
            this.btnCriar_partida.Text = "ENTRAR";
            this.btnCriar_partida.UseVisualStyleBackColor = false;
            this.btnCriar_partida.Click += new System.EventHandler(this.btnEntrar_partida_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSair.Location = new System.Drawing.Point(20, 203);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(139, 50);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEntrar_Partida
            // 
            this.btnEntrar_Partida.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEntrar_Partida.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnEntrar_Partida.FlatAppearance.BorderSize = 0;
            this.btnEntrar_Partida.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar_Partida.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEntrar_Partida.Location = new System.Drawing.Point(20, 113);
            this.btnEntrar_Partida.Name = "btnEntrar_Partida";
            this.btnEntrar_Partida.Size = new System.Drawing.Size(139, 50);
            this.btnEntrar_Partida.TabIndex = 3;
            this.btnEntrar_Partida.Text = "CRIAR";
            this.btnEntrar_Partida.UseVisualStyleBackColor = false;
            this.btnEntrar_Partida.Click += new System.EventHandler(this.btnCriar_Partida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(6, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "VERSÃO:";
            // 
            // lblversao
            // 
            this.lblversao.AutoSize = true;
            this.lblversao.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblversao.ForeColor = System.Drawing.Color.Navy;
            this.lblversao.Location = new System.Drawing.Point(61, 363);
            this.lblversao.Name = "lblversao";
            this.lblversao.Size = new System.Drawing.Size(0, 16);
            this.lblversao.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnEntrar_Partida);
            this.panel1.Controls.Add(this.btnCriar_partida);
            this.panel1.Location = new System.Drawing.Point(481, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 278);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lblversao);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 392);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::President_Me.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, -50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 154);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(743, 400);
            this.Controls.Add(this.panel2);
            this.Name = "Lobby";
            this.Text = "Lobby";
            this.Load += new System.EventHandler(this.Lobby_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCriar_partida;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEntrar_Partida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblversao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}