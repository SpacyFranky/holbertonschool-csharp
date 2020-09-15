using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
      double[] vector = {2.3, 1.5};
      double[] new_vector = VectorMath.Multiply(vector, 2);
      for(int i = 0; i < new_vector.Length; i++)
      {
        Console.WriteLine(new_vector[i]);
      }
    }
}
