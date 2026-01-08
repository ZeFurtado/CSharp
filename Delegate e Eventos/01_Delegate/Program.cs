using System.Runtime.CompilerServices;

namespace _01_Delegate;

class Program
{

    delegate int Calcula(int a, int b);
    static void Main(string[] args)
    {

        Calcula calc = new Calcula(soma);
        var so = calc(10,20);

        Calcula calc2 = new Calcula(subtrair);
        var su = calc2(10,20);

        Console.WriteLine("Soma: {0}   Subtração: {1}", so, su);

        /*
        int so = soma(10,1);
        int su = subtrair(10,1);
        */
    }

    static int soma(int a, int b)
    {
        return a + b;
    }

    static int subtrair(int a, int b)
    {
        return a - b;
    }
}
