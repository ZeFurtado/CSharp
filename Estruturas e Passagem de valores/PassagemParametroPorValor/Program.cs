namespace PassagemParametroPorValor
{
    public class Program
    {
        static void Main(String[] args)
        {
            double valor = 25;

            Console.WriteLine($"Main > var valor: {valor}");

            AlterarValor(valor);

            Console.WriteLine($"Main > var valor {valor}");

            Console.ReadKey();
        }

        static void AlterarValor(double valor)
        {
            Console.WriteLine($"AlterarValor > {valor}");

            valor += 10;

            Console.WriteLine($"AlterarValor > {valor}");
        }
    }
}
