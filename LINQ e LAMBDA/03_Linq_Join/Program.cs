using System.Net.WebSockets;

namespace _03_Linq_Join;

class Program
{
    static void Main(string[] args)
    {

        List<Autor> autores = new List<Autor>()
        {
            new Autor{Id=1, Nome="Rick Riordan"},
            new Autor{Id=2, Nome="Oliver Bowden"},
            new Autor{Id=3, Nome="J. K. Rowlling"},
            new Autor{Id=4, Nome="Stephen Hawking"},
            new Autor{Id=5, Nome="Stephen King"}
        };
    
        List<Livro> livros = new List<Livro>()
        {
            new Livro{Id=1, AutorId=1, Titulo="Percy Jackson e o Ladrão de Raios", AnoPublicacao=2008},
            new Livro{Id=2, AutorId=3, Titulo="Harry Potter e a Câmara Secreta", AnoPublicacao=1996},
            new Livro{Id=3, AutorId=5, Titulo="It. A coisa", AnoPublicacao=1985},
            new Livro{Id=4, AutorId=3, Titulo="Harry Potter e o Cálice de Fogo", AnoPublicacao=1998},
            new Livro{Id=5, AutorId=4, Titulo="Universo numa casca de noz", AnoPublicacao=1999},
            new Livro{Id=6, AutorId=3, Titulo="Harry Potter e a Ordem da Fênix", AnoPublicacao=2000},
            new Livro{Id=7, AutorId=2, Titulo="Assassin's Creed: A Irmandade", AnoPublicacao=2011}
        };
        
        var listaJoin = from livro in livros join autor in autores on livro.AutorId equals autor.Id select new {livro, autor}; 

        foreach(var item in listaJoin)
        {
            Console.WriteLine("{0} - {1}", item.livro.Titulo, item.autor.Nome);
        }
    }
}
