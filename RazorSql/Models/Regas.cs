using System.ComponentModel.DataAnnotations.Schema;

namespace RazorSql;


[Table("regas")]
public class Regas
{
    public int Id { get; set; }

    public int Ciclo_Id { get; set; }

    public DateOnly Data_Rega { get; set; }

    public decimal PH { get; set; }
    public decimal Agua_Utilizada_ml { get; set; }
}