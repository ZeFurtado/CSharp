using _03_Eventos.Lib;
using _03_Eventos.Lib.Mensageiro;

namespace _03_Eventos;

class Program
{
    static void Main(string[] args)
    {
        VideoEncode videoEncode = new VideoEncode();

        Video video1 = new Video{Nome = "Momento 37"};

        videoEncode.Encoded += new Email().EnviarMensagem;

        videoEncode.Encoded += new SMS().EnviarMensagem;

        videoEncode.Encode(video1);

    }
}
