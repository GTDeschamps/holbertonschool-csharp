using System;

/// <summary>
/// Base class
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Name Property
    /// </summary>
    public string name { get; set;}
    /// <summary>
    /// Override TostringMethod
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
}

