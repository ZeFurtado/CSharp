namespace PalavraBase;


public class Carro : Veiculo
{

    /* A palavra-chave base no C# é usada para acessar membros (métodos, propriedades, campos ou construtores) 
    da classe base (ou classe pai) a partir de uma classe derivada. Ela é especialmente útil em cenários de herança, 
    permitindo que você reutilize ou estenda o comportamento da classe base.  */
    public override void Andar()
    {
        base.Andar();
        Console.WriteLine("Veiculo andando");
    }
}