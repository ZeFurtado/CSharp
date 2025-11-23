namespace Biblioteca.Model;

public sealed class Funcionario : Pessoa
{
    public string Cargo { get; set; }
    public double Salario { get; set; }

    private DateTime DataContratacao;

    public DateTime getDataContracao()
    {
        return DataContratacao;
    }

    public void setDataContratacao(string dataContratacao)
    {
        try
        {
            DataContratacao = DateTime.Parse(dataContratacao);
        }catch(FormatException)
        {
            Console.WriteLine("O formato da data é inválido.");
            Console.WriteLine("Data da Contratação: ");
            setDataContratacao(Console.ReadLine());
        }
    }

}
