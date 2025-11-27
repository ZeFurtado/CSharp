namespace FormatarString;

public class Program
{
    static void Main(string[] args)
    {
        string texto = String.Format("Olá {0}! Feliz {1}!", "Elias", "2017");
        Console.WriteLine(texto);

        string nome = "Elaias", ano = "2017";
        Console.WriteLine("Olá {0}! Feliz {1}!", nome, ano);

        Console.WriteLine("Olá ({nome})! Feliz ({ano})!");

        Console.WriteLine($"Olá {nome}! Feliz {ano}!");
        Console.ReadKey();
    }
}
