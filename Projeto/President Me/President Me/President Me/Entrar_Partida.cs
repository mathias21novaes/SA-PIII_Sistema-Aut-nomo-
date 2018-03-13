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
    public partial class Entrar_Partida : Form
    {
        public int idpartida { get; set; }
        public string idp { get; set; }
        public string nome_jogador { get; set; }
        public string senha_partida { get; set; }
        public string listar { get; set; }
        public string idesenha_jogador { get; set; }
        public string versao { get; set; }

        public Entrar_Partida()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.idp = txtId_Entrar.Text;
            idpartida = int.Parse(idp);
            this.nome_jogador = txtJogador.Text;
            this.senha_partida = txtSenha_Entrar.Text;
            this.idesenha_jogador = Jogo.Entrar(idpartida, nome_jogador, senha_partida);
            lblDadosJogador.Text = this.idesenha_jogador;
        }

        private void btnVoltar_Entrar_Click(object sender, EventArgs e)
        {
            Lobby f = new Lobby(versao);
            this.Close();
        }

        private void btnListarPartida_Click(object sender, EventArgs e)
        {
            listar = txtListarPartidas.Text;
            txtListarPartidas.Text = Jogo.ListarPartidas();        
        }

        private void txtNomeP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
