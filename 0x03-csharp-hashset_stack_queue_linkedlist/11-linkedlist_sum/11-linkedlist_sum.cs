﻿using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int s = 0;
        foreach (int i in myLList)
            s += i;
        return(s);
    }
}
