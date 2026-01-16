using static _03_Eventos.Lib.VideoEncode;

namespace _03_Eventos.Lib.Mensageiro;

public class SMS
{
    public void EnviarMensagem(object sender, VideoEventArgs args)
    {
        Console.WriteLine("Enviado para o vídeo: " + args.Video.Nome);
    }
}