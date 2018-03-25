using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MePresidentaServidor;

namespace President_Me
{
    public partial class Tabuleiro : Form
    {

        public string jogadorVez { get; set; }
        public string jogadorid { get; set; }
        public int vez { get; set; }

        public int jogador { get; set; }

        public Tabuleiro()
        {
            InitializeComponent();
            string versao = "3.0";
            Lobby f = new Lobby(versao);
            //f.Location = new Point(700, 700);
            f.ShowDialog();
            jogadorid = Entrar_Partida.idJogador;
            //vez = int.Parse(jogadorid);
            //lblVez.Text = jogadorVez;

            //jogadorVez = Jogo.VerificarVez(vez);
            //Entrar_Partida.colunas[0] = jogador;
            //while(jogador != vez)
            //{
             //   Thread.Sleep(3000);
                //string fdsfd= Jogo.VerificarVez(vez);
            //}

        }

        //private Point primeiroPoint = new Point();

       


    }
}
