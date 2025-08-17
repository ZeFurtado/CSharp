namespace Detetive;

public class Personagem
{
    public string Nome { get; set; }
    public string Cor { get; set; }

    public Bloco PosInicial { get; set; }

    public Personagem(string nome, string cor, Bloco posInicial)
    {
        Nome = nome;
        Cor = cor;
        PosInicial = posInicial;
    }
}
