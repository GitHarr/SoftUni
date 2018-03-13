using System;
using System.Collections.Generic;
using System.Text;

public class Box
{
    private double length;

    public double Length
    {
        get { return length; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            length = value;
        }
    }

    private double width;

    public double Width
    {
        get { return width; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            width = value;
        }
    }

    private double height;

    public double Height
    {
        get { return height; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            height = value;
        }
    }


    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public double GetSurfaceArea()
    {
       double surfaceArea = (2 * Length * Width) + (2 * Length * Height) + (2 * Width * Height);
        return surfaceArea;
    }

    public double GetLateralSurfaceArea()
    {
        double lateralSurface = (2 * Length * Height) + (2 * Width * Height);
        return lateralSurface;
    }

    public double GetVolume()
    {
        double volume = Length * Width * Height;
        return volume;
    }
}

