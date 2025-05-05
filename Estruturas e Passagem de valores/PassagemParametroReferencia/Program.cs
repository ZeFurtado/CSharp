// See https://aka.ms/new-console-template for more information
public class Program
{
        static void Main(String[] args)
        {
            double valor = 25;

            Console.WriteLine($"Main > var valor: {valor}");

            AlterarValor(ref valor);

            Console.WriteLine($"Main > var valor {valor}");

            Console.ReadKey();
        }

        static void AlterarValor(ref double valor)
        {
            Console.WriteLine($"AlterarValor > {valor}");

            valor += 10;

            Console.WriteLine($"AlterarValor > {valor}");
        }
}
