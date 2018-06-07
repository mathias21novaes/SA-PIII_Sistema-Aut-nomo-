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
        public string SenhaPartida { get; set; }
        public string SituacaoPartida { get; set; }
        public string SituacaoRodada { get; set; }
        public int Permissao { get; set; } = 0;
        public int [,] jogadores = new int[6, 2];
        private string[] LtJogadores;
        /*-----------------------------------*/

        int X = 0;
        int Y = 0;

        public int Jog_Id { get; set; }
        public string auxJog { get; set; }
        public string Jog_Senha { get; set; }
        public string Jog_Nome { get; set; }
        public int Part_Id { get; set; }
        public string[] setorquant { get; set; } = new string[5];
        public int quant { get; set; } = 0;


        //public string SituacaoPartida { get; set; }
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
            this.SenhaPartida = Entrar_Partida.SenhaPartida;
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

        private void Jogo_Load(object sender, EventArgs e)
        {
            //this.Visible = true;
            Timer_Verificavez.Enabled = true;

            MostrarDados();
            CriarMatriz();
            Adicionarpersonagens();
            AdicionarSetores();
        }

        private void Timer_Verificavez_Tick(object sender, EventArgs e)
        {
            if (VerificaInicio() == 0)
            {
                lbl_Aviso.Text = "JOGO NÃO INICIADO";
                Pontuacao();
            }
            else
            {
                Pontuacao();
                Situacao_Partida();
                string VerificarVez = MePresidentaServidor.Jogo.VerificarVez(Jog_Id);
                VerificarVez = VerificarVez.Replace("\r", "");
                string[] tabuleiro = VerificarVez.Split('\n');
                string Vez = tabuleiro[0];
                personagem = tabuleiro[tabuleiro.Length - 1];
                lbljogadorvez.Text = Vez;
                MoverGrafica();

                Atualizacao = true;

                if (Vez == auxJog)
                {
                    lblJogo.Text = "SUA VEZ DE JOGAR";
                    lblJogo.ForeColor = Color.LimeGreen;
                    txthistorico.Text = personagem;
                    this.btn_colocar.Enabled = true;
                    Situacao_Rodada();
                }
                else
                {
                    lblJogo.Text = "AGUARDE SUA VEZ";
                    lbl_Aviso.Text = " ";
                    txt_personagem.Text = " ";
                    txt_setor.Text = " ";
                    lblJogo.ForeColor = Color.Red;
                    this.btn_colocar.Enabled = false;
                    UltimaVotacao();
                }
            }
            switch (tempo_servidor.Text)
            {
                case "1":
                    Timer_Verificavez.Interval = 1000;
                    break;
                case "2":
                    Timer_Verificavez.Interval = 2000;
                    break;
                case "3":
                    Timer_Verificavez.Interval = 3000;
                    break;
                case "4":
                    Timer_Verificavez.Interval = 4000;
                    break;
                case "5":
                    Timer_Verificavez.Interval = 5000;
                    break;
                default:
                    Timer_Verificavez.Interval = 3000;
                    break;

            }
        }

        //FUNÇÕES DO JOGO ----------------------------------------------------------
        public void Cartas()
        {
            string minhasCartas = MePresidentaServidor.Jogo.ListarCartas(Jog_Id, Jog_Senha);
            if (minhasCartas.Contains("ERRO"))
            {
                lblcartas.Text = " ";
            }
        }

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

        int VerificaInicio()
        {
            string VerificaVez = MePresidentaServidor.Jogo.VerificarVez(Jog_Id);
            if (VerificaVez.Contains("ERRO"))
            {
                return 0;
            }
            else
                MostrarDados();
            return 1;
        }

        public void MostrarDados()
        {
            Pontuacao();
            lblnj.Text = Jog_Nome;
            lblcartas.Text = MinhasCartas();
        }
        public string MinhasCartas()
        {
            string minhasCartas = MePresidentaServidor.Jogo.ListarCartas(Jog_Id, Jog_Senha);
            if (minhasCartas.Contains("ERRO")) { minhasCartas = null; }
            return minhasCartas;
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

        public bool BuscarCarta(char[] vetor, char letra)
        {
            for(int i = 0; i<= vetor.Length-1;i++)
            {
                if (vetor[i] == letra)
                    return true;
            }

            return false;
        }

        public void Situacao_Partida()
        {
            Status = MePresidentaServidor.Jogo.VerificarStatus(Jog_Id);
            string sta = Status.Replace("\r", "");
            string[] tabuleiro = new string[2];
            tabuleiro = sta.Split(',');
            SituacaoPartida = tabuleiro[0];
            SituacaoRodada = tabuleiro[1];

            switch (SituacaoPartida)
            {
                case "J":
                    Permissao = 1;
                    break;

                case "A":
                    lbl_Aviso.Text = "PARTIDA ABERTA";
                    break;

                case "E":
                    lbl_Aviso.ForeColor = Color.Red;
                    lbl_Aviso.Text = "PARTIDA ENCERRADA";
                    break;
            }
        }

        public void Situacao_Rodada()
        {
            if (Permissao == 1)
            {
                switch (SituacaoRodada)
                {
                    case "S":
                        lbl_Aviso.Text = "COLOQUE UM PERSONAGEM";
                        lbl_Aviso.ForeColor = Color.LimeGreen;
                        btn_colocar.Enabled = true;
                        btn_promover.Enabled = false;
                        btn_sim.Enabled = false;
                        btn_nao.Enabled = false;
                        if (Entrar_Partida.Automatico == 1) { MoverAuto(); }
                        break;

                    case "J":
                        lbl_Aviso.Text = "PROMOVA UM PERSONAGEM";
                        btn_promover.Enabled = true;
                        btn_colocar.Enabled = false;
                        btn_sim.Enabled = false;
                        btn_nao.Enabled = false;
                        if (Entrar_Partida.Automatico == 1) { PromoverAuto(); }
                        break;

                    case "V":
                        lbl_Aviso.Text = "VOTE NO PERSONAGEM";
                        btn_promover.Enabled = false;
                        btn_colocar.Enabled = false;
                        btn_sim.Enabled = true;
                        btn_nao.Enabled = true;
                        if (Entrar_Partida.Automatico == 1) { VotacaoAuto(); }
                        break;
                }
            }
        }

        public void UltimaVotacao()
        {
            string exibir = MePresidentaServidor.Jogo.ExibirUltimaVotacao(Jog_Id, Jog_Senha);
            if (exibir.Contains("ERRO"))
            {
                txtVotacao.Text = exibir;
            }
            txtVotacao.Text = exibir;
            /*if(exibir != "ERRO")
            {
                exibir = exibir.Replace("\r", "");
                exibir = exibir.Replace("\n", "");
                string[] voto = exibir.Split(',');
                string letravoto = voto[1];

                if (voto[1] == "S")
                    CriarMatriz();
            }*/
        }

        public void Pontuacao()
        {
            string Jogadores_lista;
            string[] jogador;
            int pontos1 = jogadores[0, 1];
            int pontos2 = jogadores[1, 1];

            string Aux = MePresidentaServidor.Jogo.ListarJogadores(Part_Id);
            if (Aux.Contains("ERRO"))
            {
                lbl_Aviso.Text = Aux;
            }
            Jogadores_lista = Aux.Replace("\r","");
            LtJogadores = Jogadores_lista.Split('\n');

            for (int i = 0; i < LtJogadores.Length - 1; i++)
            {
                jogador = LtJogadores[i].Split(',');
                jogadores[i, 0] = Convert.ToInt32(jogador[0]);
                jogadores[i, 1] = Convert.ToInt32(jogador[2]);

                switch (i)
                {
                    case 0:
                        n1.Text = jogador[1];
                        p1.Text = jogador[2];
                        break;
                    case 1:
                        n2.Text = jogador[1];
                        p2.Text = jogador[2];
                        break;
                    case 2:
                        n3.Text = jogador[1];
                        p3.Text = jogador[2];
                        break;
                    case 3:
                        n4.Text = jogador[1];
                        p4.Text = jogador[2];
                        break;
                    case 4:
                        n5.Text = jogador[1];
                        p5.Text = jogador[2];
                        break;
                    case 5:
                        n6.Text = jogador[1];
                        p6.Text = jogador[2];
                        break;
                    default:
                        break;
                }

            }


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

        //FUNÇÕES: COLOCAR, PROMOVER E VOTAR (ESTRATÉGIA) --------------------------------------
        public int MoverAuto()
        {
            bool entrou = true;
            string[] aux = { };
            int lugar = 0;
            int rand1 = aleatorio.Next(0, 13);
            int rand2 = aleatorio.Next(1, 5);
            int rand3 = aleatorio.Next(0, 4);
            string cartas = MinhasCartas();
            cartas = cartas.Replace("\r", "");
            cartas = cartas.Replace("\n", "");
            char[] matrizcartas = new char[cartas.Length];
            string ColocarPersonagem;

            for (int i = 0; i < cartas.Length; i++)
            {
                matrizcartas[i] = cartas[i];
            }
            if (arrayPersonagens[rand1].setor == -1)
            {
                if (arraySetores[rand2].i <= 3)
                {
                    ColocarPersonagem = MePresidentaServidor.Jogo.ColocarPersonagem(Jog_Id, Jog_Senha, arraySetores[rand2].setor, arrayPersonagens[rand1].nome);
                    if (ColocarPersonagem.Contains("ERRO"))
                    {
                        //lbl_Aviso.Text = ColocarPersonagem;
                        MoverAuto();
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
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "B")
                            {
                                B.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "C")
                            {
                                C.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "D")
                            {
                                D.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "E")
                            {
                                E.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "F")
                            {
                                F.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "G")
                            {
                                G.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "I")
                            {
                                I.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "L")
                            {
                                L.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "M")
                            {
                                M.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "N")
                            {
                                N.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "O")
                            {
                                O.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "P")
                            {
                                P.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            lugar++;
                            return 1;
                        }
                        else if (aux[2] == "true")
                        {
                            lugar++;
                            aux = matriz[(Convert.ToInt32(rand2) - 1), lugar].Split(',');
                            if (arrayPersonagens[rand1].nome == "A")
                            {
                                A.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "B")
                            {
                                B.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "C")
                            {
                                C.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "D")
                            {
                                D.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "E")
                            {
                                E.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "F")
                            {
                                F.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "G")
                            {
                                G.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "I")
                            {
                                I.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "L")
                            {
                                L.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "M")
                            {
                                M.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "N")
                            {
                                N.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                            }
                            else if (arrayPersonagens[rand1].nome == "O")
                            {
                                O.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                            else if (arrayPersonagens[rand1].nome == "P")
                            {
                                P.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                matriz[(Convert.ToInt32(rand2) - 1), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ",true";
                                entrou = true;
                            }
                        }
                    }
                }
            }

            return 0;

        }

        public void PromoverAuto()
        {
            string cartas = MinhasCartas();
            cartas = cartas.Replace("\r", "");
            cartas = cartas.Replace("\n", "");
            char[] matrizcartas = new char[cartas.Length];

            for (int i = 0; i < cartas.Length; i++)
            {
                matrizcartas[i] = cartas[i];
            }
            int rand;
            rand = aleatorio.Next(0, 13);
            string promover = MePresidentaServidor.Jogo.Promover(Jog_Id, Jog_Senha, arrayPersonagens[rand].nome);
            txthistorico.Text = promover;
            if (promover.Contains("ERRO"))
            {
                //lbl_Aviso.Text = ColocarPersonagem;
                PromoverAuto();
            }
            else
            {
                txthistorico.Text = promover;
            }

        }

        public void VotacaoAuto()
        {
            string cartas = MinhasCartas();
            cartas = cartas.Replace("\r", "");
            cartas = cartas.Replace("\n", "");
            char[] matrizcartas = new char[cartas.Length];

            for (int i = 0; i < cartas.Length; i++)
            {
                matrizcartas[i] = cartas[i];
            }

            string VerificarVez = MePresidentaServidor.Jogo.VerificarVez(Jog_Id);
            VerificarVez = VerificarVez.Replace("\r", "");
            string[] tabuleiro = VerificarVez.Split('\n');
            string[] tab = { };

            string exibir = MePresidentaServidor.Jogo.ExibirUltimaVotacao(Jog_Id, Jog_Senha);
            exibir = exibir.Replace("\r", "");
            string[] tabuleirovotacao = exibir.Split('\n');
            string[] tabvot = { };

            string Voto;
            string votar;

            if (tabuleiro.Length >= 3)
            {
                tab = tabuleiro[tabuleiro.Length - 2].Split(',');
                string perso = tab[1];
                string setor = tab[0];

                if (Convert.ToInt32(setor) == 10)
                {
                    if (tabuleirovotacao.Contains("ERRO"))
                    {

                    }
                    for (int i = 0; i < tabuleirovotacao.Length - 1; i++)
                    {
                        tabvot = tabuleirovotacao[i].Split(',');
                        if (tabvot[0].Contains("ERRO"))
                        {
                            break;
                        }
                        else
                        {
                            if (Convert.ToInt32(tabvot[0]) == Jog_Id)
                            {
                                if (tabvot[1] == "N")
                                {
                                    Voto = "s";
                                    votar = MePresidentaServidor.Jogo.Votar(Jog_Id, Jog_Senha, Voto);
                                    lblJogadas.Text = "VOTOU SIM";
                                }
                            }
                        }
                    }
                    if (BuscarCarta(matrizcartas, Convert.ToChar(perso)) == true)
                    {
                        Voto = "s";
                        votar = MePresidentaServidor.Jogo.Votar(Jog_Id, Jog_Senha, Voto);
                        lblJogadas.Text = "VOTOU SIM";
                    }
                    else
                    {
                        Voto = "n";
                        votar = MePresidentaServidor.Jogo.Votar(Jog_Id, Jog_Senha, Voto);
                        lblJogadas.Text = "VOTOU NÃO";
                    }
                    if (votar.Contains("ERRO"))
                    {
                        Voto = "s";
                        votar = MePresidentaServidor.Jogo.Votar(Jog_Id, Jog_Senha, Voto);
                        lblJogadas.Text = "VOTOU SIM";
                    }
                }

            }
        }

        //FUNÇÕES: COLOCAR, PROMOVER E VOTAR (HUMANO) ------------------------------------------
        public int Mover(string personagem, int setor, bool serv)
        {
            string[] aux = { };
            bool entrou = true;

            if (serv)
            {
                string ColocarPersonagem = MePresidentaServidor.Jogo.ColocarPersonagem(Jog_Id, Jog_Senha, setor, personagem);
                if (ColocarPersonagem.Contains("ERRO"))
                {
                    MessageBox.Show(ColocarPersonagem);
                    return -1;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                aux = matriz[(Convert.ToInt32(setor) - 1), i].Split(',');
                if (aux[2] == "false")
                {
                    if (txt_personagem.Text == "A")
                    {
                        A.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    else if (txt_personagem.Text == "B")
                    {
                        B.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    else if (txt_personagem.Text == "C")
                    {
                        C.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    else if (txt_personagem.Text == "D")
                    {
                        D.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    else if (txt_personagem.Text == "E")
                    {
                        E.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    else if (txt_personagem.Text == "F")
                    {
                        F.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    else if (txt_personagem.Text == "G")
                    {
                        G.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    else if (txt_personagem.Text == "I")
                    {
                        I.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    else if (txt_personagem.Text == "L")
                    {
                        L.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    else if (txt_personagem.Text == "M")
                    {
                        M.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    else if (txt_personagem.Text == "N")
                    {
                        N.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    else if (txt_personagem.Text == "O")
                    {
                        O.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    else if (txt_personagem.Text == "P")
                    {
                        P.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                        entrou = true;
                        break;
                    }
                    return 1;
                }
                if (entrou == false)
                {
                    lblJogo.Text = "NÍVEL CHEIO";
                    matriz[(Convert.ToInt32(txt_setor) - 1), i] = aux[0] + ',' + aux[1] + ',' + true;
                }
            }
            return 0;
        }

        public void Promover()
        {
            string promover = MePresidentaServidor.Jogo.Promover(Jog_Id, Jog_Senha, personagem);
            lbl_Aviso.Text = personagem + "PROMOVIDO";
            if (promover.Contains("ERRO")) { lbl_Aviso.Text = promover; }
        }

        public void Votacao(string Voto)
        {
            string votar = MePresidentaServidor.Jogo.Votar(Jog_Id, Jog_Senha, Voto);
            if (votar.Contains("ERRO")) { lbl_Aviso.Text = votar; }
        }

        public void MoverGrafica()
        {
            string VerificarVez = MePresidentaServidor.Jogo.VerificarVez(Jog_Id);
            VerificarVez = VerificarVez.Replace("\r", "");
            string[] tabuleiro = VerificarVez.Split('\n');
            string[] tab = { };
            string[] aux = { };
            //int lugar = 0;
            //Control persona = null;
            /*setorquant[0] = "0" + ',' + quant;
            setorquant[1] = "1" + ',' + quant;
            setorquant[2] = "2" + ',' + quant;
            setorquant[3] = "3" + ',' + quant;
            setorquant[4] = "4" + ',' + quant;
            setorquant[5] = "5" + ',' + quant;*/





            if (tabuleiro.Length >= 2)
            {
                for (int i = 1; i <= tabuleiro.Length - 1; i++)
                {
                    try
                    {
                        tab = tabuleiro[i].Split(',');
                        string perso = tab[1];
                        string setor = tab[0];
                        //setorquant = setorquant[Convert.ToInt32(setor)].Split(',');
                        //aux = matriz[Convert.ToInt32(setor) - 1, lugar].Split(',');
                        /*foreach (Control con in this.Controls)
                        {
                            if (con is PictureBox)
                            {
                                if (Convert.ToString(con.Tag) == perso)
                                {
                                    persona = con;
                                    break;
                                }
                            }
                        }*/

                        if (setor == "10")
                        {
                            presidente = perso;
                            //persona.Location = posPresidente.Location;
                            if (perso == "A")
                            {
                                A.Location = posPresidente.Location;
                            }
                            else if (perso == "B")
                            {
                                B.Location = posPresidente.Location;
                            }
                            else if (perso == "C")
                            {
                                C.Location = posPresidente.Location;
                            }
                            else if (perso == "D")
                            {
                                D.Location = posPresidente.Location;
                            }
                            else if (perso == "E")
                            {
                                E.Location = posPresidente.Location;
                            }
                            else if (perso == "F")
                            {
                                F.Location = posPresidente.Location;
                            }
                            else if (perso == "G")
                            {
                                G.Location = posPresidente.Location;
                            }
                            else if (perso == "I")
                            {
                                I.Location = posPresidente.Location;
                            }
                            else if (perso == "L")
                            {
                                L.Location = posPresidente.Location;
                            }
                            else if (perso == "M")
                            {
                                M.Location = posPresidente.Location;
                            }
                            else if (perso == "N")
                            {
                                N.Location = posPresidente.Location;
                            }
                            else if (perso == "O")
                            {
                                O.Location = posPresidente.Location;
                            }
                            else if (perso == "P")
                            {
                                P.Location = posPresidente.Location;
                            }

                        }
                        else
                        {
                            for (int lugar = 0; lugar < 4; lugar++)
                            {
                                aux = this.matriz[Convert.ToInt32(setor) - 1, lugar].Split(',');
                                if (aux[2] == "false")
                                {
                                    //persona.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                    //matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                    //break;
                                    if (perso == "A")
                                    {

                                        if (quant == 0)
                                        {
                                            lugar = 0;
                                            A.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 1)
                                        {
                                            lugar = 1;
                                            A.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 2)
                                        {
                                            lugar = 2;
                                            A.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        lugar = 3;
                                        A.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                        quant++;
                                        setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                        break;

                                    }
                                    else if (perso == "B")
                                    {
                                        if (quant == 0)
                                        {
                                            lugar = 0;
                                            B.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 1)
                                        {
                                            lugar = 1;
                                            B.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 2)
                                        {
                                            lugar = 2;
                                            B.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        lugar = 3;
                                        B.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                        quant++;
                                        setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                        break;
                                    }
                                    else if (perso == "C")
                                    {
                                        if (quant == 0)
                                        {
                                            lugar = 0;
                                            C.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 1)
                                        {
                                            lugar = 1;
                                            C.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 2)
                                        {
                                            lugar = 2;
                                            C.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        lugar = 3;
                                        C.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                        quant++;
                                        setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                        break;
                                    }
                                    else if (perso == "D")
                                    {
                                        if (quant == 0)
                                        {
                                            lugar = 0;
                                            D.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 1)
                                        {
                                            lugar = 1;
                                            D.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 2)
                                        {
                                            lugar = 2;
                                            D.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        lugar = 3;
                                        D.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                        quant++;
                                        setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                        break;
                                    }
                                    else if (perso == "E")
                                    {
                                        if (quant == 0)
                                        {
                                            lugar = 0;
                                            E.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 1)
                                        {
                                            lugar = 1;
                                            E.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 2)
                                        {
                                            lugar = 2;
                                            E.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        lugar = 3;
                                        E.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                        quant++;
                                        setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                        break;
                                    }
                                    else if (perso == "F")
                                    {
                                        if (quant == 0)
                                        {
                                            lugar = 0;
                                            F.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 1)
                                        {
                                            lugar = 1;
                                            F.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 2)
                                        {
                                            lugar = 2;
                                            F.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        lugar = 3;
                                        F.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                        quant++;
                                        setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                        break;
                                    }
                                    else if (perso == "G")
                                    {
                                        if (quant == 0)
                                        {
                                            lugar = 0;
                                            G.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 1)
                                        {
                                            lugar = 1;
                                            G.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 2)
                                        {
                                            lugar = 2;
                                            G.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        lugar = 3;
                                        G.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                        quant++;
                                        setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                        break;
                                    }
                                    else if (perso == "I")
                                    {
                                        if (quant == 0)
                                        {
                                            lugar = 0;
                                            I.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 1)
                                        {
                                            lugar = 1;
                                            I.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 2)
                                        {
                                            lugar = 2;
                                            I.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        lugar = 3;
                                        I.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                        quant++;
                                        setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                        break;
                                    }
                                    else if (perso == "L")
                                    {
                                        if (quant == 0)
                                        {
                                            lugar = 0;
                                            L.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 1)
                                        {
                                            lugar = 1;
                                            L.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 2)
                                        {
                                            lugar = 2;
                                            L.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        lugar = 3;
                                        L.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                        quant++;
                                        setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                        break;
                                    }
                                    else if (perso == "M")
                                    {
                                        if (quant == 0)
                                        {
                                            lugar = 0;
                                            M.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 1)
                                        {
                                            lugar = 1;
                                            M.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 2)
                                        {
                                            lugar = 2;
                                            M.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        lugar = 3;
                                        M.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                        quant++;
                                        setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                        break;
                                    }
                                    else if (perso == "N")
                                    {
                                        if (quant == 0)
                                        {
                                            lugar = 0;
                                            N.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 1)
                                        {
                                            lugar = 1;
                                            N.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 2)
                                        {
                                            lugar = 2;
                                            N.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        lugar = 3;
                                        N.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                        quant++;
                                        setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                        break;
                                    }
                                    else if (perso == "O")
                                    {
                                        if (quant == 0)
                                        {
                                            lugar = 0;
                                            O.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 1)
                                        {
                                            lugar = 1;
                                            O.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 2)
                                        {
                                            lugar = 2;
                                            O.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        lugar = 3;
                                        O.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                        quant++;
                                        setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                        break;
                                    }
                                    else if (perso == "P")
                                    {
                                        if (quant == 0)
                                        {
                                            lugar = 0;
                                            P.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 1)
                                        {
                                            lugar = 1;
                                            P.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        else if (quant == 2)
                                        {
                                            lugar = 2;
                                            P.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                            matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                            quant++;
                                            setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                            break;
                                        }
                                        lugar = 3;
                                        P.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                        quant++;
                                        setorquant[Convert.ToInt32(setor)] = setor + ',' + quant;
                                        break;
                                    }

                                }



                                /*else if (aux[2] != "false")
                                {
                                    lugar++;
                                    aux = matriz[Convert.ToInt32(setor) - 1, lugar].Split(',');
                                    if (perso == "A")
                                    {
                                        A.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + ","  + perso;
                                    }
                                    else if (perso == "B")
                                    {
                                        B.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                    }
                                    else if (perso == "C")
                                    {
                                        C.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                    }
                                    else if (perso == "D")
                                    {
                                        D.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                    }
                                    else if (perso == "E")
                                    {
                                        E.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                    }
                                    else if (perso == "F")
                                    {
                                        F.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                    }
                                    else if (perso == "G")
                                    {
                                        G.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                    }
                                    else if (perso == "I")
                                    {
                                        I.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                    }
                                    else if (perso == "L")
                                    {
                                        L.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                    }
                                    else if (perso == "M")
                                    {
                                        M.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                    }
                                    else if (perso == "N")
                                    {
                                        N.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                    }
                                    else if (perso == "O")
                                    {
                                        O.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                    }
                                    else if (perso == "P")
                                    {
                                        P.Location = new Point(Convert.ToInt32(aux[0]), Convert.ToInt32(aux[1]));
                                        matriz[Convert.ToInt32(setor), lugar] = Convert.ToString(aux[0]) + ',' + Convert.ToString(aux[1]) + "," + perso;
                                    }
                                }*/
                            }
                        }
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        break;
                    }

                }
            }
        }

        //FUNÇÃO DOS BOTÕES E SUAS INTERAÇÕES --------------------------------------------------
        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Timer_Verificavez.Enabled = false;
            //this.Visible = false;
            //string versao = "5.0";
            //Lobby flob = new Lobby(versao);
            //flob.ShowDialog();
        }

        private void btn_promover_Click(object sender, EventArgs e)
        {
            Promover();
        }

        private void btn_sim_Click(object sender, EventArgs e)
        {
            string Voto = "S";
            Votacao(Voto);
        }

        private void btn_nao_Click(object sender, EventArgs e)
        {
            string Voto = "N";
            Votacao(Voto);
        }

        private void btn_colocar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txt_personagem.Text) || String.IsNullOrEmpty(this.txt_setor.Text))
            {
                lblJogo.Text = "ESCOLHA O PERSONAGEM E DESTINO";
                return;
            }
            Mover(txt_personagem.Text.Substring(0, 1), Convert.ToInt32(txt_setor.Text), true);
            lblJogo.Text = "";
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            string IniciarPartida = MePresidentaServidor.Jogo.Iniciar(Part_Id, SenhaPartida);
            if (IniciarPartida.Contains("ERRO"))
            {
                lbl_Aviso.Text = "JOGADORES INSUFICIENTES";
            }
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