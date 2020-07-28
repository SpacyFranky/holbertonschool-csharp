using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> temp = myLList.First;
        if (index == 0)
            myLList.Remove(myLList.First);
        while (index > 0)
        {
            temp = temp.Next;
            index--;
        }
        myLList.Remove(temp);
    }
}
