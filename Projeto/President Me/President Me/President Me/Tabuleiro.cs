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
        public string jogadorid { get; set; }

        public Tabuleiro()
        {
            InitializeComponent();
            init();
            string versao = "3.0";
            Lobby f = new Lobby(versao);
            f.ShowDialog();
            jogadorVez = Entrar_Partida.idJogador;
            lblVez.Text = jogadorVez;
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

            pict2.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { primeiroPoint = Control.MousePosition; }
            };

            pict2.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(primeiroPoint.X - temp.X, primeiroPoint.Y - temp.Y);

                    pict2.Location = new Point(pict2.Location.X - res.X, pict2.Location.Y - res.Y);

                    primeiroPoint = temp;
                }

            };

            pict3.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { primeiroPoint = Control.MousePosition; }
            };

            pict3.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(primeiroPoint.X - temp.X, primeiroPoint.Y - temp.Y);

                    pict3.Location = new Point(pict3.Location.X - res.X, pict3.Location.Y - res.Y);

                    primeiroPoint = temp;
                }

            };

            pict4.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { primeiroPoint = Control.MousePosition; }
            };

            pict4.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(primeiroPoint.X - temp.X, primeiroPoint.Y - temp.Y);

                    pict4.Location = new Point(pict4.Location.X - res.X, pict4.Location.Y - res.Y);

                    primeiroPoint = temp;
                }

            };

            pict5.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { primeiroPoint = Control.MousePosition; }
            };

            pict5.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(primeiroPoint.X - temp.X, primeiroPoint.Y - temp.Y);

                    pict5.Location = new Point(pict5.Location.X - res.X, pict5.Location.Y - res.Y);

                    primeiroPoint = temp;
                }

            };

            pict6.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { primeiroPoint = Control.MousePosition; }
            };

            pict6.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(primeiroPoint.X - temp.X, primeiroPoint.Y - temp.Y);

                    pict6.Location = new Point(pict6.Location.X - res.X, pict6.Location.Y - res.Y);

                    primeiroPoint = temp;
                }

            };

            pict7.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { primeiroPoint = Control.MousePosition; }
            };

            pict7.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(primeiroPoint.X - temp.X, primeiroPoint.Y - temp.Y);

                    pict7.Location = new Point(pict7.Location.X - res.X, pict7.Location.Y - res.Y);

                    primeiroPoint = temp;
                }

            };

            pict8.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { primeiroPoint = Control.MousePosition; }
            };

            pict8.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(primeiroPoint.X - temp.X, primeiroPoint.Y - temp.Y);

                    pict8.Location = new Point(pict8.Location.X - res.X, pict8.Location.Y - res.Y);

                    primeiroPoint = temp;
                }

            };

            pict9.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { primeiroPoint = Control.MousePosition; }
            };

            pict9.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(primeiroPoint.X - temp.X, primeiroPoint.Y - temp.Y);

                    pict9.Location = new Point(pict9.Location.X - res.X, pict9.Location.Y - res.Y);

                    primeiroPoint = temp;
                }

            };

            pict10.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { primeiroPoint = Control.MousePosition; }
            };

            pict10.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(primeiroPoint.X - temp.X, primeiroPoint.Y - temp.Y);

                    pict10.Location = new Point(pict10.Location.X - res.X, pict10.Location.Y - res.Y);

                    primeiroPoint = temp;
                }

            };

            pict11.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { primeiroPoint = Control.MousePosition; }
            };

            pict11.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(primeiroPoint.X - temp.X, primeiroPoint.Y - temp.Y);

                    pict11.Location = new Point(pict11.Location.X - res.X, pict11.Location.Y - res.Y);

                    primeiroPoint = temp;
                }

            };

            pict12.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { primeiroPoint = Control.MousePosition; }
            };

            pict12.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(primeiroPoint.X - temp.X, primeiroPoint.Y - temp.Y);

                    pict12.Location = new Point(pict12.Location.X - res.X, pict12.Location.Y - res.Y);

                    primeiroPoint = temp;
                }

            };

            pict13.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { primeiroPoint = Control.MousePosition; }
            };

            pict13.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(primeiroPoint.X - temp.X, primeiroPoint.Y - temp.Y);

                    pict13.Location = new Point(pict13.Location.X - res.X, pict13.Location.Y - res.Y);

                    primeiroPoint = temp;
                }

            };
        }
     

    }
}
