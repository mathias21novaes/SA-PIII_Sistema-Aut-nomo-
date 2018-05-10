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
using System.Collections;

namespace President_Me
{
    public partial class Jogo : Form
    {
        //TO MEXENDO NESSE CARALHO
        //public static string[] jog { get; set; }
        public string personagens { get; set; }
        public string personagem { get; set; }
        //public int setor { get; set; }
        public string[,] matriz { get; set; } = new string[30, 30];
        public bool Atualizacao { get; set; } = false;
        public string presidente { get; set; }

        /*-----------------------------------*/

        int X = 0;
        int Y = 0;

        public int Jog_Id { get; set; }
        public string auxJog { get; set; }
        public string Jog_Senha { get; set; }
        public string Jog_Nome { get; set; }
        public int Part_Id { get; set; }
        //public int estado_Jogo { get; set; } = 0;
        public string Status { get; set; }

        //CRIAÇÃO DE PERSONAGENS
        public Personagens a { get; set; }
        public Personagens b { get; set; }
        public Personagens c { get; set; }
        public Personagens d { get; set; }
        public Personagens e { get; set; }
        public Personagens f { get; set; }
        public Personagens g { get; set; }
        public Personagens i { get; set; }
        public Personagens l { get; set; }
        public Personagens m { get; set; }
        public Personagens n { get; set; }
        public Personagens o { get; set; }
        public Personagens p { get; set; }

        //CRIAÇÃO DE SETORES
        public Cl_Setor setor0 { get; set; }
        public Cl_Setor setor1 { get; set; }
        public Cl_Setor setor2 { get; set; }
        public Cl_Setor setor3 { get; set; }
        public Cl_Setor setor4 { get; set; }
        public Cl_Setor setor5 { get; set; }
        public Cl_Setor setor10 { get; set; }

        //ARRAY LIST PERSONAGENS, SETORES E VOTOS
        public static List<Personagens> arrayPersonagens { get; set; } = new List<Personagens>();
        public static List<Cl_Setor> arraySetores { get; set; } = new List<Cl_Setor>();

        Random aleatorio = new Random();

        public Jogo()
        {
            InitializeComponent();
            string versao = "5.0";
            Lobby flob = new Lobby(versao);
            flob.ShowDialog();

            this.Part_Id = Entrar_Partida.IdPartida;
            this.Jog_Senha = Entrar_Partida.JogadorSenha;
            this.Jog_Nome = Entrar_Partida.NomeJogador;
            this.auxJog = Entrar_Partida.JogadorId;

            if (String.IsNullOrEmpty(auxJog))
            {
                this.Close();
            }
            else
                Jog_Id = Convert.ToInt32(auxJog);

            this.MouseDown += new MouseEventHandler(Jogo_MouseDown);
            this.MouseMove += new MouseEventHandler(Jogo_MouseMove);

        }

        private void Timer_Verificavez_Tick(object sender, EventArgs e)
        {
            string VerificarVez = MePresidentaServidor.Jogo.VerificarVez(Jog_Id);
            VerificarVez = VerificarVez.Replace("\r", "");
            string[] tabuleiro = VerificarVez.Split('\n');
            string Vez = tabuleiro[0];
            personagem = tabuleiro[tabuleiro.Length - 1];
            lbljogadorvez.Text = Vez;

            Atualizacao = true;

            if (Vez == auxJog)
            {
                lblJogo.Text = "SUA VEZ DE JOGAR";
                lblJogo.ForeColor = Color.LimeGreen;
                txthistorico.Text = personagem;
                this.btnColocar.Enabled = true;
                Jogada();
            }
            else
            {
                lblJogo.Text = "AGUARDE SUA VEZ";
                lbl_Aviso.Text = " ";
                lbl_Voto.Text = " ";
                lblJogo.ForeColor = Color.Red;
                this.btnColocar.Enabled = false;
                UltimaVotacao();
            }
        }

        //FUNÇÕES DO JOGO ----------------------------------------------------------

        public void Adicionarpersonagens()
        {
            // INSTANCIAMENTO DE PERSONAGENS
            a = new Personagens("A");
            b = new Personagens("B");
            c = new Personagens("C");
            d = new Personagens("D");
            e = new Personagens("E");
            f = new Personagens("F");
            g = new Personagens("G");
            i = new Personagens("I");
            l = new Personagens("L");
            m = new Personagens("M");
            n = new Personagens("N");
            o = new Personagens("O");
            p = new Personagens("P");

            // ADICIONA PERSONAGENS
            arrayPersonagens.Add(a);
            arrayPersonagens.Add(b);
            arrayPersonagens.Add(c);
            arrayPersonagens.Add(d);
            arrayPersonagens.Add(e);
            arrayPersonagens.Add(f);
            arrayPersonagens.Add(g);
            arrayPersonagens.Add(i);
            arrayPersonagens.Add(l);
            arrayPersonagens.Add(m);
            arrayPersonagens.Add(n);
            arrayPersonagens.Add(o);
            arrayPersonagens.Add(p);
        }

