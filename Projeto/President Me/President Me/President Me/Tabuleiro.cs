﻿using System;
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

        public Tabuleiro()
        {
            InitializeComponent();
            string versao = "3.0";
            Lobby f = new Lobby(versao);
            f.ShowDialog();
            jogadorVez = Entrar_Partida.idJogador;
            jogadorVez = lblVez.Text;

            //if(Entrar_Partida.iniciou_partida == true)
            //{
            //    Jogo            }


           


        }
    }
}
