using System.Data.SqlTypes;
using System.Dynamic;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace ConsoleSQL;


public static class Menu
{
    
    public static string Titulo(string subTitulo)
    {
        string titulo = $@"
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

        return titulo;

    }

    public static void Login()
    {
        Console.WriteLine(Titulo("Login"));
        Console.WriteLine("Digite a senha do banco de dados:");
    }

    public static void TelaInicial()
    {
        Console.WriteLine(Titulo("Tela Inicial"));
        Console.WriteLine("Você está utilizando a base de dados: {0}");
        Console.WriteLine("O que você deseja fazer com a tabela?");
        Console.WriteLine("1 - Inserir");
        Console.WriteLine("2 - Editar");
        Console.WriteLine("3 - Consultar");
        Console.WriteLine("4 - Deletar");
        Console.WriteLine("5 - Sair"); 
    }

    public static void Insert(string sqlConnectionString)
    {
        Console.WriteLine(Titulo("Insert"));
        
        Console.WriteLine("Digite o nome do usuário: ");
        string nome = Console.ReadLine();
                
        Console.WriteLine("Digite o nome do cargo do usuário: ");
        string cargo = Console.ReadLine();

        Console.WriteLine("Digite seu melhor e-mail: ");
        string email = Console.ReadLine();

        Console.Write("\aInserindo dados no banco.");
        Thread.Sleep(950);
        Console.Write(".");
        Thread.Sleep(950);
        Console.WriteLine(".");
        Thread.Sleep(850);
        int linhasAfetadas = SQLOperacoes.Insert(sqlConnectionString, nome, cargo, email);
        Console.WriteLine("O comando alterou {0} linha/s", linhasAfetadas);
        Thread.Sleep(1500);   
    }
    
}