namespace PassagemParametroParams;

public class Program
{
    static void Main(string[] args)
    {
        VariasEntradas01("Elias", "José", "Maria");

        string[] nomes = {"Elias", "José", "Maria", "Filipe"};

        VariasEntradas02(nomes);

        VariasEntradas03(5, "Elias", "José", "Maria", "Filipe", "Jesus");
    }

    static void VariasEntradas01(string nome1, string nome2, string nome3)
    {
        Console.WriteLine("Várias entradas 01*");
        Console.Write(nome1 + " ");
        Console.Write(nome2 + " ");
        Console.Write(nome3 + " ");
        Console.Write("\n");
    }

    static void VariasEntradas02(string[] nomes)
    {
        Console.WriteLine("Várias entradas 02*");
        foreach (string i in nomes)
        {
            Console.Write(i + " ");
        }
        Console.Write("\n");
    }

    
    //Params serve para agrupar dados de um mesmo objeto em um array de mesmo objeto.

    static void VariasEntradas03(int numero, /*Obs. Params deve ser o último elemento passado por paramêtro*/ params string[] names)
    {
        Console.WriteLine("\aValores entradas 03*");
        foreach (string i in names)
        {
            Console.Write(i + " ");
        }
        Console.Write("\n");
    }
}



