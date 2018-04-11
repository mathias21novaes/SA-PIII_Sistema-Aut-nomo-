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
using System.Threading;

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

        public string Cartas { get; set; }
        public int idjog { get; set; }
        public static string[] jog { get; set; }
        public string ListarJogadores { get; set; }
        public string personagens { get; set; }
        public string voto { get; set; }
        public int contvoto { get; set; }

        public Jogo()
        {
            InitializeComponent();
            InitializeComponente();
            string versao = "3.0";
            Lobby f = new Lobby(versao);
            //f.Location = new Point(700, 700);
            f.ShowDialog();

            //verificar o codigo abaixo pois eles estão recebendo o ultimo jogador que entrou na partida
            //apenas ver se deixa desse jeito ou se tem uma forma de definir quem começa a jogar
            lblidj.Text = Entrar_Partida.JogadorId;
            idjog = int.Parse(Entrar_Partida.JogadorId);
            lblsj.Text = Entrar_Partida.JogadorSenha;
            lblnj.Text = Entrar_Partida.nome_jogador;

            this.Cartas = MePresidentaServidor.Jogo.ListarCartas(idjog, Entrar_Partida.JogadorSenha);
            lblCartas.Text = Cartas;

            ListarJogadores = MePresidentaServidor.Jogo.ListarJogadores(Entrar_Partida.idpartida);
            lblidjog.Text = ListarJogadores;

            this.personagens = MePresidentaServidor.Jogo.ListarPersonagens();
            lblnomejog.Text = personagens;

            /*jog = ListarJogadores.Split(',');
            string idj = jog[0];
            string nomej = jog[1];
            string pontj = jog[2];
            string idj2 = jog[3];

            /*lblidjog.Text = idj;
            lblnomejog.Text = nomej;
            lblpontjog.Text = pontj;*/
            //lblidjog.Text = Entrar_Partida.ListarJogadores;
            /*xtidjog.Text = idj;
            txtnomejog.Text = nomej;
            txtpontjog.Text = pontj;*/

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

        //votação
        private void btn_sim_Click(object sender, EventArgs e)
        {
            voto = "SIM";
            lblpontjog.Text = voto;
        }

        private void btn_nao_Click(object sender, EventArgs e)
        {
            voto = "NÃO";
            lblpontjog.Text = voto;
            contvoto++;
            if (contvoto > 3)
            {
                lblpontjog.Text = "NÃO PODE MAIS VOTAR (NÃO)";
                btn_nao.Enabled = false;
            }
        }



        private void InitializeComponente()
        {
            timertrue();
            if(txtidjog != txtnomejog)
            {
                 
                A.Location = new Point(603, 646);
            }
        }
        //Função esperar um tempo
        private async void timertrue()
        {
            await Task.Delay(8000);
        }
        //private Point primeiroPoint = new Point();
    }
}
