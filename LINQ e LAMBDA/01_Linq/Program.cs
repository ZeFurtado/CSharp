namespace _01_Linq;

class Program
{
    static void Main(string[] args)
    { 

        //LINQ e LAMBDA


        int[] lista = {5,3,98,45,12,68,74,87,18,24,20};

        //var listaFiltrada = lista.Where(a => a > 10).OrderBy(a=>a);

        var listaFiltrada = from a in lista where a > 10 orderby a select a;

        foreach(var l in listaFiltrada)
        {
            Console.WriteLine(l);
        }

        Console.ReadKey();
    }
}
