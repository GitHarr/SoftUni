using System;
using System.Collections.Generic;
using System.Text;

public class Tires
{
    private int age;
    private double pressure;

    public Tires(int age, double pressure)
    {
        this.age = age;
        this.pressure = pressure;
    }

    public double Pressure
    {
        get { return this.pressure; }
    }
}

