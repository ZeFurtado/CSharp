using System.Text;

namespace Longest_Common_Prefix;

class Program
{
    static void Main(string[] args)
    {

        string[] palavrasPrefix = new string[]{"beijo", "beiçola", "beira"};
        string[] palavrasPrefix2 = new string[]{"flor", "floração", "fidalgo"};

        Console.WriteLine(LongestCommonPrefix(palavrasPrefix));
        Console.WriteLine(LongestCommonPrefix(palavrasPrefix2));
    }

    public static string LongestCommonPrefix(string[] strs)
    {
        if(strs.Length < 1 || strs.Length > 200) return "";
        if(strs.Count() < 3) throw new PalavraInvalidaException("O array precisa ser de no mínimo 3 palavras");
        if(strs[0].First() != strs[1].First() || strs[1].First() != strs[2].First()) return "";

        char[] palavra1 = strs[0].ToCharArray();
        char[] palavra2 = strs[1].ToCharArray();
        char[] palavra3 = strs[2].ToCharArray();

        StringBuilder sb = new StringBuilder();

        bool equal = true;

        int p = 0;
        while(equal)
        {
            if(p >= palavra1.Count()|| p >= palavra2.Count() || p >= palavra3.Count()) break;

            if(palavra1[p] == palavra2[p] && palavra1[p] == palavra3[p])
            {
                sb.Append(palavra1[p]);
                p++;
            }else
            {
                equal = false;
            }

        }

        return sb.ToString();
    }
}
