using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Mathematical operations class
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Finding the max integer in a list of integers
        /// </summary>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
                return(0);

            int big = 0;
            foreach (int item in nums)
            {
                if (big <= item)
                    big = item;
            }
            return(big);
        }
    }
}
