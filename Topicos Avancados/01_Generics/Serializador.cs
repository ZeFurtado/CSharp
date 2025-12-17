using System.Text.Json;
using System.Threading.Tasks;

namespace _01_Generics;

public class Serializador 
{
    public static async Task Serializar(object obj)
    {
        try
        {
            string path = $"/home/lukhas/repo/CSharp/Topicos Avancados/{obj.GetType().Name}JsonFile.json";

            StreamWriter streamWriter = new StreamWriter(path);
            string texto = JsonSerializer.Serialize(obj, obj.GetType());
            streamWriter.WriteLine(texto);

            streamWriter.Close();
            
        }catch (Exception ex)
        {
            Console.WriteLine("Mensagem de Erro IO: " + ex.Message + "Fonte:  " + ex.Source);
        }
    }

    public static void LerArquivo(object obj)
    {
        try
        {
            string path = $"/home/lukhas/repo/CSharp/Topicos Avancados/{obj.GetType().Name}JsonFile.json";
            if(!File.Exists(path))throw new IOException();

            StreamReader streamReader = new StreamReader(path);
            string texto = streamReader.ReadToEnd();
            streamReader.Close();
            
            Console.WriteLine(texto); 
        }catch(IOException ex)
        {
            Console.WriteLine("Mensagem de Erro IO: " + ex.Message + "Fonte:  " + ex.Source);
        }
            
    }

    public static T? Deserializar<T>()
    {
        try
        {
            string jsonFile = File.ReadAllText($"/home/lukhas/repo/CSharp/Topicos Avancados/{typeof(T).Name}JsonFile.json");
            T t = JsonSerializer.Deserialize<T>(jsonFile);
            return t;
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            return default(T);
        }
    }
}
