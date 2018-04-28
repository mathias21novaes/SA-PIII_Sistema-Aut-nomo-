using System;

public class Personagens
{
    public string nome { get; set; }
    public int setor { get; set; } = -1;
    public int posicao { get; set; } = -1;

    public Personagens(string nome)
	{
        this.nome = nome;
	}
}
