using System.Security.Cryptography.X509Certificates;

namespace DelegateEvents;

class Program
{
    static void Main(string[] args)
    {
        var figura = new Figura()
        {
            Altura = 10,
            Largura = 10,
            Profundidade = 10
        };

        figura.Calcular += CalcularAreaQuadrado;

        static void CalcularAreaQuadrado(double altura, double largura, double profundidade)
        {
            var area = altura * largura;
            Console.WriteLine("Evento disparado da class Programa");
            Console.WriteLine(area);
        }

    }
}
