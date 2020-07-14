using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length <= 0)
            Console.WriteLine();

        string c;
        c = "\\";
        for (int i = 0; i < length; i++)
        {
            Console.Write("{0}\n", c);
            c = " " + c;
        }
    }
}
