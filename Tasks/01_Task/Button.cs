namespace _01_Task;


public class Button
{
    public delegate void Botao(string endereco);

    public static event Botao botaoHandler;


    public static void Disparar(string endereco)
    {
        botaoHandler(endereco);
    }
}