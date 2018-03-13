using System;
using System.Collections.Generic;
using System.Text;

public class Rebel : ICitizen, IRebel, IBuyer
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Group { get; private set; }
    public int Food { get; set; }

    public Rebel(string name, int age, string group)
    {
        Name = name;
        Age = age;
        Group = group;
    }

    public void BuyFood()
    {
        this.Food += 5;
    }
}

