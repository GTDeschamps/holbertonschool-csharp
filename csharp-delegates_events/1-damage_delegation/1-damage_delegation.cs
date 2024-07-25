using System;

/// <summary>
/// Represents a player with name, maximum health, and current health properties.
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>
    /// Initializes a new instance of the Player class with a specified name and maximum health.
    /// </summary>
    /// <param name="name">The name of the player.</param>
    /// <param name="maxHp">The maximum health of the player.</param>
    public Player(string name, float maxHp = 100f)
    {
        this.name = name;
        if (maxHp > 0)
        {
            this.maxHp = maxHp;
        }
        else
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.hp = this.maxHp;
    }

    /// <summary>
    ///Delegate for calculating Health Changes
    ///</summary>
    ///<param name="amount"> the amount of health to change </param>
    public delegate void CalculateHealth(float amount);

    /// <summary>
    /// Prints the player's health status.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    ///<summary>
    ///Applies damage to the player's health
    ///</summary>
    /// <param name="damage">The amount of damage to apply.</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
        }
        hp -= damage;
        hp = Math.Max(hp, 0);
        Console.WriteLine($"{name} takes {damage} damage!");
    }

    ///<summary>
    ///Heals the player's health.
    ///</summary>
    ///<param name="heal"> the amount of health to heal. </param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }
        hp += heal;
        hp = Math.Min(hp, maxHp);
        Console.WriteLine($"{name} heals {heal} health!");
    }
}
