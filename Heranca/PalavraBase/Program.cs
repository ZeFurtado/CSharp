namespace PalavraBase;

public class Program
{
    static void Main(string[] args)
    {
        Veiculo veiculo = new Veiculo();
        veiculo.Andar();

        Carro carro = new Carro();
        carro.Andar();
        Console.ReadKey();
    }
}
