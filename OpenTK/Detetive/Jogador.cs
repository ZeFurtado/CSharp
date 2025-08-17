using System.Globalization;

namespace Detetive;

public sealed class Jogador
{
    public string Nome { get; set; }
    public List<Carta>? Cartas { get; set; }

    public Personagem Personagem { get; set; }


    public Jogador(string nome, Personagem personagem)
    {
        Nome = nome;
        Personagem = personagem;
    }

    public Jogador(string nome, Personagem personagem, List<Carta> cartas)
    {
        Nome = nome;
        Personagem = personagem;
        Cartas = cartas;
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
