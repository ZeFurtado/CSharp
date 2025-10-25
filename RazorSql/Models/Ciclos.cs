using System.ComponentModel.DataAnnotations.Schema;

namespace RazorSql;
[Table("ciclos")]
public class Ciclos
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateOnly? Data_Inicio { get; set; }

    public DateOnly?Data_fim { get; set; }
    public DateOnly? Inicio_vega { get; set; }
    public DateOnly? Inicio_flora { get; set; }
    public Boolean Ativo { get; set; }
    public decimal Rendimento_colheita_g { get; set; }
}