using System.Security.Cryptography.X509Certificates;
using OpenTK.Graphics.OpenGL;
using Detetive.Classes;

namespace Detetive;

public class Program 
{
    static void Main(string[] args)
    {

        Bloco[] tabuleiro =
        { new Bloco("A", 1), new Bloco("A", 2), new Bloco("A",3), new Bloco("A",4),
          new Bloco("B", 1), new Bloco("B", 2), new Bloco("B",3), new Bloco("B",4),
          new Bloco("C",1), new Bloco("C",2), new Bloco("C",3), new Bloco("C",4),
        };

        Jogador jogador1 = new Jogador("Jogador1", new Personagem ("Sgt", "Verde", tabuleiro[0]));


        for (int i = 0; i < tabuleiro.Count(); i++)
        {
            if (i == 4) Console.Write("\n");
            if (i == 8) Console.Write("\n");
            Console.Write($" {tabuleiro[i].Localizacao} |");
        }

        int opcao = 1;
        while (opcao != 0)
        {
            Console.WriteLine("1- Jogar dado     2- Sair");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    jogador1.JogarDado();
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
