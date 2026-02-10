using System.Collections;
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

    public static void InsertScreen(string sqlConnectionString)
    {
        Console.Clear();
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
        try
        {
            int linhasAfetadas = SQLOperacoes.Insert(sqlConnectionString, nome, cargo, email);
            Console.WriteLine("O comando alterou {0} linha/s", linhasAfetadas);
            Thread.Sleep(1500); 
        }catch(Exception ex)
        {
            Console.WriteLine("Não foi possível inserir os dados no banco.");
            Console.WriteLine("Erro: {0}", ex.Message);
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadLine();
        }
          
    }

    public static void EditScreen(string sqlConnectionString)
    {
        string data;
        int id;

        Console.Clear();
        Console.WriteLine(Titulo("Editar"));
        Console.WriteLine("Escolha o campo que você deseja editar.");
        Console.WriteLine("1 - Nome");
        Console.WriteLine("2 - Cargo");
        Console.WriteLine("3 - Email");
        int opcao = int.Parse(Console.ReadLine());

        while(opcao != 4)
        {
            switch(opcao)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Digite o nome a ser inserido.");
                        data = Console.ReadLine();

                        Console.WriteLine("Digite o ID do usuário que precisa ser alterado");
                        id = int.Parse(Console.ReadLine());

                        Console.Write("\aExecutando alterações no banco de dados.");
                        Thread.Sleep(950);
                        Console.Write(".");
                        Thread.Sleep(950);
                        Console.WriteLine(".");
                        Thread.Sleep(850);

                        int linhasAfetadas = SQLOperacoes.Edit(sqlConnectionString, "Usuarios", "nome", data, id);
                        Console.WriteLine("O comando alterou {0} linha/s", linhasAfetadas);
                        Console.WriteLine("Deseja continuar editando? y/n");
                        string option = Console.ReadLine();
                        if(!option.Equals("y")) opcao = 4;
                    }catch(Exception ex)
                    {
                        Console.WriteLine("Não foi possível realizar a operação.");
                        Console.WriteLine("Mensagem: {0}", ex.Message);
                    }
                    
                 break;

                case 2:
                    try
                    {
                       Console.WriteLine("Digite o nome do cargo a ser inserido: ");
                       data = Console.ReadLine();

                       Console.WriteLine("Digite o ID do usuário que precisa ser alterado");
                       id = int.Parse(Console.ReadLine()); 
                    }catch(Exception ex)
                    {
                        Console.WriteLine("Não foi possível realizar a operação. ");
                        Console.WriteLine("Mensagem: {0}", ex.Message);
                    }
                 break;

                case 3:
                    try
                    {
                       Console.WriteLine("Digite o nome do Email a ser inserido: ");
                       data = Console.ReadLine();

                       Console.WriteLine("Digite o ID do usuário que precisa ser alterado");
                       id = int.Parse(Console.ReadLine()); 
                    }catch(Exception ex)
                    {
                        Console.WriteLine("Não foi possível realizar a operação. ");
                        Console.WriteLine("Mensagem: {0}", ex.Message);
                    }
                 break;

                case 4:
                    opcao = 4;
                 break;

                default:
                    Console.WriteLine("Opção {0} não existe ", opcao);

                 break;
            }
                
        }

    }
    
}