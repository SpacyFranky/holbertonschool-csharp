using System;

/// <summary>
/// Player class
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>
    /// Class Constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="maxHp"></param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp > 0.0f)
        {
            this.maxHp = maxHp;
            this.hp = maxHp;
        }
        else
        {
            this.maxHp = 100f;
            this.hp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
    }

    /// <summary>
    /// Public method that prints health
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }
}
