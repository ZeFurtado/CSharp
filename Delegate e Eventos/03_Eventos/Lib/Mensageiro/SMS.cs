namespace _03_Eventos.Lib.Mensageiro;

public class SMS
{
    public void EnviarMensagem(Video video)
    {
        Console.WriteLine("Enviado para o vídeo: " + video.Nome);
    }
}