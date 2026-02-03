using Microsoft.Data.SqlClient;

namespace ConsoleSQL;

public class Program
{
    static void Main()
    {
        int opcao = 0;
        SqlConnection sqlConnection;
        while(opcao != 5)
        {
            Console.Clear();
            Menu.Login();
            string senhaDB = Console.ReadLine();
            if(!SQLOperacoes.CriarConexao(senhaDB, out sqlConnection))
            {
                Console.WriteLine("A conexão com o banco de dados falhou");
                Thread.Sleep(1500);
                Console.WriteLine("Pressione qualquer tecla para tentar novamente.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Conexão bem sucedida");
                Thread.Sleep(1500);
                Console.Clear();
                Menu.TelaInicial();
                opcao = int.Parse(Console.ReadLine());
            }
        }
         
        
    }
}
