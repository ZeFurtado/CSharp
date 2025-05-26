namespace MetodoAbstrato;

public abstract class Veiculo
{
    string Marca;
    string Modelo;
    string AnodeFabricacao;
    byte Eixos;
    byte Rodas;

    abstract public void MudarMarcha(byte numeroMarcha);
    
}