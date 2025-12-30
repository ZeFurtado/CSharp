using System.Diagnostics.Contracts;
using System.Threading.Tasks.Sources;

namespace System;

public static class StringExtension
{   
    public static string FirsTToUpper(this string str)
    {
        string primeiraLetra =  str.Substring(0,1).ToUpper();
        string segundaParte = str.Substring(1, str.Length - 1);   

        return  primeiraLetra + segundaParte;
    }
}
