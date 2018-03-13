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
    public partial class Tabuleiro : Form
    {
        public Tabuleiro()
        {
            InitializeComponent();
            string versao = "3.0";
            Lobby f = new Lobby(versao);
            f.ShowDialog();
        }
    }
}
