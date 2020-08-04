using System;

namespace Text
{
    /// <summary>
    /// Text Class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Looks for the first unique character in string.
        /// </summary>
        public static int UniqueChar(string s)
        {
            if (s == null)
                return(-1);
            
            int[] a = new int [s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                a[i] = 0;
            }
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (i != j)
                    {
                        if (s[i] == s[j])
                            a[j] += 1;
                    }
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (a[i] == 0)
                    return(i);
            }
            return(-1);
        }
    }
}
