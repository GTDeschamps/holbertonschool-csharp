using System;

/// <summary>
///Delegate for calculating Health Changes
///</summary>
///<param name="amount"> the amount of health to change </param>
public delegate void CalculateHealth(float amount);

/// <summary>
/// Enum for modifier values
/// </summary>
public enum Modifier
{
    /// <summary>
    /// Represents a weak modifier, which reduces the base value by half.
    /// </summary>
    Weak,

/// <summary>
    /// Represents a Base modifier, which keep the base value.
    /// </summary>
    Base,

    /// <summary>
    /// Represents a Strong modifier, which increase the base value by 1.5.
    /// </summary>
    Strong
}

///<summary>
/// Delegate for calculating modifier
/// </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);


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
        float newHp = hp - damage;
        ValidateHP(newHp);
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
        float newHp = hp + heal;
        ValidateHP(newHp);
        Console.WriteLine($"{name} heals {heal} HP!");
    }

    ///<summary>
    ///Validates the new HP value and sets it to the player's HP.
    ///</summary>
    ///<param name="newHp">The new HP value to validate and set.</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            hp = 0;
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }
    }

    ///<summary>
    ///apply the Modifier
    ///</summary>
    ///<param name="baseValue"> the base value to modify </param>
    ///<param name="modifier">The modifier to apply.</param>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue * 0.5f;
            case Modifier.Base:
                return baseValue;
            case Modifier.Strong:
                return baseValue * 1.5f;
            default:
                throw new ArgumentException("Invalid modifier value");
        }
    }
}
