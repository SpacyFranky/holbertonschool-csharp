using System;

/// <summary>
/// Abstract Base class
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Public attribute name
    /// </summary>
    public string name;

    /// <summary>
    /// Public method that prints name and type
    /// </summary>
    public override string ToString()
    {
        Type t = this.GetType();
        return name + " is a " + t;
    }
}