using System.Dynamic;

namespace Detetive;

public class Carta
{
    string Nome { get; set; }
    string Tipo { get; set; }

    public Carta(string Nome, string Tipo)
    {
        this.Nome = Nome;
        this.Tipo = Tipo;
    }
}
