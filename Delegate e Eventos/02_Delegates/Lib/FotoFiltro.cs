using System.Diagnostics;

namespace _02_Delegates.Lib;

public class FotoFiltro
{
    public void Colorir(Foto foto)
    {
        Console.WriteLine("FotoFiltro > colorir: " + foto.Nome);
    }

    public void GerarThumb(Foto foto)
    {
        Console.WriteLine("FotoFiltro > GerarThumb: " + foto.Nome);
    }

    public void PretoBranco(Foto foto)
    {
        Console.WriteLine("FotoFiltro > PretoBranco: " + foto.Nome);
    }

    public void RedimensionarMedio(Foto foto)
    {
        Console.WriteLine("FotoFiltro > RedimensionarMedio: " + foto.Nome);
    }
}