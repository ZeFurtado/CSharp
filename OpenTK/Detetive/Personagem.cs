namespace Detetive;

public class Personagem
{
    public string Nome { get; set; }
    public string Cor { get; set; }

    public Personagem(string Nome, string Cor)
    {
        this.Nome = Nome;
        this.Cor = Cor;
    }
}
