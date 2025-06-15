namespace TratandoException;

class Program
{
    static void Main()
    {-
        try
        {
            Pessoa pessoa = new Pessoa();
            pessoa.SetCEP("ABC10");
        }
        catch (FormatException forExcep)
        {
            Console.WriteLine("ERRO FORMAT: " + forExcep.Message);
        }
        catch (Exception excep)
        {
            Console.WriteLine("Erro " + excep.Message);
        }
        finally
        { 

        }
        Console.ReadKey();
    }
}
