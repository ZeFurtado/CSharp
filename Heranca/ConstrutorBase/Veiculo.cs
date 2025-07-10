namespace ConstrutorBase;

public class Veiculo
{


    public Veiculo()
    {
        Console.WriteLine("Construtor Veículo");
    }

    public Veiculo(int i)
    {
        Console.WriteLine("Construindo veículo " + i);
    }
    public virtual void Andar()
    {
        Console.WriteLine("Veiculo andando...");
    }
}