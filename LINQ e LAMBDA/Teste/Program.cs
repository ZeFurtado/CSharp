using Microsoft.VisualBasic;

namespace Teste;

public class Program
{
   public static void Main()
    {
        Fertilizantes fertilizantes = new Fertilizantes
        {
            Fertilizante1 = 1,
            QuantidadeFertilizante1 = 2.5,
            Fertilizante2 = 5,
            QuantidadeFertilizante2 = 2.5,
            Fertilizante3 = 9,
            QuantidadeFertilizante3 = 2.5,
            Fertilizante4 = 10,
            QuantidadeFertilizante4 = 2.5
        };
        var fertList = new List<(int fertilizante, double quantidadeFertilizante)>(); 

        if(fertilizantes.Fertilizante1 != 0) fertList.Add((fertilizantes.Fertilizante1, fertilizantes.QuantidadeFertilizante1));
        if(fertilizantes.Fertilizante2 != 0) fertList.Add((fertilizantes.Fertilizante2, fertilizantes.QuantidadeFertilizante2));
        if(fertilizantes.Fertilizante3 != 0) fertList.Add((fertilizantes.Fertilizante3, fertilizantes.QuantidadeFertilizante3));
        if(fertilizantes.Fertilizante4 != 0) fertList.Add((fertilizantes.Fertilizante4, fertilizantes.QuantidadeFertilizante4));

        if(fertList.Count > 0)
        {
            var valores = fertList.Select((f, i) => $"(@rega{i}, @fert{i}, @qtd{i})");

            string sqlCommand = "Dados fertilizantes" + string.Join(", ", valores);

            Console.WriteLine(sqlCommand);
        }

    }
}

public class Fertilizantes
{
    public int Fertilizante1 { get; set; }
    public double QuantidadeFertilizante1 {get;set;}

    public int Fertilizante2 { get; set; }
    public double QuantidadeFertilizante2 {get;set;}
    public int Fertilizante3 { get; set; }
    public double QuantidadeFertilizante3 {get;set;}
    public int Fertilizante4 { get; set; }
    public double QuantidadeFertilizante4 {get;set;}

}
