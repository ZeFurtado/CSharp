using System.ComponentModel;
using System.Resources;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Serialization;
using static System.Xml.XmlTextWriter;

namespace _02_Validacao.Idiomas;


public class Resx
{
    public string Name{get; set;}
    public string Value{get;set;}
    public string Comment{get;set;}

    public static void AddToFile(Resx resxObject)
    {

        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Resx));
                
        
        StreamWriter streamWriter = new StreamWriter(@"/home/lukhas/repo/CSharp/Atributos e Reflections/02_Validacao/Idiomas/Idiomas.xml");


        xmlSerializer.Serialize(streamWriter, resxObject);
    }

    public static string CheckFile()
    {
        try
        {
            if(!File.Exists("/home/lukhas/repo/CSharp/Atributos e Reflections/02_Validacao/Idiomas/Idiomas.xml"))
            {
                XmlWriter.Create("/home/lukhas/repo/CSharp/Atributos e Reflections/02_Validacao/Idiomas/Idiomas.xml");
                return "O arquivo foi criado!";
            }    
        
        return "O arquivo existe";
        }catch(Exception ex)
        {
            Console.WriteLine("Mensagem ERRO: {0}", ex.Message);
            return "";
        }
        
    }
}