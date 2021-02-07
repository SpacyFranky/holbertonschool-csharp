using System;

/// <summary>
/// Abstract Base class
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Public attribute name
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Public method that prints name and type
    /// </summary>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";;
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
/// Public TestObject class
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// Public object
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Public object
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Public method Interact
    /// </summary>
    public void Interact()
    {
    
    }

    /// <summary>
    /// Public method Break
    /// </summary>
    public void Break()
    {

    }

    /// <summary>
    /// Public method Collect
    /// </summary>
    public void Collect()
    {

    }
}
