using System;
using System.Collections.Generic;
using System.Text;

public class Bus : Vehicle
{
    private const double BusIncreased_Consumption_ByAC = 1.4;

    public Bus(double fuelQuantity, double fuelConsumptionLitersPerKm, double fuelCapacity)
        : base(fuelQuantity, fuelConsumptionLitersPerKm, fuelCapacity)
    {
    }

    public override string Drive(double distance, string command)
    {
        double neededFuel = 0;
        if (command == "DriveEmpty")
        {
            neededFuel = distance * this.FuelConsumptionLitersPerKm;

            return GetResultAfterCalculatedNeededFuel(distance, neededFuel);
        }
        else
        {
            neededFuel = distance * (this.FuelConsumptionLitersPerKm + BusIncreased_Consumption_ByAC);

            return GetResultAfterCalculatedNeededFuel(distance, neededFuel);
        }
    }

    private string GetResultAfterCalculatedNeededFuel(double distance, double neededFuel)
    {
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

