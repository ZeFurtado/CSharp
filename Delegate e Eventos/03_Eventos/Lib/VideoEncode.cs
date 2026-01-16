namespace _03_Eventos.Lib;


public class VideoEncode
{
    //public delegate void videoEncodedHandler(Video video);
    //public event videoEncodedHandler Encoded;

    public event EventHandler<VideoEventArgs> Encoded;
    public void Encode(Video video)
    {
        Console.WriteLine("Convertendo o vídeo...");
        Thread.Sleep(2000);
        Console.WriteLine("Vídeo convertido!");

        Encoded(this, new VideoEventArgs(){Video = video});
    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}