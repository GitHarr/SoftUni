using System;
using System.Collections.Generic;
using System.Text;

public class Seat : ICar
{
    private string model;
    private string color;

    public Seat(string model, string color)
    {
        this.Model = model;
        this.Color = color;
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

        sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model}")
            .AppendLine(this.Start())
            .AppendLine(this.Stop());

        string result = sb.ToString().TrimEnd();
        return result;
    }
}

