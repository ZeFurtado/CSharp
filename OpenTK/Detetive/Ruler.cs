namespace Detetive;

public class Ruler //Classe criada para carregar os objetos do jogo
{


    static Bloco[] tabuleiro =
    {
     new Bloco("A1"), new Bloco("A2"), new Bloco("A3"), new Bloco("A4"),
     new Bloco("B1"), new Bloco("B2"), new Bloco("B3"), new Bloco("B4"),
     new Bloco("C1"), new Bloco("C2"), new Bloco("C3"), new Bloco("C4"),
    };

    private Personagem[] personagens =
    {
        new Personagem("Advogado Marinho", "Verde", tabuleiro[0]), new Personagem("Chefe Tony Gourmet", "Marrom", tabuleiro[1]),
        new Personagem("Médica Dona Violeta", "Roxo", tabuleiro[2]), new Personagem("Coveiro Sérgio Soturno", "Preto", tabuleiro[3]),
        new Personagem("Dançarina Srta. Rosa", "Vermelho", tabuleiro[4]), new Personagem("Mordomo James", "Azul", tabuleiro[5]),
        new Personagem("Sargento Bigode", "Amarelo", tabuleiro[6])
    };


    public void ExibirTabuleiro()
    { 
        for (int i = 0; i < tabuleiro.Count(); i++)
        {
            if (i == 4) Console.Write("\n");
            if (i == 8) Console.Write("\n");
            Console.Write($" {tabuleiro[i].Localizacao} |");
        }
    }
    
}
