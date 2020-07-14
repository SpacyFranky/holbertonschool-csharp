using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 8; i++)
            {
                if (i != 8)
                {
                    for (int j = i; j <= 9; j++)
                    {
                        if (i != j)
                        Console.Write("{0}{1}, ", i, j);
                    }
                }
                else
                {
                    int j = i + 1;
                    Console.Write("{0}{1}\n", i, j);
                }
            }
        }
    }
}
