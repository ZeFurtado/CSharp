using Microsoft.Data.SqlClient;

namespace ConsoleSQL;

public class Program
{
    private static string titulo = @"
██████╗ ██████╗     ███╗   ███╗ █████╗ ███╗   ██╗ █████╗  ██████╗ ███████╗██████╗
██╔══██╗██╔══██╗    ████╗ ████║██╔══██╗████╗  ██║██╔══██╗██╔════╝ ██╔════╝██╔══██╗
██║  ██║██████╔╝    ██╔████╔██║███████║██╔██╗ ██║███████║██║  ███╗█████╗  ██████╔╝
██║  ██║██╔══██╗    ██║╚██╔╝██║██╔══██║██║╚██╗██║██╔══██║██║   ██║██╔══╝  ██╔══██╗
██████╔╝██████╔╝    ██║ ╚═╝ ██║██║  ██║██║ ╚████║██║  ██║╚██████╔╝███████╗██║  ██║
╚═════╝ ╚═════╝     ╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝ ╚═════╝ ╚══════╝╚═╝  ╚═╝
----------------------------------------------------------------------------------
            APLICATIVO DE CONSOLE PARA MANIPULAÇÃO DE BANCO DE DADOS
----------------------------------------------------------------------------------
";

    static void Main()
    {
        Console.WriteLine(titulo);
        Console.WriteLine("Digite a senha do banco de dados: ");
        string senha = Console.ReadLine();
        BancoDeDados(senha);
        
    }

    static void BancoDeDados(string senha)
    {
        string connectionString = $"SERVER=localhost; DATABASE=testDb;User Id=sa; Password={senha}; TrustServerCertificate=True;Encrypt=True;";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        try
        {
            sqlConnection.Open();
            Console.WriteLine("A conexão foi bem sucedida");
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        sqlConnection.Close();
        Console.Clear();
        Console.WriteLine(titulo);
        Console.WriteLine("Você está utilizando a base de dados: {0}", sqlConnection.Database);
        Console.WriteLine("O que você deseja fazer com a tabela?");
        Console.WriteLine("1 - Inserir");
        Console.WriteLine("2 - Editar");
        Console.WriteLine("3 - Consultar");
        Console.WriteLine("4 - Deletar");
        Console.WriteLine("5 - Sair");
        int opcao = int.Parse(Console.ReadLine());

        while (opcao != 5)
        {
            switch (opcao)
            {
                case 1:
                //Mudar criação do SubTítulo
                string subTitulo = @"
                ________________

                    INSERIR
                ________________
                ";
                    try
                    {
                        Console.Clear();
                        Console.WriteLine(titulo);
                        Console.WriteLine(subTitulo);
                        Console.WriteLine("Digite o nome do usuário: ");
                        
                    }catch(Exception ex)
                    {
                        Console.WriteLine("Exceção: {0}", ex.Message);  
                    }
                    opcao = 5;
                break;

                case 2:
                break;

                case 3:
                break;

                case 4:
                break;

                case 5:

                break;

                default:
                    Console.WriteLine("Digite um dos números acima!");
                break;

            }
        }


        sqlConnection.Close();
    }
}
