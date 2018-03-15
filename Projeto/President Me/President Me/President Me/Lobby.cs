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
    public partial class Lobby : Form
    {
        public Lobby(string versao)
        {
            InitializeComponent();
            lblversao.Text = versao;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_partida_Click(object sender, EventArgs e)
        {
            Entrar_Partida p = new Entrar_Partida();
            p.ShowDialog();
            this.Close();

        }

        private void btnCriar_Partida_Click(object sender, EventArgs e)
        {
            Criar_Partida c = new Criar_Partida();
            c.ShowDialog();
        }

        private void Lobby_Load(object sender, EventArgs e)
        {

        }
    }
}
