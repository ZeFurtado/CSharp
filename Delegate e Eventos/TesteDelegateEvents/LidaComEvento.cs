namespace TesteDelegateEvents;

public class LidaComEvento
{
    public delegate void Mensagem(Usuario usuario);

    public event Mensagem mensagem;
    public void MensagemHandler(Usuario usuario)
    {
        mensagem(usuario);
    }
}