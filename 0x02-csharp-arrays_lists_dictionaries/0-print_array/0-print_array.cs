using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return(null);
        }

        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = i;
            if (i != size - 1)
                Console.Write("{0} ", array[i]);
            else
                Console.Write("{0}\n", array[i]);
        }
        return(array);
    }
}
