using System;
using System.Collections.Generic;
using System.Text;

public abstract class Vehicle
{
    public Vehicle(double fuelQuantity, double fuelConsumptionLitersPerKm, double fuelCapacity)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumptionLitersPerKm = fuelConsumptionLitersPerKm;
        this.FuelCapacity = fuelCapacity;
    }

    private double fuelQuantity;
    private double fuelConsumptionLitersPerKm;
    private double fuelCapacity;

    public double FuelQuantity
    {
        get { return fuelQuantity; }
        set { fuelQuantity = value; }
    }
             
    public double FuelConsumptionLitersPerKm
    {
        get { return fuelConsumptionLitersPerKm ; }
        set { fuelConsumptionLitersPerKm  = value; }
    }

    public double FuelCapacity
    {
        get { return fuelCapacity; }
        set
        {
            if (this.FuelQuantity > value)
            {
                this.FuelQuantity = 0;
            }
            fuelCapacity = value;
        }
    }
    
    public virtual string Drive(double distance)
    {
        return string.Empty;
    }

    public virtual string Drive(double distance, string command)
    {
        return string.Empty;
    }

    public virtual void Refuel(double liters)
    {
        double availableSpace = this.FuelCapacity - this.FuelQuantity;
        if (liters <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        if (liters > availableSpace)
        {
            throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
        }
        this.FuelQuantity += liters;
    }
    
    public override string ToString()
    {
        string result = $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        return result;
    }
}

