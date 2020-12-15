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
    /// Public float amount of health
    /// </summary>
    public delegate float CalculateHealth();

    /// <summary>
    /// Public method that prints the taken damage
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            this.hp = 0;
            Console.WriteLine("{0} takes 0 damage!", this.name);
        }
        else
        {
            this.hp -= damage;
            Console.WriteLine("{0} takes {1} damage!", this.name, damage);
        }
    }

    /// <summary>
    /// Public method that prints the healed damage
    /// </summary>
    /// <param name="heal"></param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            this.hp = 0;
            Console.WriteLine("{0} heals 0 HP!", this.name);
        }
        else
        {
            this.hp += heal;
            Console.WriteLine("{0} heals {1} HP!", this.name, heal);
        }
    }

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
