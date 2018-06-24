using System;
using System.Collections.Generic;

public class Box<T>
    where T : IComparable<T>
{
    private T value;

    public Box() { }

    public Box(T value)
    {
        this.value = value;
    }

    public int CountGreaterElements(List<Box<T>> list, T element)
    {
        int countOfGreaterElements = 0;
        foreach (var elem in list)
        {
            if (elem.value.CompareTo(element) > 0)
            {
                countOfGreaterElements++;
            }
        }

        return countOfGreaterElements;
    }

    public override string ToString()
    {
        string result = $"{this.value.GetType().FullName}: {this.value}";
        return result;
    }
}

