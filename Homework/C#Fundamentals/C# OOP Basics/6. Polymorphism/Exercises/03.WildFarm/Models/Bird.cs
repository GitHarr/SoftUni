using System;
using System.Collections.Generic;
using System.Text;

abstract class Bird : Animal
{
    public Bird(string name, double weight, double wingSize)
        : base(name, weight)
    {
        this.WingSize = wingSize;
    }

    protected double WingSize { get; set; }

    protected override double WeightIncreaseMultiplier => base.WeightIncreaseMultiplier;

    protected override Type[] PreferredFoods => throw new NotImplementedException();

    public override string MakeSound()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        string fromBase = base.ToString(); 
        string result = string.Format(fromBase, $"{this.WingSize}, ", string.Empty);
        return result;
    }
}

