using System;

/// <summary>
/// Shape Class
/// </summary>
public class Shape
{
    /// <summary>
    /// Throws an NotImplementedException.
    /// </summary>
    public virtual int Area()
    {
        throw new System.NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Rectangle Class inherits from Shape.
/// </summary>
public class Rectangle : Shape
{
    // Rectangle's width.
    private int width;
    // Rectangle's height.
    private int height;

    /// <summary>
    /// Rectangle's width.
    /// </summary>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
            {
                throw new System.ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                width = value;
            }
        }
    }

    /// <summary>
    /// Rectangle's height.
    /// </summary>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
            {
                throw new System.ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                height = value;
            }
        }
    }

    /// <summary>
    /// Overrides the Area() method defined in the Shape base class.
    /// </summary>
    public new int Area()
    {
        return (Width * Height);
    }

    /// <summary>
    /// ToString method for printing.
    /// </summary>
    public override string ToString()
    {
        return("[Rectangle] " + Width + " / " + Height);
    }
}
