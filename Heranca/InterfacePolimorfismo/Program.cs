namespace InterfacePolimorfismo;


public class Program
{
    static void Main(string[] args)
    {
        Carro carro = new Carro();
        carro.Marca = "Wolkswagen";

        SobreVeiculo(carro);
        SobreTransport(carro);

        Console.ReadKey();
    }

    //Acessa a propriedade utilizando como parâmetro um objeto herdado de Veiculo
    static void SobreVeiculo(Veiculo veiculo)
    {
        Console.WriteLine(veiculo.Marca);
    }

    //Acessa o método utilizando como parâmetro um objeto que contém contrato com a interface ITransporte
    static void SobreTransport(ITransporte transporte)
    {
        transporte.Andar();
    }

}