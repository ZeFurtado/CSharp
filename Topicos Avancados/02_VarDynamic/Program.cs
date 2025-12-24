using Microsoft.CSharp.RuntimeBinder;

namespace _02_VarDynamic;

public class Program
{
    public static void Main(string[] args)
    {
        object obj = "123456";
        object obj2 = 123456;
        object obj3 = new Usuario(){Nome =  "Josefino"};
        Console.WriteLine(((Usuario)obj3).Nome);


        var vi = "";
        var v2 = 123456;
        // var v3; //Necessária declaração do tipo de variável

        dynamic d1 = new Usuario {Nome="Maria"};

        try
        {
            Console.WriteLine(d1.Nome);
            Console.WriteLine(d1.Senha);
        }catch (RuntimeBinderException bEx)
        {
            Console.WriteLine(bEx.Message);
        }

    }

    class Usuario
    {
        public string Nome { get; set; }
    }
}
