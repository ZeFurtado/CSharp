namespace ProjetoZoo;

public class Macaco : Animal
{
    public Macaco(string Nome, int Idade, string Especie) : base(Nome, Idade, Especie)
    {

    }

    public override void EmitirSom()
    {
        Console.WriteLine("Gritando: OOH OOH AAH AAH!");
    }

    public override void Comer()
    {
        Console.WriteLine("Comendo bananas...");
    }

    
}