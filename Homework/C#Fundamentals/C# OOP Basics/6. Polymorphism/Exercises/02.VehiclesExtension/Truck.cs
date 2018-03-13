using System;
using System.Collections.Generic;
using System.Text;

public class Truck : Vehicle
{
    const double TruckIncreased_Consumption = 1.6;

    public Truck(double fuelQuantity, double fuelConsumptionLitersPerKm, double fuelCapacity)
        : base(fuelQuantity, fuelConsumptionLitersPerKm, fuelCapacity)
    {
    }

    public override string Drive(double distance)
    {
        double neededFuel = distance * (this.FuelConsumptionLitersPerKm + TruckIncreased_Consumption);

        string result;
        if (this.FuelQuantity >= neededFuel)
        {
            result = $"{this.GetType().Name} travelled {distance} km";
            this.FuelQuantity -= neededFuel;
        }
        else
        {
            result = $"{this.GetType().Name} needs refueling";
        }

        return result;
    }

    public override void Refuel(double liters)
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
        this.FuelQuantity += liters * 0.95;
    }
}
