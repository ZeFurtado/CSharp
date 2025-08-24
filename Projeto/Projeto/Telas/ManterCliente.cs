using Biblioteca.Arquivo;
using Biblioteca.Model;
using Projeto.Conversores;

namespace Projeto.Telas;

public class ManterCliente
{
    public void CadastrarCliente()
    {
        Cliente cliente = new Cliente();

        Console.Clear();

        Console.WriteLine("CADASTRAR CLIENTE");

        Console.Write("Nome: ");
        cliente.Nome = Console.ReadLine();


        Console.WriteLine("Data de Nascimento: ");
        cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Telefone: ");
        cliente.Telefone = Console.ReadLine();

        Console.WriteLine("CPF: ");
        cliente.CPF = Console.ReadLine();

        Console.WriteLine("RG: ");
        cliente.RG = Console.ReadLine();

        Console.WriteLine("CEP: ");
        cliente.CEP = int.Parse(Console.ReadLine());

        Console.WriteLine("Estado: ");
        cliente.Estado = Console.ReadLine();

        Console.WriteLine("Cidade: ");
        cliente.Cidade = Console.ReadLine();

        Console.WriteLine("Endereço: ");
        cliente.Endereco = Console.ReadLine();

        GerenciadorArquivo.GravarArquivo("Arquivo", ClienteTexto.ConverterParaTexto(cliente));
    }

    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("Digite o nome do arquivo: ");
        string nomeArquivo = Console.ReadLine();
        try
        {
            string caminho = $"/home/lukhas/repo/CSharp/Projeto/{nomeArquivo}.txt";
            if (!File.Exists(caminho)) throw new IOException();

            string[] clientes = File.ReadAllLines(caminho);
        }
        catch (IOException)
        {
            Console.WriteLine("O arquivo não existe!!!");
        }
    }

}
