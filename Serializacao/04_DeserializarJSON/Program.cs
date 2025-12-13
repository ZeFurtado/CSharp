using System.Text.Json;
using _00_Biblioteca;   
using System.IO;
using System.Text.Json.Serialization;

namespace _04_DeserializarJSON;

class Program
{
    static void Main(string[] args)
    {

        try
        {
            string jsonfile = File.ReadAllText("/home/lukhas/repo/CSharp/Serializacao/SerializarJSON.json");

            Usuario usuario = JsonSerializer.Deserialize<Usuario>(jsonfile)!;

            Console.WriteLine("Nome: {0} \a CPF: {1} \a E-mail: {2} \a IMC: {3} \a",usuario.Nome, usuario.CPF, usuario.Email, usuario.getImc());            
            
        }catch(Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message + "\a Fonte: " + ex.Source );
        }
        
    }
}
