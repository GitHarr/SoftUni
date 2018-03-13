using System;
using System.Collections.Generic;
using System.Text;

public abstract class Mood
{
    public override string ToString()
    {
        return $"{this.GetType().Name}";
    }
}
