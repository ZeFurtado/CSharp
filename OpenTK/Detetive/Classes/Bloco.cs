using OpenTK.Graphics.OpenGL;

namespace Detetive.Classes;

public class Bloco
{
    public string Letra { get; set; }
    public int Numero { get; set; }
    /* 
    Exemplo:
    A1 | A2 | A3 | A4 |
    B1 | B2 | B3 | B4 |
    C1 | C2 | C3 | C4 |
     */
    public bool Ocupado { get; set; } = false; //Caso o jogador pare 'em cima' do bloco ele é setado Ocupado = true

    public Bloco(string letra, int numero)
    {
        Letra = letra;
        Numero = numero;
    }

    public string toString()
    {
        return $"{Letra}{Numero}";
    }
}
