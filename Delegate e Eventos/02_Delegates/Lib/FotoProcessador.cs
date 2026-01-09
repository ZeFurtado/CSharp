namespace _02_Delegates.Lib;

public class FotoProcessador
{

    public delegate void FotofiltroHandler(Foto foto);

    public static FotofiltroHandler filtros;
    public static void Processar(Foto foto)
    {
        filtros(foto);
        /*
        var filtros = new FotoFiltro();
        filtros.Colorir(foto);
        filtros.GerarThumb(foto);
        filtros.PretoBranco(foto);
        filtros.RedimensionarMedio(foto);
        */
    }

}