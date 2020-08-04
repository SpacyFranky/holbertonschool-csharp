using System;

namespace Text
{
    /// <summary>
    /// Str class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Determines how many words are in a string. Each word begins with a capital
        /// letter except the first word.
        /// </summary>
        public static int CamelCase(string s)
        {
            int words = 0;
            if (s.Length == 0)
                return(0);
            
            if (char.IsLower(s[0]))
            {
                for (int i = 0 ; i < s.Length; i++)
                {
                    if (s[i] == ' ')
                    {
                        if ((i+1 < s.Length) && (char.IsUpper(s[i+1])))
                            words += 1;
                    }
                }
                return(words+1);
            }
            return(words);
        }
    }
}
