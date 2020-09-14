using System;
using System.Collections.Generic;

/// <summary>
/// VectorMath Class
/// </summary>
class VectorMath
{
    /// <summary>
    /// Adds two vectors and returns the resulting vector.
    /// </summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if ((vector1.Length == 2 && vector2.Length == 2) || (vector1.Length == 3 && vector2.Length == 3))
        {
            double[] new_vector = new double[3];
            // double sum = 0;
            for(int i = 0; i < vector1.Length; i++)
            {
                // Console.WriteLine(vector1[i]);
                // Console.WriteLine(vector2[i]);
                new_vector[i] = vector1[i] + vector2[i];
                // Console.WriteLine(new_vector[i]);
                // sum += Math.Pow(new_vector[i], 2);
            }
            // sum = Math.Sqrt(sum);
            // return(Math.Round(sum, 2));
            return(new_vector);
        }
        else
        {
            double[] new_vector = new double[] {-1};
            return(new_vector);
        }
    }
}
