namespace ConstrutorBase;


public class Carro : Veiculo
{

    public Carro(int i) : base(i)
    {

    }
    public override void Andar()
    {
        base.Andar();
        Console.WriteLine("Veiculo andando");
    }
}