using System.Text.Json;
using System.IO;
using _00_Biblioteca;
using System.Threading.Tasks;

namespace _03_Serializar;

public class Program()
{
    static async Task Main(string[] args)
    {       
        Usuario usuario = new Usuario()
        {
            Nome = "Jurandir Frente Machado", 
            CPF="222.222.222-22", 
            Email="jurandir@gmail.com", 
            Imc = new IMC(){Altura = 1.85, Peso=84}
        };

        try
        {
            string filePath = "/home/lukhas/repo/CSharp/Serializacao/SerializarJSON.json";
            await using FileStream fileStream = File.Create(filePath);
            await JsonSerializer.SerializeAsync(fileStream, usuario);
            fileStream.Close();

            Console.WriteLine(File.ReadAllText(filePath));       
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        
    }
}
