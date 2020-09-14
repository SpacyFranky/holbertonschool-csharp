using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
      double[] vector1 = {2.3, 1.5, 2};
      double[] vector2 = {1, 3, 1};
      double[] new_vector = VectorMath.Add(vector1, vector2);
      for(int i = 0; i < new_vector.Length; i++)
      {
        Console.WriteLine(new_vector[i]);
      }
    }
}
