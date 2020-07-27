using System;
using System.Collections.Generic;
class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> newList = new List<int>();
        newList = list1.FindAll(i => list2.Contains(i));
        return(newList);
    }
}
