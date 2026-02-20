using System.ComponentModel.DataAnnotations;

namespace _02_Validacao;
public class Usuario
{
    [Required(ErrorMessage ="O nome é obrigatório")]
    public string Nome{get; set;}
    //[Required(ErrorMessageResourceType = )]
    [EmailAddress]
    public string Email{get;set;}
    [Required, StringLength(10, MinimumLength = 6)]
    public string Senha{get;set;}
}