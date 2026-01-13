namespace Exercicio_Delegate;

public class Ordenar
{
    public delegate int[] InteirosHandler(int[] array);

    public static InteirosHandler inteirosHandler;
    public static int[] Ordena(int[] array)
    {
        return inteirosHandler(array);
    }
}