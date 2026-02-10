using System.IO.Compression;
using Microsoft.Data.SqlClient;

namespace ConsoleSQL;

public class Program
{
    static void Main()
    {
        for(int t = 1; t < 4; t++)
        {
            string sqlConnectionString;
            Console.Clear();
            Menu.Login();
            string senhaDB = Console.ReadLine();
            if(!SQLOperacoes.CriarConexao(senhaDB, out sqlConnectionString))
            {
                Console.WriteLine("A conexão com o banco de dados falhou");
                Thread.Sleep(1500);

                if(t == 3)
                {
                    Console.WriteLine("Número de tentativas excedido!");
                    break;   
                } 
                Console.WriteLine("Pressione qualquer tecla para tentar novamente. Tentativa {0} de 3", t);
                Console.ReadLine();
            }else
            {
               Programa(ref sqlConnectionString);
               t = 4; 
            }
        }    
    }

    static void Programa(ref string sqlConnectionString)
    {
        int opcao = 0;
        Console.WriteLine("Conexão bem sucedida");
        Thread.Sleep(1500);
        Console.Clear();
        
        while(opcao < 5)
        {
            Menu.TelaInicial();
            opcao = int.Parse(Console.ReadLine());
            switch(opcao)
            {
                case 1: 
                    Menu.InsertScreen(sqlConnectionString);
                    Console.WriteLine(sqlConnectionString);  
                 break;

                case 2:
                    Menu.EditScreen(sqlConnectionString);
                    break;

                case 5:
                    opcao = 5;
                 break;

                default:
                    Console.WriteLine("Opção {0} não existe", opcao);
                    Console.ReadLine();
                    opcao = 0;
                 break;
            }
            
        }
    }
}
