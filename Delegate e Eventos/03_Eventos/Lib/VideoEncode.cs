namespace _03_Eventos.Lib;


public class VideoEncode
{
    public delegate void videoEncodedHandler(Video video);
    public event videoEncodedHandler Encoded;
    public void Encode(Video video)
    {
        Console.WriteLine("Convertendo o vídeo...");
        Thread.Sleep(2000);
        Console.WriteLine("Vídeo convertido!");

        Encoded(video);
    }
}