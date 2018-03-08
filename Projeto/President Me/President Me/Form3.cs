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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 openForm = new Form1();
            openForm.Show();
            Visible = false;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            //string nomePartida;
            //string senhaPartida;

            string criarPartida = Jogo.CriarPartida(txtnomePartida.Text, txtsenhaPartida.Text);
            MessageBox.Show(criarPartida);
        }

        private void txtnomePartida_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsenhaPartida_TextChanged(object sender, EventArgs e)
        {

        }
    
    }
}
