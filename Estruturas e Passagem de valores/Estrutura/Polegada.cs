namespace Estrutura;

public struct Polegada
{
    double centimetro;
    double polegada;

    public Polegada(double polegadas)
    {
        centimetro = 2.54;
        polegada = centimetro * polegadas;
    }

    public double getPolegada()
    {
        return polegada;
    }

}
