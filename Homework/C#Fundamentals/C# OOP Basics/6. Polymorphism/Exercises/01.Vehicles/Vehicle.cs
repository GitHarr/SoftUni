using System;
using System.Collections.Generic;
using System.Text;

public abstract class Vehicle
{
    public Vehicle(double fuelQuantity, double fuelConsumptionLitersPerKm)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumptionLitersPerKm = fuelConsumptionLitersPerKm;
    }

    private double fuelQuantity;

    public double FuelQuantity
    {
        get { return fuelQuantity; }
        set { fuelQuantity = value; }
    }

    private double fuelConsumptionLitersPerKm;
                
    public double FuelConsumptionLitersPerKm
    {
        get { return fuelConsumptionLitersPerKm ; }
        set { fuelConsumptionLitersPerKm  = value; }
    }

    public abstract string Drive(double distance);
    
    public virtual void Refuel(double liters)
    {
        this.FuelQuantity += liters;
    }
    
    public override string ToString()
    {
        string result = $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        return result;
    }
}

