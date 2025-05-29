using System.ComponentModel.DataAnnotations.Schema;

namespace RazorSql;

[Table("plantas")]
public class Plantas
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}
