using System.ComponentModel;
using System.Resources;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Xml;
using System.Xml.Serialization;
using static System.Xml.XmlTextWriter;

namespace _02_Validacao.Idiomas;


public class Resx
{
    public string Name{get; set;}
    public string Value{get;set;}
    public string Comment{get;set;}

    public static void AddToFile(Resx resxObject, string filePath)
    {
        if(!File.Exists(filePath)) XmlWriter.Create(filePath); 

        try
        {
            using(StreamWriter streamWriter = new StreamWriter(filePath))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Resx));
                xmlSerializer.Serialize(streamWriter, resxObject);
            }
        }catch(Exception ex)
        {
            Console.WriteLine("|Resx.AddToFile()|  Mensagem ERRO: {0}", ex.Message);            
        }
        
    }

    
    public static Resx Deserializacao()
    {
        try
        {
            using(StreamReader stream = new StreamReader("/home/lukhas/repo/CSharp/Atributos e Reflections/02_Validacao/Idiomas/Idiomas.xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Resx));
                return (Resx)xmlSerializer.Deserialize(stream);
            }
        }catch(Exception ex)
        {
            Console.WriteLine("|Resx.Deserializacao()| Mensagem ERRO: {0}", ex.Message);
            return new Resx{Name="", Value="", Comment=""};
        } 
    }
    
}