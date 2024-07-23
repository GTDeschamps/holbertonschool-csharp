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
/// TestObject class
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// Gets or sets the durability of the object
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the object is collected
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Interacts with the object
    /// </summary>
    public void Interact()
    {
        // Implement Interact method
    }

    /// <summary>
    /// Breaks the object
    /// </summary>
    public void Break()
    {
        // Implement Break method
    }

    /// <summary>
    /// Collects the object
    /// </summary>
    public void Collect()
    {
        // Implement Collect method
    }
}
