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
    public Door(string value = "Door")
    {
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

/// <summary>
/// Public Decoration class
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// Public bool object
    /// </summary>
    public bool isQuestItem { get; set; }

    /// <summary>
    /// Public int object
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public Decoration(string value = "Decoration", int number = 1, bool item = false)
    {
        name = value;

        if (number <= 0)
            throw new System.ArgumentException("Durability must be greater than 0");
        else
            durability = number;

        isQuestItem = item;
    }

    /// <summary>
    /// Public method
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine("The {0} has been broken.", name);

        else
        {
            if (isQuestItem == true)
                Console.WriteLine("You look at the {0}. There's a key inside.", name);
        
            else
                Console.WriteLine("You look at the {0}. Not much to see here.", name);
        }
    }

    /// <summary>
    /// Public method that decrements durability by 1
    /// </summary>
    public void Break()
    {
        durability--;

        if (durability > 0)
            Console.WriteLine("You hit the {0}. It cracks.", name);
        else if (durability == 0)
            Console.WriteLine("You smash the {0}. What a mess.", name);
        else
            Console.WriteLine("The {0} is already broken.", name);
    }
}