namespace ProjetoZoo;

public class Elefante : Animal
{
    public Elefante(string Nome, int Idade, string Especie) : base(Nome, Idade, Especie)
    {

    }

    public override void EmitirSom()
    {
        Console.WriteLine("Barulho: Prrrrrrrr!");
    }

    public override void Comer()
    {
        Console.WriteLine("Comendo folhas e frutas...");
    }

}