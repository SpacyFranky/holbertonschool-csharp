﻿using System;

class Array
{
    public static int elementAt(int[] array, int index)
    {
        int i;

        if (index < 0 || index > array.Length)
        {
            Console.WriteLine("Index out of range");
            return(-1);
        }
        for (i = 0; i < index; i++)
            ;
        return(array[i]);
    }
}