using System;

/// <summary>
///
/// </summary>
public abstract class Base
{
    /// <summary>
    ///
    /// </summary>
    public string name;

    /// <summary>
    ///
    /// </summary>
    public override string ToString()
    {
        Type t = this.GetType();
        return name + " is a " + t;
    }
}