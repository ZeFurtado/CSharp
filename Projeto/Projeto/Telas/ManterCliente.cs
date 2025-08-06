using Biblioteca.Model;

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

        
    }

    public void ListarClientes()
    {
        Cliente cliente = new Cliente();
        Console.WriteLine(cliente.Nome);
    }

}
