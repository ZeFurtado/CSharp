using Projeto.Telas;

namespace Projeto;

public class Program
{
    static void Main(string[] args)
    {
        int opcoes = 0;
        ManterCliente telaCliente = new ManterCliente();
        ManterFuncionario telaFuncionario = new ManterFuncionario();
        

        while (opcoes != 5)
        {
            Console.WriteLine("\nO que deseja fazer? \n(1) = Cadastrar Cliente \n(2) = Listar Clientes \n" +
                          "(3) = Cadastrar funcionário \n(4) = Listar funcionário  \n(5) = Sair do programa");
            opcoes = int.Parse(Console.ReadLine());


            switch (opcoes)
            {
                case 1:
                    telaCliente.CadastrarCliente();
                    break;

                case 2:
                    telaCliente.ListarClientes();
                    break;

                case 3:
                    telaFuncionario.CadastrarFuncionario();
                    break;

                case 4:
                    telaFuncionario.ListarFuncionarios();
                    break;

                case 5:
                    Console.WriteLine("Adeus..");
                    break;

                default:
                    Console.WriteLine("Opção não é válida!!!");
                    opcoes = 0;
                    break;
            }
        }
        
    }
}
