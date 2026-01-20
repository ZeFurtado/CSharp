namespace TesteDelegateEvents;

public class Usuario
{
    public string Nome{get;set;}
    public int ID{get;set;}
    public string Cargo{get;set;}


    public Usuario(string nome, int id, string cargo)
    {
        Nome = nome;
        ID = id;
        Cargo = cargo;
    }
}