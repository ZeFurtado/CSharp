namespace CustomizarException;

class MinhaException : Exception
{
    string LinhaDoErro;
    public MinhaException(string linha) : base("Minha exception")
    {
        LinhaDoErro = linha;
    }
}