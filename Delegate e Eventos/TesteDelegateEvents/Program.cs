namespace TesteDelegateEvents;

public class Program
{
    static void Main(string[] args)
    {
        Usuario josir = new Usuario("Josir", 13, "Gerente Geral");

        LidaComEvento lidaComEvento = new LidaComEvento();

        lidaComEvento.mensagem += Mensagem.Mensagem1;
        lidaComEvento.mensagem += Mensagem.Mensagem2;
        lidaComEvento.mensagem += Mensagem.Mensagem3;

        lidaComEvento.MensagemHandler(josir);
    }
}
