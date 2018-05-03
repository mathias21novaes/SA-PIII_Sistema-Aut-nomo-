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
    public partial class Entrar_Partida : Form
    {
        //----------------- VARIAVEIS -------------------------------//

        public string Versao { get; set; }
        public int numJogadores { get; set; }
        public static int IdPartida { get; set; }
        public static bool iniciou_partida { get; set; }
        public static string JogadorId { get; set; }
        public static string JogadorSenha { get; set; }
        public static string SenhaPartida { get; set; }
        public static string NomeJogador { get; set; }
        public static string[] colunas { get; set; }
        public static string[] id { get; set; } = new string[2];

        public Entrar_Partida()
        {
            InitializeComponent();
            string listar = MePresidentaServidor.Jogo.ListarPartidas();
            string [] listP = listar.Split('\n');
            
            for (int i = 0; i < listP.Length; i++)
            {
                listPartidas.Items.Add(listP[i].ToString());
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Lobby f = new Lobby(Versao);
            iniciou_partida = false;
            this.Close();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            IdPartida = Convert.ToInt32(id[1]);
            NomeJogador = txtJogador.Text;
            SenhaPartida = txtSenha_Entrar.Text;
            string idesenha_jogador = MePresidentaServidor.Jogo.Entrar(IdPartida, NomeJogador, SenhaPartida);
            lblEntrou1.Text = "ENTROU NA PARTIDA";

            colunas = idesenha_jogador.Split(',');
            JogadorId = colunas[0];
            JogadorSenha = colunas[1];
            this.numJogadores++;
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (numJogadores >= 1 && numJogadores < 7)
            {
                string IniciarPartida = MePresidentaServidor.Jogo.Iniciar(IdPartida, SenhaPartida);
                iniciou_partida = true;
                this.Close();
            }
            else
            {
                lblnumJog.Text = "JOGADORES INSUFICIENTES";
                iniciou_partida = false;
            }
        }

        private void listPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string listpartidas = listPartidas.Text.ToString();
            id = listpartidas.Split(',');
            String status = id[0];
            String idl = id[1];
            String data = id[2];
            String nome = id[3];
        }

    }
}
