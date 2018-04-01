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
        public string Id { get; set; }
        public string Versao { get; set; }
        public string Nome_Partida { get; set; }
        public string Senha_Partida { get; set; }

        public Criar_Partida()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Lobby f = new Lobby(Versao);
            this.Close();
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            this.Nome_Partida = txtNome_Partida.Text;
            this.Senha_Partida = txtSenha_Partida.Text;
            this.Id = MePresidentaServidor.Jogo.CriarPartida(Nome_Partida, Senha_Partida);
            lbl_PartidaCriada1.Text = "PARTIDA CRIADA";
            lbl_PartidaCriada2.Text = "COM SUCESSO";
        }
    }
}
