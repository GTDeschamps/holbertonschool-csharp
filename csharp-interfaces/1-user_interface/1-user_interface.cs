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
    void Interact();
}

/// <summary>
/// Ibreakable interface
/// </summary>
public interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary>
/// ICollectible interface
/// </summary>
public interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary>
/// TestObject class
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }
    public void Interact()
    {
        // Implement Interact method
    }

    public void Break()
    {
        // Implement Break method
    }

    public void Collect()
    {
        // Implement Collect method
    }
}
