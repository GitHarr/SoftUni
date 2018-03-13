using System;
using System.Collections.Generic;
using System.Text;

public class Cat
{
    private string name;

    protected Cat(string name)
    {
        this.Name = name;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public override string ToString()
    {
        return $"{this.Name}";
    }
}

