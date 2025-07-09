namespace PalavraThis;

public class Carro
{
    string Marca;
    string Modelo;
    string AnoFabricacao;
    string AnoModelo;

    public void SetMarca(String Marca)
    {
        /* Palavra 'this' é utilizada para referênciar propriedades da própria classe */
        this.Marca = Marca;
    }

    public void SetModelo(string Modelo)
    {
        this.SetMarca("teste"); //A palavra this pode ser usada para referênciar métodos também
    }
}
