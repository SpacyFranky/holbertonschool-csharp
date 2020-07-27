using System;
using System.Collections.Generic;
class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int s = 0;
        foreach(int i in myLList)
            s += 1;
        return(s);
    }
}
