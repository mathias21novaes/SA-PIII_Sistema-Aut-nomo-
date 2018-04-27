using System;

public class Personagens
{
    private string nome { get; set; }
    private int setor { get; set; } = -1;
    private int posicao { get; set; } = -1;

    public Personagens(string nome)
	{
        this.nome = nome;
	}
}
