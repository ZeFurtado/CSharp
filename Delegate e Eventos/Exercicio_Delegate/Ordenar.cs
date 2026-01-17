namespace Exercicio_Delegate;

public class Ordenar
{
    public delegate int[] InteirosHandler(ref int[] array);

    public static InteirosHandler inteirosHandler;
    public static int[] Ordena(ref int[] array)
    {
        return inteirosHandler(ref array);
    }
}