namespace CustomizarException;

class Program
{
    static void Main()
    {
        try
        {
            throw new MinhaException("");
        }
        catch (MinhaException exception)
        {
            Console.WriteLine("Mensagem: " + exception.Message);
            Console.WriteLine("Fonte: " + exception.Source);
            Console.WriteLine("StackTrace? " + exception.StackTrace);
        }
    }
}
