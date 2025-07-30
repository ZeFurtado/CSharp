namespace Detetive;

public class Bloco
{
    string Localizacao { get; set; }
    /* 
    Ex:
    A1 | A2 | A3 | A4 |
    B1 | B2 | B3 | B4 |
    C1 | C2 | C3 | C4 |
     */
    bool Ocupado { get; set; } = false; //Caso o jogador pare 'em cima' do bloco ele é setado Ocupado = true
}
