using System.Security;

namespace _00_Biblioteca;

public class IMC
{
    public int Peso { get; set; }
    public double Altura {get;set;}

    public double getImc()
    {
        return Peso / (Altura * Altura);
    }
}