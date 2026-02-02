using Microsoft.Data.SqlClient;

namespace ConsoleSQL;

public class Program
{
    static void Main()
    {
        int opcao = 0;
        while(opcao != 5)
        {
            Console.Clear();
            switch(opcao)
            {
                case 0:
                    Menu.Login();
                    string senhaDB = Console.ReadLine();
                    if(!SQLOperacoes.CriarConexao(senhaDB))
                    {
                        Console.WriteLine("A conexão com o banco de dados falhou");
                        Thread.Sleep(1500);
                        Console.WriteLine("Pressione qualquer tecla para tentar novamente.");
                        Console.ReadLine();
                        opcao = 0;
                    }else
                    {
                        Menu.TelaInicial();
                        opcao = int.Parse(Console.ReadLine());
                    }      
                break;

                default:
                    Console.WriteLine("Digite uma das opções acima");
                break;
            }
        }
        
    }
}
