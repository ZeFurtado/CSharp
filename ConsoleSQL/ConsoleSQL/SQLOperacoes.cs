using System.Reflection.Metadata;
using System.Text;
using Microsoft.Data.SqlClient;
namespace ConsoleSQL;

public class SQLOperacoes
{
    public static bool CriarConexao(string senhaDB, out string stringDeConexao) 
    {
        stringDeConexao = $"SERVER=localhost; DATABASE=testDb;User Id=sa; Password={senhaDB}; TrustServerCertificate=True;Encrypt=True;";
        
        SqlConnection sqlConnection1 = new SqlConnection(stringDeConexao);

        try
        { 
            using(sqlConnection1)
            {
                sqlConnection1.Open(); 
            }
            return true;
        }catch(SqlException ex)
        {
            Console.WriteLine("SQlException - Mensagem: {0}",ex.Message);
            return false;
        }catch(Exception ex)
        {
            Console.WriteLine("Outra exceção - Mensagem: {0} ", ex.Message);
            return false;
        }
    }

    public static int Insert(string sqlConnectionString, params string[] valores) //Método retorna a quantidade de linhas alteradas pelo comando SQL
    {
        StringBuilder comando = new StringBuilder();
        comando.Append("INSERT INTO Usuarios VALUES (");
        
        for(int i = 0; i < valores.Length; i++)
        {
            //Adiciona aspas simples na variável para o comando SQL rodar
            valores[i] = $"'{valores[i]}'";

            //  Constroí a string do comando de acordo com a qntd de valores passados no método e adiciona uma vírgula
            //  no final para o próximo valor.
            comando.Append(" " + valores[i] + ", " );

            //  Quando o último valor é passado é necessário remover a última vírgula adicionada pelo código acima.
            //  Caso a vírgula permaneça ocorre um erro de síntaxe SQL.
            if(i == valores.Length -1) comando.Remove(comando.ToString().LastIndexOf(','), 1);
                        
        }
        
        comando.Append(" );");
        
        int linhasAfetadas = 0;
        using(SqlConnection connection = new SqlConnection(sqlConnectionString))
        {
            using(SqlCommand sqlCommand = new SqlCommand(comando.ToString(), connection))
            {
                connection.Open();
                linhasAfetadas = sqlCommand.ExecuteNonQuery();
            }
        }
        return linhasAfetadas;
    }

    public static int Edit(string sqlConnectionString, string data,int id)
    {
        return 1;
    }
}