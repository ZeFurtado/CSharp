using System.ComponentModel.DataAnnotations;

namespace _02_Validacao;
public class Usuario
{
    [Required]
    public string Nome{get; set;}
    [Required]
    [EmailAddress]
    public string Email{get;set;}
    [Required, StringLength(10, MinimumLength = 6)]
    public string Senha{get;set;}
}