using System;
using System.Collections.Generic;

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
    /// Class Constructor
    /// </summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new System.ArgumentException("Durability must be greater than 0");

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Public method
    /// </summary>
    public void Interact()
    {
        if (this.durability <= 0)
            Console.WriteLine("The {0} has been broken.", this.name);

        else
        {
            if (this.isQuestItem == true)
                Console.WriteLine("You look at the {0}. There's a key inside.", this.name);
        
            else
                Console.WriteLine("You look at the {0}. Not much to see here.", this.name);
        }
    }

    /// <summary>
    /// Public method that decrements durability by 1
    /// </summary>
    public void Break()
    {
        this.durability--;

        if (this.durability > 0)
            Console.WriteLine("You hit the {0}. It cracks.", this.name);
        else if (this.durability == 0)
            Console.WriteLine("You smash the {0}. What a mess.", this.name);
        else
            Console.WriteLine("The {0} is already broken.", this.name);
    }
}

/// <summary>
///  Public Key class
/// </summary>
public class Key : Base, ICollectable
{
    /// <summary>
    /// Public bool object
    /// </summary>
    /// <value>isCollected</value>
    public bool isCollected { get; set; }
    
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="isCollected"></param>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }
    
    /// <summary>
    /// Public method
    /// </summary>
    public void Collect()
    {
        if (this.isCollected == false)
        {
            this.isCollected = true;
            Console.WriteLine("You pick up the {0}.", this.name);
        }
        else
            Console.WriteLine("You have already picked up the {0}.", this.name);
    }
}

/// <summary>
/// Public RoomObjects class
/// </summary>
public class Objs<T> : IEnumerable<T>
{
    /// <summary>
    /// Setting up the list of items public object
    /// </summary>
    /// <value></value>
    public List<T> TList { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public Objs()
    {
        TList = new List<T>();
    }

    /// <summary>
    /// Adding to the list public method
    /// </summary>
    /// <param name="item"></param>
    public void Add(T item)
    {
        TList.Add(item);
    }

    /// <summary>
    /// Public method that Returns an enumerator that iterates through a collection
    /// </summary>
    /// <returns></returns>
    public IEnumerator<T> GetEnumerator()
    {
        return TList.GetEnumerator();
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
