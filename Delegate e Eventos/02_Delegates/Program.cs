using _02_Delegates.Lib;

namespace _02_Delegates;

public class Program
{
    public static void Main(string[] args)
    {

        //Tela - Cadastro de usuário: Thumb (foto de perfil)
        Foto fotoUsuario = new Foto{Nome = "fotoUsuario.jpg", TamanhoX=1920, TamanhoY=1080};
        FotoProcessador.filtros = new FotoFiltro().GerarThumb;
        FotoProcessador.Processar(fotoUsuario);
        
        //Tela - Cadastro de Produtos: Colorir + TamanhoMed

        //Tela - Cadastro de Albuns do Usuário - Retro: Preto e Branco
        
    }
}
