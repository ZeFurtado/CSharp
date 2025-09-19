using System.Globalization;

namespace Detetive;

public sealed class Jogador
{
    public string Nome { get; set; }
    public Arma Arma { get; set; }

    public Personagem Personagem { get; set; }


    public Jogador(string nome, Personagem personagem)
    {
        Nome = nome;
        Personagem = personagem;
    }

    public Jogador(string nome, Personagem personagem, Arma arma)
    {
        Nome = nome;
        Personagem = personagem;
        Arma = arma;
    }

    public int JogarDado()
    {
        return 6;
    }

    public string MoverPeao(Bloco posAtual)
    {
        return "b2";
    }
}
