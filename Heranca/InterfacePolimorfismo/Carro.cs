namespace InterfacePolimorfismo;


public class Carro : Veiculo, ITransporte
{
    public void Andar()
    {
        Console.WriteLine("Andando..");
    }
}