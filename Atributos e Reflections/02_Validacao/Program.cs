using _02_Validacao.Idiomas;

namespace _02_Validacao;

public class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine(Resx.CheckFile());
        Console.ReadLine();
        
        try
        {
            Resx.AddToFile(new Resx{Name="MSG_ERRO", Value="Erro", Comment="Mensagem de Erro"});    
        }catch(Exception ex)
        {
            Console.WriteLine("Mensagem ERRO {0}", ex.Message );
        }
        
    }
}
