using Microsoft.Data.SqlClient;

namespace ConsoleSQL;

public class Program
{
    static void Main()
    {
        Console.WriteLine("CONSOLE SQL SERVER DO LIL FURTS");
        Console.WriteLine("Digite a senha do banco de dados: ");
        string senha = Console.ReadLine();
        Conectar(senha);
        
    }

    static void Conectar(string senha)
    {
        SqlConnection sqlConnection = new SqlConnection($"SERVER=localhost; DATABASE=Diamba;User Id=sa; Password={senha}; TrustServerCertificate=True;Encrypt=True;");
        try
        {
            sqlConnection.Open();
            Console.WriteLine("A conexão foi bem sucedida");
            
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            sqlConnection.Close();
        }
    }
}
