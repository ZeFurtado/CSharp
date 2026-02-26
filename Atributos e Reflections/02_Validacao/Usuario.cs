using System.ComponentModel.DataAnnotations;
using _02_Validacao.Idiomas;

namespace _02_Validacao;
public class Usuario
{
    [Required(ErrorMessage ="O nome é obrigatório")]
    public string Nome{get; set;}
    //[Required(ErrorMessageResourceType = typeof(Resx), ErrorMessageResourceName = "MSG_ERRO")]
    [EmailAddress]
    public string Email{get;set;}
    [Required, StringLength(10, MinimumLength = 6)]
    public string Senha{get;set;}
}