        public void AdicionarSetores()
        {
            // INSTANCIAMENTO DE SETORES
            setor0 = new Cl_Setor(0, 4);
            setor1 = new Cl_Setor(1, 4);
            setor2 = new Cl_Setor(2, 4);
            setor3 = new Cl_Setor(3, 4);
            setor4 = new Cl_Setor(4, 4);
            setor5 = new Cl_Setor(5, 4);
            setor10 = new Cl_Setor(10, 1);

            // ADICIONAR SETORES
            arraySetores.Add(this.setor0);
            arraySetores.Add(this.setor1);
            arraySetores.Add(this.setor2);
            arraySetores.Add(this.setor3);
            arraySetores.Add(this.setor4);
            arraySetores.Add(this.setor5);
            arraySetores.Add(this.setor10);
        }

        public void MostrarDados()
        {
            string minhasCartas = MePresidentaServidor.Jogo.ListarCartas(Jog_Id, Jog_Senha);
            if (minhasCartas.Contains("ERRO"))
            {
                lbl_Aviso.Text = minhasCartas;
            }
            Pontuacao();
            lblidj.Text = auxJog;
            lblnj.Text = Jog_Nome;
            lblsj.Text = Jog_Senha;
            lblidp.Text = Convert.ToString(Part_Id);
            lblcartas.Text = minhasCartas;
        }

        public void CriarPersonagens()
        {
            cbPersonagens.Items.Clear();
            string personagem = MePresidentaServidor.Jogo.ListarPersonagens();
            lblpersonagens.Text = personagem;
            personagem = personagem.Replace("\r", "");
            string[] psg = personagem.Split('\n');

            for (int i = 0; i < psg.Length - 1; i++)
            {
                cbPersonagens.Items.Add(psg[i].Substring(0, 1));
            }
        }

        public void CriarSetores()
        {
            cbSetores.Items.Add("1");
            cbSetores.Items.Add("2");
            cbSetores.Items.Add("3");
            cbSetores.Items.Add("4");
        }

        public void CriarMatriz()
        {
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
            matriz[5, 0] = Convert.ToString(this.pos40.Location.X) + ',' + Convert.ToString(this.pos40.Location.Y) + ",false";
            matriz[5, 1] = Convert.ToString(this.pos41.Location.X) + ',' + Convert.ToString(this.pos41.Location.Y) + ",false";
            matriz[5, 2] = Convert.ToString(this.pos42.Location.X) + ',' + Convert.ToString(this.pos42.Location.Y) + ",false";
            matriz[5, 3] = Convert.ToString(this.pos43.Location.X) + ',' + Convert.ToString(this.pos43.Location.Y) + ",false";
            matriz[6, 0] = Convert.ToString(this.pos43.Location.X) + ',' + Convert.ToString(this.pos43.Location.Y) + ",false";

            presidente = "";
        }

        public void Jogada()
        {
            Pontuacao();
            Status = MePresidentaServidor.Jogo.VerificarStatus(Jog_Id);
            string sta = Status.Replace("\r", "");
            string[] tabuleiro = new string[2];
            tabuleiro = sta.Split(',');
            string SituacaoPartida = tabuleiro[0];
            string SituacaoRodada = tabuleiro[1];

            switch (SituacaoPartida)
            {
                case "J":
                    switch (SituacaoRodada)
                    {
                        case "S":
                            Pontuacao();
                            lbl_Aviso.Text = "COLOQUE UM PERSONAGEM";
                            lbl_Aviso.ForeColor = Color.LimeGreen;
                            btn_sim.Enabled = false;
                            btn_nao.Enabled = false;
                            MoverPersonagem();
                            break;

                        case "J":
                            lbl_Aviso.Text = "PROMOVA UM PERSONAGEM";
                            Promover();
                            //btn_promover.Enabled = true;
                            break;

                        case "V":
                            lbl_Aviso.Text = "VOTE NO PERSONAGEM";
                            btn_promover.Enabled = false;
                            btn_sim.Enabled = true;
                            btn_nao.Enabled = true;
                            Votacao();
                            break;
                    }
                    break;

                case "A":
                    lbl_Aviso.Text = "A PARTIDA ESTA ABERTA";
                    break;

                case "E":
                    lbl_Aviso.ForeColor = Color.Red;
                    lbl_Aviso.Text = "PARTIDA ENCERRADA";
                    break;
            }
        }

