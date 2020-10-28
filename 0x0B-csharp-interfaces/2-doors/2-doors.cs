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

/// <summary>
/// Interface
/// </summary>
interface IInteractive
{
    void Interact();
}

/// <summary>
/// Interface
/// </summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary>
/// Interface
/// </summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary>
/// Public Door class
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Door constructor
    /// </summary>
    public Door(string value)
    {
        if (value == null || value == "")
            name = "Door";
        
        name = value;
    }

    /// <summary>
    /// Public method Interact
    /// </summary>
    public void Interact()
    {
        Console.WriteLine("You try to open the {0}. It's locked.", name);
    }


}
