using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string model;
    private Engine engine;
    private Cargo cargo;
    private Tires[] tires;

    public Car(string model, Engine engine, Cargo cargo, Tires[] tires)
    {
        if (tires.Length != 4)
        {
            throw new InvalidOperationException("Tires can not be no more neither less than 4!!!");
        }

        this.model = model;
        this.engine = engine;
        this.cargo = cargo;
        this.tires = tires;
    }

    public string Model
    {
        get { return this.model; }
    }

    public Engine Engine
    {
        get { return this.engine; }
    }

    public Cargo Cargo
    {
        get { return this.cargo; }
    }

    public Tires[] Tires
    {
        get { return this.tires; }
    }
}

