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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            Entrar openForm = new Entrar();
            openForm.Show();
            Visible = false;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            Criar openForm = new Criar();
            openForm.Show();
            Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
