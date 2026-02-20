using System.ComponentModel;
using System.Resources;
using System.Runtime.InteropServices;

namespace _02_Validacao.Idiomas;


internal class Resx
{
    public string Name{get; set;}
    public string Value{get;set;}
    public string Comment{get;set;}

    public void AddToFile(string name, string value, string comment)
    {
        
    }

    private string CheckFile()
    {
        if(!File.Exists("./Idiomas.xml"))
        {
            File.Create("./Idiomas.xml");

            return "O arquivo foi criado!";
        } 
        
        return "O arquivo existe";
    }
}