namespace DelegateEvents;

public class Figura
{
    public delegate void Calculo(double altura, double largura, double profundidade);
    public double Altura { get; set; }
    public double Largura{get; set;}
    public double Profundidade{get;set;}

    public event Calculo Calcular;

    public void EventHandler()
    {
        Calcular(this.Altura, this.Largura, this.Profundidade);
    }
}