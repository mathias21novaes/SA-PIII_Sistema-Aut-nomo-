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

namespace President_Me___Home
{
    public partial class Entrar : Form
    {
        public Entrar()
        {
            InitializeComponent();
            Criar f = new Criar();
            txtIdPartida.Text = f.criarPartida;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home openForm = new Home();
            openForm.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string listarP;
            listarP = txtListar.Text;
            txtListar.Text = Jogo.ListarPartidas();
        }

        private void txtListar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            Tabuleiro openForm = new Tabuleiro();
            openForm.Show();
            Visible = false;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
