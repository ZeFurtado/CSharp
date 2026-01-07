namespace _02_Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Usuario> usuarios = new List<Usuario>();
        
        usuarios.Add(new Usuario{Nome = "Sérgio", Email = "sergio@yahoo.com"});
        usuarios.Add(new Usuario{Nome = "Roberto", Email = "roberto@gmail.com"});
        usuarios.Add(new Usuario{Nome = "Alberto", Email = "alberto@outlook.com"});
        usuarios.Add(new Usuario{Nome = "Eloi", Email="eloi@gmail.com"});
        usuarios.Add(new Usuario{Nome="Marcio", Email="marcio@gmail.com"});


        var listaFiltrada = usuarios.Where(a => a.Email.Contains("@gmail")).Select(a => a);

        foreach(var item in listaFiltrada)
        {
            Console.WriteLine("Nome: {0}     Email: {1}", item.Nome, item.Email);        
        }
    }
}
