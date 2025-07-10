using System.Collections;

namespace BoxingUnboxing;

/* Boxing é o processo de converter um tipo valor (como int, float, bool, structs) em um tipo objeto (tipo por referência). */
public class Program
{
    static void Main()
    {

        int numero = 42;
        object obj = numero; // Boxing: o valor de 'numero' é empacotado como um object

        object obj2 = 42;
        int numero2 = (int)obj2; // Unboxing: o objeto é convertido de volta para int


        //Exemplo
        ArrayList lista = new ArrayList();

        int idade = 25;
        double altura = 1.75;

        
        //BOXING: convertendo de object para tipo valor
        lista.Add(idade);   // int -> object
        lista.Add(altura);  // double -> object

        //UNBOXING: convertendo valor para object:
        int idadeExtraida = (int)lista[0];
        double alturaExtraida = (double)lista[1];

        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Altura: {altura}");

    }
}