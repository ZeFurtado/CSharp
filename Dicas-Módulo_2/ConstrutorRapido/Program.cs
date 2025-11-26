namespace ConstrutorRapido;

public class Program
{
    public static void Main(string[] args)
    {
        //Construtor Padrão
        Carro carro = new Carro();

        //Construtor Rápido
        Carro carro2 = new Carro() {Marca = "FIAT", Rodas = 4, DataFabricacao = new DateTime(2000,10,10), Modelo="Palio"};
    }
}
