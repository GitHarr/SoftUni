using System;
using System.Collections.Generic;
using System.Text;

public class Tesla : ICar,IElectricCar
{
    private string model;
    private string color;
    private int battery;

    public Tesla(string model, string color, int battery)
    {
        this.Model = model;
        this.Color = color;
        this.Battery = battery;
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public int Battery
    {
        get { return battery; }
        set { battery = value; }
    }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model} with {this.Battery} Batteries")
            .AppendLine(this.Start())
            .AppendLine(this.Stop());

        string result = sb.ToString().TrimEnd();
        return result;
    }
}

