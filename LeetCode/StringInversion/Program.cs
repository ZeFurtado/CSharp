using System.Text;

namespace StringInversion;

class Program
{
    static void Main(string[] args)
    {

        string texto = "Rodelinha"; 
        try
        {
            Console.WriteLine("String origina {0}:        String invertida {1}", texto, StringInvertida(texto));
        }catch(IndexOutOfRangeException excepttion)
        {
            Console.WriteLine("Array fora de alcance");
            Console.WriteLine(excepttion.Message + " " + excepttion.Source);
        }
    }

    public static string StringInvertida(string texto)
    {
        char[] textoChar = texto.ToArray();
        char[] textoInvertidoArray = new char[texto.Count()];
        
        int p = 0;

        for (int i = textoChar.Count() - 1; i >= 0; i--)
        {
            textoInvertidoArray[p] = textoChar[i];
            p++;
        }
        StringBuilder stringBuilder = new StringBuilder();

        string textoInvertido = stringBuilder.Append(textoInvertidoArray).ToString();
        return textoInvertido;
    }
}
