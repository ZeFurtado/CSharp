using System.Security.Cryptography.X509Certificates;
using OpenTK.Graphics.OpenGL;

namespace Detetive;

public class Program 
{
    static void Main(string[] args)
    {
        string nomeJogador;
        
        int opcao = 1;
        while (opcao != 0)
        {
            Console.WriteLine("1- Começar jogo     2- Sair");
            opcao = int.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite seu nome: ");
                    nomeJogador = Console.ReadLine();
                    break;

                case 2:
                    opcao = 0;
                    break;

                default:
                    Console.WriteLine("Huh?");
                    break;
            }
            
                
            

        }



        /*
        using (Game game = new Game(800, 600, "Janela"))
        {
            game.Run();
        }
         */

    }
}
