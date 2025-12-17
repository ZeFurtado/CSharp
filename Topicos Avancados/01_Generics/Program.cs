using System.Threading.Tasks;
using _01_Generics.modelos;

namespace _01_Generics;

public class Program
{
    static async Task Main(string[] args)
    {
        Carro carro = new Carro(){Marca = "Chrevolet", Modelo="Celta"};
        Casa casa = new Casa(){Cidade="Ivoti", Endereco="Boa Vista"};
        Usuario usuario = new Usuario(){Nome = "Júlio", Email="julio@gmail.com", Senha="9770607060"};

        await Serializador.Serializar(carro);
        await Serializador.Serializar(usuario);
        await Serializador.Serializar(casa);

        Serializador.LerArquivo(carro);


        Carro carro2 = Serializador.Deserializar<Carro>();
        Usuario usuario2 = Serializador.Deserializar<Usuario>();
        Casa casa2 = Serializador.Deserializar<Casa>();

        Console.WriteLine("Carro: Marca: {0} | Modelo: {1}", carro2.Marca, carro2.Modelo);
        Console.WriteLine("Usuário: Nome: {0} | E-mail: {1} | Senha: {2}", usuario2.Nome, usuario2.Email, usuario2.Senha);
        Console.WriteLine("Casa: Cidade: {0} |  Endereço: {1}", casa2.Cidade, casa2.Endereco);
    }
}
