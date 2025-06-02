namespace ProjetoZoo;

public class Program
{
    public static void Main(string[] args)
    {
        Leao simba = new Leao("Simba", 5, "Leão");
        Elefante dumbo = new Elefante("Dumbo", 10, "Elefante");
        Macaco george = new Macaco("George", 3, "Macaco");

        Animal[] animais = [simba, dumbo, george];

        foreach (Animal a in animais)
        {
            Console.WriteLine(" ");
            Console.WriteLine(a.ExibirInfo());
            a.EmitirSom();
            a.Comer();
            Console.WriteLine(" ");
        }

        
    }
}