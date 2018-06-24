using System;
using System.Collections.Generic;
using System.Text;

public class Box<T>
{
    private T value;

    public Box(T value)
    {
        this.value = value;
    }

    public override string ToString()
    {
        string result = $"{this.value.GetType().FullName}: {this.value}";
        return result;
    }
}

