using System;
using System.Collections.Generic;
using System.Text;

public class Car : Vehicle
{
    private const double CarIncreased_Consumption = 0.9;

    public Car(double fuelQuantity, double fuelConsumptionLitersPerKm)
        : base(fuelQuantity, fuelConsumptionLitersPerKm)
    {
    }

    public override string Drive(double distance)
    {
        double neededFuel = distance * (this.FuelConsumptionLitersPerKm + CarIncreased_Consumption);

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
}