        private void Jogo_Load(object sender, EventArgs e)
        {
            Timer_Verificavez.Enabled = true;

            MostrarDados();
            CriarPersonagens();
            CriarSetores();
            CriarMatriz();
            Adicionarpersonagens();
            AdicionarSetores();
        }

        public void UltimaVotacao()
        {
            string exibir = MePresidentaServidor.Jogo.ExibirUltimaVotacao(Jog_Id, Jog_Senha);
            txtVotacao.Text = exibir;
            if (exibir.Contains("ERRO"))
            {
                txtVotacao.Text = exibir;
            }
        }

        public void Pontuacao()
        {
            string Aux = MePresidentaServidor.Jogo.ListarJogadores(Part_Id);
            lbljogadores.Text = Aux;
            /*Aux = Aux.Replace("\r"," ");
            string[] dados = new string[3];
            dados = Aux.Split('\n');
            string pontuacao = dados[dados.Length - 1];
            lbljogadores.Text = pontuacao;*/
        }

        void AtualizarSetor(int setor)
        {
            if (setor == 0)
                arraySetores[0].contmais();
            else if (setor == 1)
                arraySetores[1].contmais();
            else if (setor == 2)
                arraySetores[2].contmais();
            else if (setor == 3)
                arraySetores[3].contmais();
            else if (setor == 4)
                arraySetores[4].contmais();
            else if (setor == 5)
                arraySetores[5].contmais();
            else if (setor == 6)
                arraySetores[6].contmais();
        }

