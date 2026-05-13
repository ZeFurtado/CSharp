namespace ListaProject;

class Program
{
    static void Main(string[] args)
    {
        Lista<string> listaString = new Lista<string>("Armindo");

        var number = new BaseGenerics<int>(75);

        var name = new BaseGenerics<string>("Osvaldo");

        Console.WriteLine("Número de tipo genérico {0}", number.GetItem());
        Console.WriteLine("Nome de tipo genérico {0}", name.GetItem());
        Console.WriteLine("Teste Lista String {0}", listaString.GetItem(0));

    }
}
