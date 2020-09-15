using System;

/// <summary>
/// VectorMath Class
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculates dot product of either two 2D or two 3D vectors.
    /// </summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if ((vector1.Length == 2 && vector2.Length == 2) || (vector1.Length == 3 && vector2.Length == 3))
        {
            double dot_product = 0;
            for(int i = 0; i < vector1.Length; i++)
                dot_product += vector1[i] * vector2[i];

            return(dot_product);
        }
        else
            return(-1);
    }
}
