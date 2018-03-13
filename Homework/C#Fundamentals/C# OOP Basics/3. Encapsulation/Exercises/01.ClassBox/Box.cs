using System;
using System.Collections.Generic;
using System.Text;

public class Box
{
    private double Length { get; }
    private double Width { get; }
    private double Height { get; }

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

