using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MePresidentaServidor;

namespace President_Me
{
    public partial class Criar_Partida : Form
    {
        public string Nome_Partida { get; set; }
        public string Senha_Partida { get; set; }
        public string Id { get; set; }

        public Criar_Partida()
        {
            InitializeComponent();
        }

        private void btnVoltar_Criar_Click(object sender, EventArgs e)
        {
            Lobby f = new Lobby();
            this.Close();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            this.Nome_Partida = txtNome_Partida.Text;
            this.Senha_Partida = txtSenha_Partida.Text;
            this.Id = Jogo.CriarPartida(Nome_Partida, Senha_Partida);
            //MessageBox.Show("P A R T I D A   C R I A D A !");
            lblPartidaCriada.Text = "PARTIDA CRIADA";

        }
    }
}
