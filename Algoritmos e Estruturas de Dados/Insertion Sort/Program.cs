namespace InsertionSort;

public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int[] arrayDesordenado = new int[random.Next(3, 10)];

        //Preenche array
        for (int i = 0; i < arrayDesordenado.Length; i++)
        {
            arrayDesordenado[i] = random.Next(0, 100);
        }

        Console.WriteLine("Array desordenado: ");
        foreach(int i in arrayDesordenado)
        {
            Console.Write(i + ", ");
        }

        Console.WriteLine("\a");
        Console.WriteLine("Array Ordenado");
        foreach(int i in InsertionSort(arrayDesordenado))
        {
            Console.Write(i + ", ");   
        }
        

    }

    public static int[] InsertionSort(int[] array)
    {
        for(int i = 1; i < array.Length; i++)
        {
            int atual = array[i];
            int j = i -1;

            while(j >= 0 && array[j] >= atual)
            {
                array[j + 1] = atual;
                j--;
            }

            array[j + 1] = atual;
        }
        return array;
    }
}
