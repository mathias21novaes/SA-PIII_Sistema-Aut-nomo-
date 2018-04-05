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
        //---VARIAVEIS---

        public string Versao { get; set; }

        public string idp { get; set; }
        public int idpartida { get; set; }
        public static string nome_jogador { get; set; }
        public string senha_partida { get; set; }

        public int numJogadores { get; set; }
        public string idesenha_jogador { get; set; }
        public string ListarJogadores { get; set; }
        public static bool iniciou_partida { get; set; }
        public bool initpart { get; set; }

        public static string []colunas { get; set; }
        public string []listP { get; set; }
        public static string []id { get; set; }
        public static string []jog { get; set; }

        public string listar { get; set; }
        public string listpartidas { get; set; }

        public static string Jogador { get; set; }
        public static string JogadorId { get; set; }
        public static string JogadorSenha { get; set; }

        public static string idj { get; set; }
        public static string nomej { get; set; }
        public static string pontj { get; set; }

        public Entrar_Partida()
        {
            InitializeComponent();
            listar = MePresidentaServidor.Jogo.ListarPartidas();
            listP = this.listar.Split('\n');
            for (int i = 0; i < listP.Length; i++)
            {
                listPartidas.Items.Add(listP[i].ToString());
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Lobby f = new Lobby(Versao);
            iniciou_partida = false;
            initpart = false;
            this.Close();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            idpartida = int.Parse(id[1]);
            nome_jogador = txtJogador.Text;
            senha_partida = txtSenha_Entrar.Text;
            this.idesenha_jogador = MePresidentaServidor.Jogo.Entrar(idpartida, nome_jogador, senha_partida);
            lblEntrou1.Text = "ENTROU NA PARTIDA";

            colunas = this.idesenha_jogador.Split(',');
            JogadorId = colunas[0];
            JogadorSenha = colunas[1];
            lblDadosJogadorId.Text = JogadorId;
            lblDadosJogadorSenha.Text = JogadorSenha;
            this.numJogadores++;

            ListarJogadores = MePresidentaServidor.Jogo.ListarJogadores(idpartida);
            jog = this.ListarJogadores.Split(',','\r','\n');
            idj = jog[0];
            nomej = jog[1];
            pontj = jog[2];
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (initpart == true)
            {
                Jogador = MePresidentaServidor.Jogo.Iniciar(idpartida, senha_partida);
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
            this.listpartidas = listPartidas.Text.ToString();
            id = this.listpartidas.Split(',');
            String status = id[0];
            String idl = id[1];
            String data = id[2];
            String nome = id[3];
        }

        private void NumJogadores_Tick(object sender, EventArgs e)
        {
            if(numJogadores > 1 && numJogadores < 7)
            {
                initpart = true;
                btn_iniciar.Enabled = true;
            }
        }
    }
}
