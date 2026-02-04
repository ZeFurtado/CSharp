using Microsoft.Data.SqlClient;

namespace ConsoleSQL;

public class Program
{
    static void Main()
    {
        int opcao = 0;
        string sqlConnectionString;
        while(opcao != 5)
        {
            Console.Clear();
            Menu.Login();
            string senhaDB = Console.ReadLine();
            if(!SQLOperacoes.CriarConexao(senhaDB, out sqlConnectionString))
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

                switch(opcao)
                {
                    case 1:
                        try
                        {
                            Menu.Insert(sqlConnectionString);
                            Console.WriteLine(sqlConnectionString);  
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Ocorreu um erro ao tentar inserir no banco: {0}", ex.Message);
                            Thread.Sleep(1000);
                            Console.WriteLine("Pressione qualquer tecla para continuar.");
                            Console.ReadLine();
                        }
                        break;

                    default:
                        opcao =  6;
                        break;

                }
            }
        }
         
        
    }
}
