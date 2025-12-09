using _00_Biblioteca;
using System.IO;
using System.Xml.Serialization;

namespace _02_DeserializarXML;

public class Program
{
    static void Main(string[] args)
    {
        Usuario usuario = new Usuario();
        XmlSerializer serializer = new XmlSerializer(typeof(Usuario));

        StreamReader streamReader = new StreamReader("/home/lukhas/repo/CSharp/Serializacao/01_SerializarXML.xml");
        usuario = (Usuario)serializer.Deserialize(streamReader);

        Console.WriteLine("Usuário(Nome): {0}, CPF:{1}, E-Mail:{2}, IMC:{3}", usuario.Nome, usuario.CPF, usuario.Email, usuario.getImc());
    }
}
