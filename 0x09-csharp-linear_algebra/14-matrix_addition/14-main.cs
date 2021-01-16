using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
      double[,] matrix1 = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
      double[,] matrix2 = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
      double[,] new_matrix = MatrixMath.Add(matrix1, matrix2);

      for(int i = 0; i < new_matrix.GetLength(0); i++)
      {
        for(int j = 0; j < new_matrix.GetLength(1); j++)
          Console.Write("{0} ", new_matrix[i,j]);
        Console.WriteLine();
      }
    }
}
