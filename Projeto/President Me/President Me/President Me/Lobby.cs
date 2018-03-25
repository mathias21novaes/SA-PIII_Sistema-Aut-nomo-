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
            //StartPosition = Center;
            Location = new Point(700, 700);
        }

        private void Lobby_Load(object sender, EventArgs e)
        {

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Entrar_Partida p = new Entrar_Partida();
            p.ShowDialog();
            if (Entrar_Partida.iniciou_partida == true)
            {
                this.Close();
            }
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            Criar_Partida c = new Criar_Partida();
            c.ShowDialog();
        }
    }
}
