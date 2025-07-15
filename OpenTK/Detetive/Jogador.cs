namespace Detetive;

public class Jogador
{
    public string Nome { get; set; }
    public List<Carta> Cartas { get; set; }

    public Jogador(string nome, List<Carta> cartas)
    {
        Nome = nome;
        Cartas = cartas;
    }
}
