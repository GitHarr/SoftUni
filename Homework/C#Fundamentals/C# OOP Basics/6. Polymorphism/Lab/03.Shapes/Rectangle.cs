using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle : Shape
{
    public Rectangle(double sideA, double sideB)
    {
        this.SideA = sideA;
        this.SideB = sideB;
    }

    public double SideA { get; set; }
    public double SideB { get; set; }

    public override double CalculateArea()
    {
        var area = this.SideA * this.SideB;
        return area;
    }

    public override double CalculatePerimeter()
    {
        var perimeter = this.SideA * 2 + this.SideB * 2;
        return perimeter;
    }

    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}

