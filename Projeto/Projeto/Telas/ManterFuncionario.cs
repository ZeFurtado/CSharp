using Projeto.Conversores;
using Biblioteca.Arquivo;
using Biblioteca.Model;

public class ManterFuncionario
{
    public void CadastrarFuncionario()
    {
        Funcionario funcionario = new Funcionario();

        Console.Clear();
        Console.WriteLine("CADASTRAR FUNCIONÁRIO");

        Console.Write("Nome: ");
        funcionario.Nome = Console.ReadLine();
        Console.WriteLine("Data de Nascimento: ");
        funcionario.setDataNascimento(Console.ReadLine());
        Console.WriteLine("Telefone: ");
        funcionario.Telefone = Console.ReadLine();
        Console.WriteLine("CPF: ");
        funcionario.CPF = Console.ReadLine();
        Console.WriteLine("RG: ");
        funcionario.RG = Console.ReadLine();
        Console.WriteLine("CEP: ");
        funcionario.CEP = int.Parse(Console.ReadLine());
        Console.WriteLine("Estado: ");
        funcionario.Estado = Console.ReadLine();
        Console.WriteLine("Cidade: ");
        funcionario.Cidade = Console.ReadLine();
        Console.WriteLine("Endereço: ");
        funcionario.Endereco = Console.ReadLine();
        Console.WriteLine("Cargo: ");
        funcionario.Cargo = Console.ReadLine();
        Console.WriteLine("Salario: ");
        funcionario.Salario = double.Parse(Console.ReadLine());
        Console.WriteLine("Data da Contratação: ");
        funcionario.setDataContratacao(Console.ReadLine());


        GerenciadorArquivo.GravarArquivo("Funcionário", FuncionarioTexto.ConverterParaTexto(funcionario));


        
    }

    public void ListarFuncionarios()
    {
        Console.Clear();
        Console.WriteLine("Digite o nome do arquivo: ");
        string nomeArquivo = Console.ReadLine();

        try
        {
            string caminho = $"/home/lukhas/repo/CSharp/Projeto/{nomeArquivo}.txt";
            if (!File.Exists(caminho)) throw new IOException();

            string[] funcionarios = File.ReadAllLines(caminho);

            foreach(string f in funcionarios)
            {
                Funcionario funcionario = FuncionarioTexto.ConverterParaFuncionario(f);

                Console.WriteLine($"NOME: {funcionario.Nome}");
            }
        }catch(IOException)
        {
            Console.WriteLine("O arquivo não existe!!!");
        }
    }
}
