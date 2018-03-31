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
        //public string jogadorid { get; set; }
        //public string jogadorsenha { get; set; }
        public int vez { get; set; }

        public int jogador { get; set; }

        public Tabuleiro()
        {
            InitializeComponent();
            string versao = "3.0";
            Lobby f = new Lobby(versao);
            //f.Location = new Point(700, 700);
            f.ShowDialog();
            lblListarJogadores.Text = Entrar_Partida.ListarJogadores;
            
            //verificar o codigo abaixo pois eles estão recebendo o ultimo jogador que entrou na partida
            //apenas ver se deixa desse jeito ou se tem uma forma de definir quem começa a jogar
            lblidj.Text = Entrar_Partida.colunas[0];
            lblsj.Text = Entrar_Partida.colunas[1];
            
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
