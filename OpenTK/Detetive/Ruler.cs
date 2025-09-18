namespace Detetive;

public static class Ruler //Classe criada para carregar os objetos do jogo
{
    static Bloco[] tabuleiro =
    {
     new Bloco("A1"), new Bloco("A2"), new Bloco("A3"), new Bloco("A4"),
     new Bloco("B1"), new Bloco("B2"), new Bloco("B3"), new Bloco("B4"),
     new Bloco("C1"), new Bloco("C2"), new Bloco("C3"), new Bloco("C4"),
    };

    private static Personagem[] personagens =
    {
        new Personagem("Advogado Marinho", "Verde", tabuleiro[0]), new Personagem("Chefe Tony Gourmet", "Marrom", tabuleiro[1]),
        new Personagem("Médica Dona Violeta", "Roxo", tabuleiro[2]), new Personagem("Coveiro Sérgio Soturno", "Preto", tabuleiro[3]),
        new Personagem("Dançarina Srta. Rosa", "Vermelho", tabuleiro[4]), new Personagem("Mordomo James", "Azul", tabuleiro[5]),
        new Personagem("Sargento Bigode", "Amarelo", tabuleiro[6])
    };

    private static Carta[] cartas =
    {
        new Carta("Tesoura", "Arma"), new Carta("Pé de Cabra", "Arma"), new Carta("Veneno", "Arma"),
        new Carta("Soco Ingês", "Arma"), new Carta("Faca", "Arma"), new Carta("Espingarda", "Arma"),
        new Carta("Pá", "Arma"), new Carta("Arma Química", "Arma")
    };


    public static Personagem GetPersonagem(string nomePersonagem)
    {
        foreach (Personagem p in personagens)
        {
            if (p.Nome == nomePersonagem) return p;
        }

        return personagens[0];
    }


    public static void ExibirTabuleiro()
    {
        for (int i = 0; i < tabuleiro.Count(); i++)
        {
            if (i == 4) Console.Write("\n");
            if (i == 8) Console.Write("\n");
            Console.Write($" {tabuleiro[i].Localizacao} |");
        }
    }

    public static void CadastroJogador()
    {
        
    }
    
}
