using System;
/// <summary>
/// Base class for shapes
/// </summary>
public class Shape
{
    // Base class for shapes
    public virtual int Area()
    {
        // Throw NotImplementedException with the specified message
        throw new NotImplementedException("Area() is not implemented");
    }
}


/// <summary>
/// Represents a rectangle shape.
/// </summary>
public class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// Gets or sets the width of the rectangle.
    /// </summary>    public int Width
    /// If the value is negative, an ArgumentException is thrown.
    public int Width
    {
        get => width;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater or equal to 0");
            }
            else
            {
            width = value;
            }
        }
    }

    /// <summary>
    /// Gets or sets the height of the rectangle.
    /// </summary>
    /// If the value is negative, an ArgumentException is thrown.
    public int Height
    {
        get => height;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater or equal to 0");
            }
            else
            {
            height = value;
            }
        }
    }
}
