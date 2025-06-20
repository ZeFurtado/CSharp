namespace LINQ;

class Program
{

    /*
    🧩 Desafios com LINQ:

    Filtrar os produtos que estão em estoque.

    Obter os nomes dos produtos da categoria "Periféricos".

    Listar os produtos com preço acima de R$ 500, ordenados pelo preço (descrescente).

    Agrupar os produtos por categoria e exibir o nome da categoria e a quantidade de produtos.

    Verificar se todos os produtos da categoria "Periféricos" estão em estoque.

    Obter o produto mais caro e o mais barato.
    */

    static void Main(string[] args)
    {
        List<Produto> produtos = new List<Produto>
        {
            new Produto { Id = 1, Nome = "Teclado", Categoria = "Periféricos", Preco = 150, EmEstoque = true },
            new Produto { Id = 2, Nome = "Mouse", Categoria = "Periféricos", Preco = 100, EmEstoque = true },
            new Produto { Id = 3, Nome = "Monitor", Categoria = "Display", Preco = 900, EmEstoque = false },
            new Produto { Id = 4, Nome = "Notebook", Categoria = "Computadores", Preco = 3000, EmEstoque = true },
            new Produto { Id = 5, Nome = "Webcam", Categoria = "Periféricos", Preco = 250, EmEstoque = false },
            new Produto { Id = 6, Nome = "SSD", Categoria = "Armazenamento", Preco = 400, EmEstoque = true }
        };

        var emEstoque = produtos.Where(p => p.EmEstoque);

        foreach (var produto in emEstoque)
        {
            Console.WriteLine(produto.Nome);
        }
    }
}