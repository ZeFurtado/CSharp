namespace ConsoleSQL;

public interface ISQLOperacoes
{
    string Insert(string nomeDaTabela, int Id);
    string Update(string nomeDaTabela, int Id);
    string Read(string nomeDaTabela, int Id);
    string Delete(string nomeDaTabela, int Id);
}