using System;
using System.Collections.Generic;
using System.Text;

public class Ferrari : ICar
{
    public string Model { get;}
    public string Brakes { get; }
    public string GasPedal { get; }
    public string DriverName { get; }

    public Ferrari(string model, string brakes, string gasPedal, string driverName)
    {
        this.Model = model;
        this.Brakes = brakes;
        this.GasPedal = gasPedal;
        this.DriverName = driverName;
    }

    public override string ToString()
    {
        return $"{this.Model}/{this.Brakes}/{this.GasPedal}/{this.DriverName}";
    }
}

