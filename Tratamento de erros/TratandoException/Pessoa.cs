namespace TratandoException;

class Pessoa
{
    private string Nome;
    private string CPF;
    private string CEP;

    public void SetCEP(string cep)
    {
        int resultado;
        if (int.TryParse(CEP, out resultado))
        {
            //Válido
            CEP = cep;
        }
        else
        {
            throw new Exception("CEP inválido");
        }
    }
}