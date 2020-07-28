using System;
using System.Collections.Generic;
class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> temp;

        if (myLList.Count == 0)
            return(null);

        temp = myLList.First;
        if (temp.Value >= n)
            return(myLList.AddFirst(n));

        while (temp.Next != null)
        {
            if (temp.Next.Value >= n)
            {
                temp = myLList.AddAfter(temp, n);
                return(temp);
            }
            temp = temp.Next;
        }

        temp = myLList.AddLast(n);
        return(temp);
    }   
}
