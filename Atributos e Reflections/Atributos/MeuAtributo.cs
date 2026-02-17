namespace Atributos;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method)]

public class MeuAtributo : Attribute 
{
    public string Nome{get;set;}
    public string Descricao{get;set;}

    public MeuAtributo(string nome)
    {
        Nome = nome;
    }
}