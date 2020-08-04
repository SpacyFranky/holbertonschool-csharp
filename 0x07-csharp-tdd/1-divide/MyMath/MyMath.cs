using System;

namespace MyMath
{
    public class Matrix
    {
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return(null);

            int[,] divmatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                    try
                    {
                        divmatrix[i, j] = matrix[i, j] / num;
                    }
                    catch
                    {
                        throw new System.ArgumentException("Num cannot be 0");
                        return(null);
                    }
            }
            return(divmatrix);
        }
    }
}
