using System.Diagnostics;

namespace _02_Delegates.Lib;

public class FotoFiltro
{
    public void Colorir(Foto foto)
    {
        Console.Write("FotoFiltro > colorir");
    }

    public void GerarThumb(Foto fot)
    {
        Console.Write("FotoFiltro > GerarThumb");
    }

    public void PretoBranco(Foto foto)
    {
        Console.Write("FotoFiltro > PretoBranco");
    }

    public void RedimensionarMedio(Foto foto)
    {
        Console.Write("FotoFiltro > RedimensionarMedio");
    }
}