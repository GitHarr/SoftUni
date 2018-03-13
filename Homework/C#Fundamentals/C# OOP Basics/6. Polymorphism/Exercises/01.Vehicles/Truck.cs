using System;
using System.Collections.Generic;
using System.Text;

public class Truck : Vehicle
{
    const double TruckIncreased_Consumption = 1.6;

    public Truck(double fuelQuantity, double fuelConsumptionLitersPerKm)
        : base(fuelQuantity, fuelConsumptionLitersPerKm)
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
        this.FuelQuantity += liters * 0.95;
    }
}
