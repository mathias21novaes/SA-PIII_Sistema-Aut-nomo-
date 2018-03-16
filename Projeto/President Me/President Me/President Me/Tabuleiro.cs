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

        public string jogadorVez { get; set; }

        public Tabuleiro()
        {
            InitializeComponent();
            init();
            string versao = "3.0";
            Lobby f = new Lobby(versao);
            f.ShowDialog();
            jogadorVez = Entrar_Partida.idJogador;
            jogadorVez = lblVez.Text;
        }

        private Point primeiroPoint = new Point();

        public void init()
        {
            pict1.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { primeiroPoint = Control.MousePosition; }
            };

            pict1.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(primeiroPoint.X - temp.X, primeiroPoint.Y - temp.Y);

                    pict1.Location = new Point(pict1.Location.X - res.X, pict1.Location.Y - res.Y);

                    primeiroPoint = temp;
                }
            };
        }

    }
}
