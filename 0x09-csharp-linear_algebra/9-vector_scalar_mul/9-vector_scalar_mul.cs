using System;
using System.Collections.Generic;

/// <summary>
/// VectorMath Class
/// </summary>
class VectorMath
{
    /// <summary>
    /// Multiplies a vector and a scalar and returns the resulting vector.
    /// </summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length == 2 )
        {
            double[] new_vector = new double[2];
            for(int i = 0; i < vector.Length; i++)
                new_vector[i] = vector[i] * scalar;
            return(new_vector);
        }
        else if (vector.Length == 3)
        {
            double[] new_vector = new double[3];
            for(int i = 0; i < vector.Length; i++)
                new_vector[i] = vector[i] * scalar;
            return(new_vector);
        }
        else
        {
            double[] new_vector = new double[] {-1};
            return(new_vector);
        }
    }
}
