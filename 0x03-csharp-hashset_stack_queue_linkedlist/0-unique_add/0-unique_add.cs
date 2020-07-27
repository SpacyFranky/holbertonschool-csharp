using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        var hashSet = new HashSet<int>(myList);
        int s = 0;
        foreach(int i in hashSet)
        {
            s += i;
        }
        return(s);
    }
}
