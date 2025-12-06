using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;

namespace _01_SerializarXML;

public class Program
{
    static void Main(string[] args)
    {
        IMC iMC = new IMC(){Altura = 1.85, Peso=84};        
        Usuario usuario = new Usuario(){Nome = "Jurandir Frente Machado", CPF="222.222.222-22", Email="jurandir@gmail.com", Imc = iMC};

        
        XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
        //XmlSerializer serializador = new XmlSerializer(usuario.GetType());

        StreamWriter streamWriter = new StreamWriter("/home/lukhas/repo/CSharp/Serializacao/01_SerializarXML.xml");
        serializador.Serialize(streamWriter, usuario);
    }
}