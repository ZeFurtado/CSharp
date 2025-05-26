namespace _Interface;

public class Carro : Veiculo, ITransporte
{
    public void Mover(byte Velocidade)
    {
        Console.WriteLine("Movendo...");
    }
}