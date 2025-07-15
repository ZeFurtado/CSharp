namespace Detetive;

public class Personagem
{
    public string Nome { get; set; }
    public string Cor { get; set; }

    public string PosInicial { get; set; }

    public Personagem(string nome, string cor)
    {
        Nome = nome;
        Cor = cor;
    }
}
