using System;

/// <summary>
/// Object Class
/// </summary>
class Obj
{
    /// <summary>
    /// Returns True if the object is an int, otherwise Flase.
    /// </summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
            return true;
        else
            return false;
    }
}