        //FUNÇÕES: COLOCAR, PROMOVER E VOTAR PERSONAGEM ------------------------------------------
        public int MoverPersonagem()
        {
            int rand1;
            int rand2;
            int rand3;
            bool entrou = true;
            string[] aux = { };
            int lugar = 0;

            rand1 = aleatorio.Next(0, 13);
            rand2 = aleatorio.Next(1, 5);
            rand3 = aleatorio.Next(0, 4);
            if (arrayPersonagens[rand1].setor == -1)
            {
                if (arraySetores[rand2].i <= 3)
                {
                    string ColocarPersonagem = MePresidentaServidor.Jogo.ColocarPersonagem(Jog_Id, Jog_Senha, arraySetores[rand2].setor, arrayPersonagens[rand1].nome);
                    if (ColocarPersonagem.Contains("ERRO"))
                    {
                        //lbl_Aviso.Text = ColocarPersonagem;
                        MoverPersonagem();
                    }
                    else
                    {
                        txthistorico.Text = ColocarPersonagem;
                    }
                    if (entrou == true)
                    {
                        aux = matriz[(Convert.ToInt32(rand2) - 1), lugar].Split(',');
                        if (aux[2] == "false")
                        {
                            if (arrayPersonagens[rand1].nome == "A")
                            {
                                A.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                aux[2] = "true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "B")
                            {
                                B.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                aux[2] = "true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "C")
                            {
                                C.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                aux[2] = "true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "D")
                            {
                                D.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                aux[2] = "true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "E")
                            {
                                E.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                aux[2] = "true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "F")
                            {
                                F.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                aux[2] = "true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "G")
                            {
                                G.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                aux[2] = "true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "I")
                            {
                                I.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                cbPersonagens.Items.Remove("I");
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "L")
                            {
                                L.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                cbPersonagens.Items.Remove("L");
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "M")
                            {
                                M.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                cbPersonagens.Items.Remove("M");
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "N")
                            {
                                N.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                cbPersonagens.Items.Remove("N");
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "O")
                            {
                                O.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                cbPersonagens.Items.Remove("O");
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "P")
                            {
                                P.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                cbPersonagens.Items.Remove("P");
                                entrou = true;
                            }
                            lugar++;
                            return 1;
                        }
                        else if (aux[2] == "true")
                        {
                            aux = matriz[(Convert.ToInt32(rand2) - 1), 1].Split(',');
                            if (arrayPersonagens[rand1].nome == "A")
                            {
                                A.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                aux[2] = "true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "B")
                            {
                                B.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                aux[2] = "true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "C")
                            {
                                C.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                aux[2] = "true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "D")
                            {
                                D.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                aux[2] = "true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "E")
                            {
                                E.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                aux[2] = "true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "F")
                            {
                                F.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                aux[2] = "true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "G")
                            {
                                G.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                aux[2] = "true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "I")
                            {
                                I.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                cbPersonagens.Items.Remove("I");
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "L")
                            {
                                L.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                cbPersonagens.Items.Remove("L");
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "M")
                            {
                                M.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                cbPersonagens.Items.Remove("M");
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "N")
                            {
                                N.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                cbPersonagens.Items.Remove("N");
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "O")
                            {
                                O.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                cbPersonagens.Items.Remove("O");
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "P")
                            {
                                P.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                cbPersonagens.Items.Remove("P");
                                entrou = true;
                            }
                        }
                    }
                }
            }
            return 0;
            
        }

        public void Promover()
        {
            int rand;
            rand = aleatorio.Next(0, 13);
            string promover = MePresidentaServidor.Jogo.Promover(Jog_Id, Jog_Senha, arrayPersonagens[rand].nome);
            txthistorico.Text = promover;
            if (promover.Contains("ERRO"))
            {
                //lbl_Aviso.Text = ColocarPersonagem;
                Promover();
            }
            else
            {
                txthistorico.Text = promover;
            }
        }

        public void Votacao()
        {
            int rand3;
            string Voto;
            rand3 = aleatorio.Next(0, 2);
            string votar;
            if (rand3 == 0)
            {
                Voto = "s";
                votar = MePresidentaServidor.Jogo.Votar(Jog_Id, Jog_Senha, Voto);
                lbl_Voto.Text = "VOTOU SIM";
            }
            else
            {
                Voto = "n";
                votar = MePresidentaServidor.Jogo.Votar(Jog_Id, Jog_Senha, Voto);
                lbl_Voto.Text = "VOTOU NÃO";
            }
            if (votar.Contains("ERRO"))
            {
                Votacao();
            }
            else
            {
                lbl_Aviso.Text = votar;
            }
        }

        //FUNÇÃO DOS BOTÕES E SUAS INTERAÇÕES --------------------------------------------------
        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_promover_Click(object sender, EventArgs e)
        {
            //string personagem = txtpromover.Text;
            Promover();
        }

        private void btnColocar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.cbPersonagens.Text) || String.IsNullOrEmpty(this.cbSetores.Text))
            {
                lblJogo.Text = "ESCOLHA O PERSONAGEM E DESTINO";
                return;
            }
            lblJogo.Text = "";
        }

        private void btn_sim_Click(object sender, EventArgs e)
        {
            //string Voto = "s";
            //Votacao(Voto);
            lbl_Voto.Text = "VOTOU SIM";
        }

        private void btn_nao_Click(object sender, EventArgs e)
        {
            //string Voto = "n";
            //Votacao(Voto);
            lbl_Voto.Text = "VOTOU NÃO";
        }

        //MOVER JOGO NA TELA -------------------------------------------------------------------
        private void Jogo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void Jogo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}

/*public void atualizaTabuleiro(string tabuleiro)
        {
           string[] personagem;
           tabuleiro = verificavez.Split('\n');
           if (tabuleiro.Length > 2)
           {
               for (int i = 0; i < tabuleiro.Length - 1; i++)
               {
                   personagem = tabuleiro[i].Split(',');
                   if (cbPersonagens.Items.Contains(personagem[1]) && atualizacao == true)
                   {
                       atualizaPersonagem(personagem[1], Convert.ToInt32(personagem[0]));
                   }
                   else if (cbPersonagens.Items.Contains(personagem[1]))
                   {
                       moverPersonagem(personagem[1], Convert.ToInt32(personagem[0]), false);
                   }
               }
           }
        }*/

/*public void setaTabuleiro()
{
    string tabuleiro = MePresidentaServidor.Jogo.VerificarVez(Jog_Id);
    tabuleiro = tabuleiro.Replace("\r", "");
    string[] posicoes = tabuleiro.Split('\n');
    string[] personagem;
    string[] aux = { };
    Control persona = null;
    if (posicoes.Length > 1)
    {
        for (int i = 1; i < posicoes.Length - 1; i++)
        {
            personagem = posicoes[i].Split(',');
            foreach (Control con in this.Controls)
            {
                if (con is PictureBox)
                {
                    if (Convert.ToString(con.Tag) == personagem[1])
                    {
                        persona = con;
                        break;
                    }
                }
            }
            if (Convert.ToInt32(personagem[0]) == 10)
            {
                presidente = personagem[1];
                persona.Location = posPresidente.Location;
                //inGame = 3;
                return;
            }
            else
            {
                for (int j = 0; j < 4; j++)
                {
                    aux = this.matriz[Convert.ToInt32(Convert.ToInt32(personagem[0])), j].Split(',');
                    if (aux[2] == "false")
                    {
                        persona.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        this.matriz[Convert.ToInt32(Convert.ToInt32(personagem[0])), j] = aux[0] + ',' + aux[1] + ',' + personagem[1];
                        this.cbPersonagens.Items.Remove(personagem[1]);
                        break;
                    }
                }
            }
        }
    }
}*/
