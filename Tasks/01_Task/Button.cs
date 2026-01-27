namespace _01_Task;


public class Button
{

    public string Endereco{get;set;}
    public delegate void Botao(string endereco);

    public static event Botao botaoHandler;

    public Button(string endereco)
    {
        Endereco = endereco;
    }

    public void Disparar()
    {
        botaoHandler(Endereco);
    }

    public static void Disparar(string endereco)
    {
        botaoHandler(endereco);
    }
}