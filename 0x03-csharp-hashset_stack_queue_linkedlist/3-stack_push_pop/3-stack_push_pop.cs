using System;
using System.Collections.Generic;
class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);
        if(aStack.Count == 0)
            Console.WriteLine("Stack is empty");
        else
        {
            Console.WriteLine("Top item: {0}", aStack.Peek());
            if(aStack.Contains(search))
            {
                Console.WriteLine("Stack contains \"{0}\": {1}", search, aStack.Contains(search));
                int index = 0;
                foreach(var i in aStack)
                {
                    if(i == search)
                        break;
                    index += 1;
                }
                while (aStack.Count >= index)
                    aStack.Pop();
                aStack.Push(newItem);
            }
            else
                Console.WriteLine("Stack contains \"{0}\": {1}", search, aStack.Contains(search));
        }
        return(aStack);
    }
}
