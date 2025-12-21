namespace Detetive.Classes;

public class Local
{
    public Bloco[] Area { get; set; }
    public Bloco Entrada { get; set; }
    public Bloco Passagem_secreta { get; set; }

    public Local(Bloco[] area, Bloco entrada)
    {
        Area = area;
        Entrada = entrada;
    }

    public Local(Bloco[] area, Bloco entrada, Bloco passagem_secreta)
    {
        Area = area;
        Entrada = entrada;
        Passagem_secreta = passagem_secreta;
    }
}
