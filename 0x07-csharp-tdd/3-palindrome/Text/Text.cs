using System;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>
    /// String class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Checks if string is palindrome or not.
        /// </summary>
        public static bool IsPalindrome(string s)
        {
            if ((s.Length == 0) || (s.Length == 1))
                return(true);
            
            s = Regex.Replace(s, @"[^\w\d\s]","");
            s = s.Replace(" ", "");
            s = s.ToLower();

            int j = s.Length - 1;
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[j])
                    return(false);
                j--;
            }
            return(true);
        }
    }
}
