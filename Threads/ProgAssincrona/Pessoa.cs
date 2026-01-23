namespace ProgAssincrona;

public class Pessoa
{
    public string Nome { get; set; }
    public string Sobrenome{get;set;}

    public int Idade { get; set; }

    public Pessoa(string nome, string sobrenome, int idade)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        Idade = idade;
    }
}