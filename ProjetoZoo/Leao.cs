namespace ProjetoZoo;

public class Leao : Animal
{
    public Leao(string Nome, int Idade, string Especie) : base(Nome, Idade, Especie)
    {

    }

    public override void EmitirSom()
    {
        Console.WriteLine("Rugindo: ROAAAR!");
    }

    public override void Comer()
    {
        Console.WriteLine("Comendo carne...");
    }

}