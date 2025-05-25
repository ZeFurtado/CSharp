// See https://aka.ms/new-console-template for more information
namespace ClasseAbstrata;

public class Program
{
    static void Main()
    {
        Veiculo veiculo = new Veiculo(); //Não é possível instanciar classes abstratas
        Carro carro = new Carro();
        Caminhao caminhao = new Caminhao();
    }
}
