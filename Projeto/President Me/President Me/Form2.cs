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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 openForm = new Form1();
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
    }
}
