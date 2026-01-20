namespace TesteDelegateEvents;

public class Mensagem
{
    public static void Mensagem1(Usuario usuario)
    {
        Console.WriteLine("O nome do usuário é: {0}", usuario.Nome/*Colocar nome do usuário aqui*/);
    }

    public static void Mensagem2(Usuario usuario)
    {
        Console.WriteLine("O cargo do usuário é: {0}", usuario.Cargo/*Colocar nome do usuário aqui*/);
    }

    public static void Mensagem3(Usuario usuario)
    {
        Console.WriteLine("O ID do usuário é: {0}", usuario.ID/*Colocar nome do usuário aqui*/);
    }
}