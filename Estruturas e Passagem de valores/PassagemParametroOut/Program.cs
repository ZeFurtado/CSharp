// See https://aka.ms/new-console-template for more information
public class Program
{
        static void Main(String[] args)
        {
            double valor = 25;

            Console.WriteLine($"Main > var valor: {valor}");

            AlterarValor(out valor);
            int idade;
            RetornarNomeIdadePessoa(new DateTime(10,10,2000), out idade);

            Console.WriteLine($"Main > var valor {valor}");

            Console.ReadKey();
        }

        static void AlterarValor(out double valor)
        {
            valor = 10;
        }

        static string RetornarNomeIdadePessoa(DateTime dataNascimento, out int idade)
        {
            idade = 15;   
            return "João Péricles";
        }
}