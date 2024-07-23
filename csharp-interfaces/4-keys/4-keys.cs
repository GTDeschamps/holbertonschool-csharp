using System;

/// <summary>
/// Base class
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Name Property
    /// </summary>
    public string name { get; set; }
    /// <summary>
    /// Override TostringMethod
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
}

/// <summary>
/// IIteractive interface
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Interacts with the object
    /// </summary>
    void Interact();
}

/// <summary>
/// Ibreakable interface
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// Gets or sets the durability of the object
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Breaks the object
    /// </summary>
    void Break();
}

/// <summary>
/// ICollectible interface
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// Gets or sets a value indicating whether the object is collected
    /// </summary>
    bool isCollected { get; set; }
    /// <summary>
    /// Collects the object
    /// </summary>
    void Collect();
}

/// <summary>
/// Door class
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    ///constructor
    /// </summary>
    /// <param name="name">Name of the door</param>
    public Door(string name = "Door")
    {
        this.name = name;
    }
    /// <summary>
    /// Interact with Door
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

/// <summary>
/// A decoration that can be interacted with and broken.
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// Gets or sets a value indicating whether this decoration is durable.
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this decoration is a quest item.
    /// </summary>
    /// <value>
    ///<c>true</c> if this decoration is a quest item; otherwise, <c>false</c>.
    /// </value>
    public bool isQuestItem { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Decoration"/> class.
    /// </summary>
    /// <param name="name">The name of the decoration.</param>
    /// <param name="durability">The durability of the decoration.</param>
    /// <param name="isQuestItem">The quest item status of the decoration.</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new ArgumentException("Durability must be greater than 0");
        }

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Interacts with the decoration.
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    /// <summary>
    /// Breaks the decoration.
    /// </summary>
    public void Break()
    {
        durability -= 1;

        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if (durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}

/// <summary>
/// a key to open the door
/// </summary>
public class Key : Base, ICollectable
{
    /// <summary>
    /// Gets or sets a value indicating whether the key is collected
    /// </summary>
    /// <value>Getter and setter</value>
    public bool isCollected{get; set;}

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name">Name of the key</param>
    /// <param name="isCollected">Whether the key is collected</param>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Collects the key
    /// </summary>
    public void Collect()
    {
        if (!isCollected)
        {
            this.isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}
