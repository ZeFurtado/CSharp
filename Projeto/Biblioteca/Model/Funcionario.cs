namespace Biblioteca.Model;

public sealed class Funcionario : Pessoa
{
    public string Cargo { get; set; }
    public double Salario { get; set; }

    public DateTime DataContratacao { get; set; }
}
