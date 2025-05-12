using System.Text;

namespace Palindrome;

/*
Given an integer x, return true if x is a

, and false otherwise.

 

Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.

Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.

 

Constraints:

    -231 <= x <= 231 - 1





*/

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if(x.ToString() == PrintBackwards(x.ToString()))
        {
            Console.WriteLine("É Palíndromo");
            return true;
        }else
        {
            Console.WriteLine("Não é Palíndromo");
            return false;
        }
        
    }

    private string PrintBackwards(string number)
    {
        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < number.Length; i++)
        {
            stringBuilder.Append(number[number.Length - i - 1]);
        }

        return stringBuilder.ToString();

    } 
}
