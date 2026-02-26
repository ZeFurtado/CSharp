using _02_Validacao.Idiomas;
using System.ComponentModel.DataAnnotations;

namespace _02_Validacao;

public class Program
{
    static void Main(string[] args)
    {
        Usuario usuario = new Usuario();


        ValidationContext context = new ValidationContext(usuario);
        List<ValidationResult> validationResults = new List<ValidationResult>();

        if(!Validator.TryValidateObject(usuario, context, validationResults))
        {
            foreach(var erro in validationResults)
            {
                Console.WriteLine(erro.ErrorMessage);
            }
        }
        
    }
}
