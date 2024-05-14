using System;
public class Shape
{
    // Base class for shapes
    public virtual int Area()
    {
        // Throw NotImplementedException with the specified message
        throw new NotImplementedException("Area() is not implemented");
    }
}

public class Rectangle : Shape
{
    private int width;
    private int height;

    public int Width
    {
        get => width;
        /// Gets or sets the width of the rectangle.
        set
        {
            if (value <0)
            {
                throw new ArgumentException("Width must be greater or equal than 0");
                /// If the value is negative, an ArgumentException is thrown.
            }
            else
            {
            width = value;
            }
        }
    }
    public int Height
    {
        get => height;
        /// Gets or sets the height of the rectangle.
        set
        {
            if (value <0)
            {
                throw new ArgumentException("Height must be greater or equal than 0");
                /// If the value is negative, an ArgumentException is thrown.
            }
            else
            {
            height = value;
            }
        }
    }
}
