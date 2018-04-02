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
    public partial class Jogo : Form
    {
        /*public int jogador { get; set; }
        public int vez { get; set; }
        public string jogadorVez { get; set; }
        public string jogadorid { get; set; }
        public string jogadorsenha { get; set; }
        */
        public Jogo()
        {
            InitializeComponent();
            //InitializeComponente();
            string versao = "3.0";
            Lobby f = new Lobby(versao);
            f.Location = new Point(700, 700);
            f.ShowDialog();
            lblidjog.Text = Entrar_Partida.idj;
            lblnomejog.Text = Entrar_Partida.nomej;
            lblpontjog.Text = Entrar_Partida.pontj;
            //lblidjog.Text = Entrar_Partida.ListarJogadores;

            
            txtidjog.Text = Entrar_Partida.idj;
            txtnomejog.Text = Entrar_Partida.nomej;
            txtpontjog.Text = Entrar_Partida.pontj;
            //lblidjog.Text = Entrar_Partida.ListarJogadores;
            //verificar o codigo abaixo pois eles estão recebendo o ultimo jogador que entrou na partida
            //apenas ver se deixa desse jeito ou se tem uma forma de definir quem começa a jogar
            lblidj.Text = Entrar_Partida.JogadorId;
            lblsj.Text = Entrar_Partida.JogadorSenha;



            /*vez = int.Parse(jogadorid);
            lblVez.Text = jogadorVez;

            jogadorVez = Jogo.VerificarVez(vez);
            Entrar_Partida.colunas[0] = jogador;
            while(jogador != vez)
            {
              Thread.Sleep(3000);
            string fdsfd= Jogo.VerificarVez(vez);
            }*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*private void InitializeComponente()
        {
            pictureBox6.Image = pictureBox7;
        }*/
        //private Point primeiroPoint = new Point();
    }
}
