using System;
using System.Collections;


namespace President_Me
{
    public partial class Setor
    {
        public int setor { get; set; }
        public int tamanho { get; set; }
        public int i { get; set; } = 0;
        public Posicao pos1 = new Posicao();
        public Posicao pos2 = new Posicao();
        public Posicao pos3 = new Posicao();
        public Posicao pos4 = new Posicao();
        public ArrayList posicoes = new ArrayList();

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
