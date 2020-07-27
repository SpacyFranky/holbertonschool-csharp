using System;
using System.Collections.Generic;
class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> hashSet = new HashSet<int>();
        foreach(int i in list1)
        {
            if(!list2.Contains(i))
                hashSet.Add(i);
        }
        foreach(int i in list2)
        {
            if(!list1.Contains(i))
                hashSet.Add(i);
        }
        List<int> newList = new List<int>(hashSet);
        newList.Sort();
        return(newList);
    }
}
