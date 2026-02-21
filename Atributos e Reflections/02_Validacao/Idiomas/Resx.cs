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
}