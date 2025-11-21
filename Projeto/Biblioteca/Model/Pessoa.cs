namespace Biblioteca.Model;

public abstract class Pessoa
{
    public string Nome { get; set; }
    private DateTime DataNascimento;
    public string Telefone { get; set; }
    public string CPF { get; set; }
    public string RG { get; set; }

    public int CEP { get; set; }
    public string Estado { get; set; }
    public string Cidade { get; set; }
    public string Endereco { get; set; }


    public void setDataNascimento(string dataNascimento)
    {
        try
        {    
            DataNascimento = DateTime.Parse(dataNascimento);
        }
        catch (FormatException)
        {
            Console.WriteLine("O formato da data é inválido.");
            Console.WriteLine("Data de Nascimento: ");
            setDataNascimento(Console.ReadLine());
        }
    }

    public DateTime getDataNascimento()
    {
        return DataNascimento;
    }
}