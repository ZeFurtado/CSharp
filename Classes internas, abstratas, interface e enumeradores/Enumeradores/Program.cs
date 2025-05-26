namespace Enumeradores;

class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Estado Civil: " + EstadoCivil.Solteiro);
        Console.WriteLine("Estado Civil *Númerico: " +(int)EstadoCivil.Solteiro);
    }
}