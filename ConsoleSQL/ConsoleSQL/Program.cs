using Microsoft.Data.SqlClient;

namespace ConsoleSQL;

public class Program
{
    private static string subTitulo = "Tela Inicial";
    private static string titulo = $@"
██████╗ ██████╗     ███╗   ███╗ █████╗ ███╗   ██╗ █████╗  ██████╗ ███████╗██████╗
██╔══██╗██╔══██╗    ████╗ ████║██╔══██╗████╗  ██║██╔══██╗██╔════╝ ██╔════╝██╔══██╗
██║  ██║██████╔╝    ██╔████╔██║███████║██╔██╗ ██║███████║██║  ███╗█████╗  ██████╔╝
██║  ██║██╔══██╗    ██║╚██╔╝██║██╔══██║██║╚██╗██║██╔══██║██║   ██║██╔══╝  ██╔══██╗
██████╔╝██████╔╝    ██║ ╚═╝ ██║██║  ██║██║ ╚████║██║  ██║╚██████╔╝███████╗██║  ██║
╚═════╝ ╚═════╝     ╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝ ╚═════╝ ╚══════╝╚═╝  ╚═╝
----------------------------------------------------------------------------------
            APLICATIVO DE CONSOLE PARA MANIPULAÇÃO DE BANCO DE DADOS
----------------------------------------------------------------------------------
________________

  {subTitulo}
________________

";

    static void Main()
    {
        Console.Clear();
        Console.WriteLine(titulo);
        Console.WriteLine("Digite a senha do banco de dados: ");
        string senha = Console.ReadLine(); //Implementar validação da senha
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
        Thread.Sleep(1500);
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
                subTitulo = "Inserir";
                Console.Clear();
                Console.WriteLine(titulo);
                Console.WriteLine(subTitulo);
                
                Console.WriteLine("Digite o nome do usuário: ");
                string nome = Console.ReadLine();
                
                Console.WriteLine("Digite o nome do cargo do usuário: ");
                string cargo = Console.ReadLine();

                Console.WriteLine("Digite seu melhor e-mail: ");
                string email = Console.ReadLine();
                
                int linhasAfetadas = SQLOperacoes.Insert(sqlConnection, nome, cargo, email);
                Console.WriteLine("O comando alterou {0} linha/s", linhasAfetadas);

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
