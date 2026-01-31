using Microsoft.Data.SqlClient;
namespace ConsoleSQL;

public class SQLOperacoes
{
    public static int Insert(SqlConnection connection, params string[] valores)
    {
        SqlCommand sqlCommand = new SqlCommand();
        return sqlCommand.ExecuteNonQuery();
    }
}