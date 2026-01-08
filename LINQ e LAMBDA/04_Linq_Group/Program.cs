namespace _04_Linq_Group;

class Program
{
    static void Main(string[] args)
    {
        int[] listaNum = {1,1,1,1,4,4,2,3,5,6,6,10,9,8};

        //GROUP - DISTINCT
        //var listaFiltrada = listaNum.Distinct().Select(a=>a); Exibe todos os números uma única vez
        //var listaFiltrada = listaNum.OrderBy(a=>a); Exibe os números em ordem crescente porém repetindo-os
        var listaFiltrada = listaNum.OrderBy(a=>a).GroupBy(a=>a).Select(a=>a); //Necessita o atributo key na hora de ser exibido

        foreach(var item in listaFiltrada)
        {
            Console.WriteLine(item.Key);
        }
    }
}
