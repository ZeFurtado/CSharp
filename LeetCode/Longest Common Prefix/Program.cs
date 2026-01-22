using System.Text;

namespace Longest_Common_Prefix;


/*
Longest Common Prefix
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

 

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"

Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.

 

Constraints:

    1 <= strs.length <= 200
    0 <= strs[i].length <= 200
    strs[i] consists of only lowercase English letters if it is non-empty.


*/

class Program
{
    static void Main(string[] args)
    {

        string[] palavrasPrefix = {"beijo", "beiçola", "beira"};
        string[] palavrasPrefix2 = {"flor", "floração", "fidalgo"};
        string[] palavrasPrefix3 = {"maresia", "maré", "marisol"};
        string[] palavrasPrefix4 = {"flower","flow","flight"};

        Console.WriteLine(LongestCommonPrefix(palavrasPrefix));
        Console.WriteLine(LongestCommonPrefix(palavrasPrefix2));
        Console.WriteLine(LongestCommonPrefix(palavrasPrefix3));
        Console.WriteLine(LongestCommonPrefix(palavrasPrefix4));
    }

    public static string LongestCommonPrefix(string[] strs)
    {
        if(strs.Length < 1 || strs.Length > 200) return "";
        if(strs.Length == 1) return strs[0];
        
        char[] prefix = strs[0].ToCharArray();
        StringBuilder stringBuilder = new StringBuilder();

        foreach (string str in strs)
        {
            char[] palavra = str.ToCharArray();
            int p = 0;
            foreach(char c in prefix)
            {
                if(p >= palavra.Count())
                {
                    break;
                }else if(c == palavra[p]) 
                {
                   stringBuilder.Append(c);
                   p++; 
                }else if (c != palavra[p])
                {
                    break;   
                }
            }
            prefix = stringBuilder.ToString().ToCharArray();
            stringBuilder.Clear();
        }

        foreach(char c in prefix)
        {
            stringBuilder.Append(c);
        }

        return stringBuilder.ToString();
    }
}
