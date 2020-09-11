using System;


/// <summary>
/// VectorMath Class
/// </summary>
class VectorMath
{
    /// <summary>
    /// A method that calculates and returns the length of a given vector.
    /// </summary>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2 || vector.Length == 3)
        {
            double v = 0;
            foreach(double i in vector)
            {
                v += Math.Pow(i, 2);
            }
            v = Math.Sqrt(v);
            return(Math.Round(v, 2));
        }
        else
            return(-1);
    }
}
