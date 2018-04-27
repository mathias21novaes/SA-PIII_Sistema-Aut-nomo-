using System;
using System.Collections;


namespace President_Me
{
    public partial class Setor
    {
        private int setor { get; set; }
        private int tamanho { get; set; }
        private int i { get; set; } = 0;
        private Posicao pos1 = new Posicao();
        private Posicao pos2 = new Posicao();
        private Posicao pos3 = new Posicao();
        private Posicao pos4 = new Posicao();
        private ArrayList posicoes = new ArrayList();

        public Setor(int setor, int tamanho)
        {
            this.setor = setor;
            this.tamanho = tamanho;

            posicoes.Add(pos1);
            posicoes.Add(pos2);
            posicoes.Add(pos3);
            posicoes.Add(pos4);
        }
    }
}
