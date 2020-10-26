using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
      double[] vector1 = {2, 1, 2};
      double[] vector2 = {1, 3, 1};
      double dot_product = VectorMath.DotProduct(vector1, vector2);
      Console.WriteLine("Dot Product = {0}", dot_product);
    }
}
