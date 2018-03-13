using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumPer1km;
    private int distanceTraveled;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public double FuelAmount
    {
        get { return fuelAmount; }
        set { fuelAmount = value; }
    }

    public double FuelConsumPer1km
    {
        get { return fuelConsumPer1km; }
        set { fuelConsumPer1km = value; }
    }

    public int DistanceTraveled
    {
        get { return distanceTraveled; }
        set { distanceTraveled = value; }
    }

    public bool CanMove(double fuelAmount, double fuelConsumPer1km, int amountOfKm)
    {
        if (amountOfKm * fuelConsumPer1km <= fuelAmount)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

