namespace ProjetoZoo;

public abstract class Animal : IAnimal
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Especie { get; set; }

    public Animal(string Nome, int Idade, string Especie)
    {
        this.Nome = Nome;
        this.Idade = Idade;
        this.Especie = Especie;
    }

    public virtual void EmitirSom()
    {

    }

    public virtual void Comer()
    {

    }

    public virtual string ExibirInfo()
    {
        return $"{Especie} {Nome}\n" +
                "Espécie: " + Especie + "\n" +
                "Idade: " + Idade; 
    }

}