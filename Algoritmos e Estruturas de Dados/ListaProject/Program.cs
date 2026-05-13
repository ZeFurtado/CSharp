namespace ListaProject;

class Program
{
    static void Main(string[] args)
    {
        Lista<string> listaString = new Lista<string>("Armindo");
        listaString.AddItem("Bolsonaro");
        listaString.AddItem("Lula");
        listaString.AddItem("Carmen Lucia");
        listaString.AddItem("Alexandre de Moraes");
        listaString.AddItem("Amarildo");
        
        var number = new BaseGenerics<int>(75);

        var name = new BaseGenerics<string>("Osvaldo");

        Console.WriteLine("Número de tipo genérico {0}", number.GetItem());
        Console.WriteLine("Nome de tipo genérico {0}", name.GetItem());
        
        
        foreach(string s in listaString.GetValues())
        {
            Console.WriteLine("Nome: " + s);
        }

        listaString.RemoveItem(2);
        Console.WriteLine("Remove item 2");
        foreach(string s in listaString.GetValues())
        {
            Console.WriteLine("Nome: " + s);
        }

        listaString.RemovePrimeiro();
        Console.WriteLine("Remove primeiro item");
        foreach(string s in listaString.GetValues())
        {
            Console.WriteLine("Nome: " + s);
        }

        listaString.RemoveUltimo();
        Console.WriteLine("Remove último item");
        foreach(string s in listaString.GetValues())
        {
            Console.WriteLine("Nome: " + s);
        }

    }
}
