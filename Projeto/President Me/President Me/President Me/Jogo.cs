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
        public int jogador { get; set; }
        public int vez { get; set; }
        public string jogadorVez { get; set; }
        public string jogadorid { get; set; }
        public string jogadorsenha { get; set; }

        public string Cartas { get; set; }
        public int idjog { get; set; }
        public static string[] jog { get; set; }
        public string ListarJogadores { get; set; }
        public string personagens { get; set; }
        public string voto { get; set; }
        public int contvoto { get; set; }

        public string personagem { get; set; }
        public int setor { get; set; }
        public string [,] matriz { get; set; } =  new string [20,4];

        public Jogo()
        {
            InitializeComponent();
            string versao = "3.0";
            Lobby f = new Lobby(versao);
            f.ShowDialog();

            lblidj.Text = Entrar_Partida.JogadorId;
            lblsj.Text = Entrar_Partida.JogadorSenha;
            lblnj.Text = Entrar_Partida.nome_jogador;
            if (String.IsNullOrEmpty(Entrar_Partida.JogadorId))
            {
                this.Close();
            }
            else
                idjog = int.Parse(Entrar_Partida.JogadorId);

            //DEVERÁ SER SER FEITO UM TRATAMENTO DE ERRO NO CÓDIGO DE LISTAR CARTAS
            Cartas = MePresidentaServidor.Jogo.ListarCartas(idjog, Entrar_Partida.JogadorSenha);
            lblCartas.Text = Cartas;

            ListarJogadores = MePresidentaServidor.Jogo.ListarJogadores(Entrar_Partida.idpartida);
            lblidjog.Text = ListarJogadores;

            this.personagens = MePresidentaServidor.Jogo.ListarPersonagens();
            lblnomejog.Text = personagens;

            /*if (Entrar_Partida.iniciou_partida == true)
            {
                timer_Verificavez.Enabled = true;
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

        private void Jogo_Load(object sender, EventArgs e)
        {
            //timer_Verificavez.Enabled = true;
            /*if (Entrar_Partida.iniciou_partida == true)
            {
                timer_Verificavez.Enabled = true;
            }*/

        //ACRESCENTANDO DADOS NOS COMBO BOX
            
            //PERSONAGENS
            cbPersonagens.Items.Add("A");
            cbPersonagens.Items.Add("B");
            cbPersonagens.Items.Add("C");
            cbPersonagens.Items.Add("D");
            cbPersonagens.Items.Add("E");
            cbPersonagens.Items.Add("F");
            cbPersonagens.Items.Add("G");
            cbPersonagens.Items.Add("I");
            cbPersonagens.Items.Add("L");
            cbPersonagens.Items.Add("M");
            cbPersonagens.Items.Add("N");
            cbPersonagens.Items.Add("O");
            cbPersonagens.Items.Add("P");

            //SETORES
            cbSetores.Items.Add("1");
            cbSetores.Items.Add("2");
            cbSetores.Items.Add("3");
            cbSetores.Items.Add("4");

            //DECLARAÇÃO DA MATRIZ
            matriz[0, 0] = Convert.ToString(this.pos00.Location.X) + ',' + Convert.ToString(this.pos00.Location.Y) + ",false";
            matriz[0, 1] = Convert.ToString(this.pos01.Location.X) + ',' + Convert.ToString(this.pos01.Location.Y) + ",false";
            matriz[0, 2] = Convert.ToString(this.pos02.Location.X) + ',' + Convert.ToString(this.pos02.Location.Y) + ",false";
            matriz[0, 3] = Convert.ToString(this.pos03.Location.X) + ',' + Convert.ToString(this.pos03.Location.Y) + ",false";
            matriz[1, 0] = Convert.ToString(this.pos10.Location.X) + ',' + Convert.ToString(this.pos10.Location.Y) + ",false";
            matriz[1, 1] = Convert.ToString(this.pos11.Location.X) + ',' + Convert.ToString(this.pos11.Location.Y) + ",false";
            matriz[1, 2] = Convert.ToString(this.pos12.Location.X) + ',' + Convert.ToString(this.pos12.Location.Y) + ",false";
            matriz[1, 3] = Convert.ToString(this.pos13.Location.X) + ',' + Convert.ToString(this.pos13.Location.Y) + ",false";
            matriz[2, 0] = Convert.ToString(this.pos20.Location.X) + ',' + Convert.ToString(this.pos20.Location.Y) + ",false";
            matriz[2, 1] = Convert.ToString(this.pos21.Location.X) + ',' + Convert.ToString(this.pos21.Location.Y) + ",false";
            matriz[2, 2] = Convert.ToString(this.pos22.Location.X) + ',' + Convert.ToString(this.pos22.Location.Y) + ",false";
            matriz[2, 3] = Convert.ToString(this.pos23.Location.X) + ',' + Convert.ToString(this.pos23.Location.Y) + ",false";
            matriz[3, 0] = Convert.ToString(this.pos30.Location.X) + ',' + Convert.ToString(this.pos30.Location.Y) + ",false";
            matriz[3, 1] = Convert.ToString(this.pos31.Location.X) + ',' + Convert.ToString(this.pos31.Location.Y) + ",false";
            matriz[3, 2] = Convert.ToString(this.pos32.Location.X) + ',' + Convert.ToString(this.pos32.Location.Y) + ",false";
            matriz[3, 3] = Convert.ToString(this.pos33.Location.X) + ',' + Convert.ToString(this.pos33.Location.Y) + ",false";
            matriz[4, 0] = Convert.ToString(this.pos40.Location.X) + ',' + Convert.ToString(this.pos40.Location.Y) + ",false";
            matriz[4, 1] = Convert.ToString(this.pos41.Location.X) + ',' + Convert.ToString(this.pos41.Location.Y) + ",false";
            matriz[4, 2] = Convert.ToString(this.pos42.Location.X) + ',' + Convert.ToString(this.pos42.Location.Y) + ",false";
            matriz[4, 3] = Convert.ToString(this.pos43.Location.X) + ',' + Convert.ToString(this.pos43.Location.Y) + ",false";
        }

        private void btnColocar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.cbPersonagens.Text) || String.IsNullOrEmpty(this.cbSetores.Text))
            {
                lblJogo.Text = "ESCOLHA O PERSONAGEM E DESTINO";
                //MessageBox.Show("Selecione o personagem e o destino.");
                return;
            }
            moverPersonagem(cbPersonagens.Text.Substring(0, 1), Convert.ToInt32(cbSetores.Text), true);
            lblJogo.Text = "";
        }

        public int moverPersonagem(string personagem, int setor, bool serv)
        {
            string[] aux = { };
            Control person = null;
            bool entrou = true;
            string senha = Entrar_Partida.JogadorSenha;

            if (serv)
            {
               string ColocarPersonagem = MePresidentaServidor.Jogo.ColocarPersonagem(Convert.ToInt32(Entrar_Partida.JogadorId), senha, setor, personagem);
               if (ColocarPersonagem.Contains("ERRO"))
               {
                    MessageBox.Show(ColocarPersonagem);
                    return -1;
               }
            }

            for (int i = 0; i < 4; i++)
            {
                aux = this.matriz[(Convert.ToInt32(setor) - 1), i].Split(',');
                if (aux[2] == "false")
                {
                    //persona.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));

                    cbPersonagens.Items.Remove(personagem);
                    //return 1;
                    if(cbPersonagens.Text == "A")
                    {
                        A.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    else if (cbPersonagens.Text == "B")
                    {
                        B.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    else if (cbPersonagens.Text == "C")
                    {
                        C.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    else if (cbPersonagens.Text == "D")
                    {
                        D.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                    }
                    else if (cbPersonagens.Text == "E")
                    {
                        E.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    else if (cbPersonagens.Text == "F")
                    {
                        F.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                    }
                    else if (cbPersonagens.Text == "G")
                    {
                        G.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    else if (cbPersonagens.Text == "I")
                    {
                        I.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    else if (cbPersonagens.Text == "L")
                    {
                        L.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    else if (cbPersonagens.Text == "M")
                    {
                        M.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    else if (cbPersonagens.Text == "N")
                    {
                        N.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    else if (cbPersonagens.Text == "O")
                    {
                        O.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    else if (cbPersonagens.Text == "P")
                    {
                        P.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    return 1;
                }
                if (entrou == false)
                    {
                        //MessageBox.Show("Nível cheio");
                        matriz[(Convert.ToInt32(cbSetores) - 1), i] = aux[0] + ',' + aux[1] + ',' + true;
                    }
            }
            return 0;  
        }

        private void timer_Verificavez_Tick(object sender, EventArgs e)
        {
            string verificavez = MePresidentaServidor.Jogo.VerificarVez(idjog);
            verificavez = verificavez.Replace("\r", "");
            string[] tabuleiro = verificavez.Split('\n');
            string jogadorDaVez = tabuleiro[0];

            if (jogadorDaVez.Contains(Entrar_Partida.JogadorId))
            {
                lblJogo.Text = "SUA VEZ DE JOGAR";
                this.btnColocar.Enabled = true;
                moverPersonagem(cbPersonagens.Text.Substring(0, 1), Convert.ToInt32(cbSetores.Text), true);
            }
            else
            {
                lblJogo.Text = "AGUARDE SUA VEZ";
                this.btnColocar.Enabled = false;
            }
        }

        /*public void atualizaTabuleiro(string tabuleiro)
        {
            tabuleiro = tabuleiro.Replace("\r", "");
            string[] posicoes = tabuleiro.Split('\n');
            string[] personagem;
            if (tabuleiro.Length > 2)
            {
                for (int i = 0; i < posicoes.Length - 1; i++)
                {
                    personagem = posicoes[i].Split(',');
                    if ()
                    {
                        moverPersonagem(personagem[1], Convert.ToInt32(personagem[0]), false);
                    }
                    else
                    {
                        movePersonagem(personagem[1], Convert.ToInt32(personagem[0]));
                    }

                }
            }
        }*/
    }
}
