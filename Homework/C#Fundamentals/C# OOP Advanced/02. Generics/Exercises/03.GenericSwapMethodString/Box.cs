using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Box<T>
{
    private T value;

    private Box() { }

    public Box(T value)
    {
        this.value = value;
    }

    public void Swap(List<Box<T>> list)
    {
        int[] inputIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int firstIndex = inputIndexes[0];
        int secondIndex = inputIndexes[1];

        Box<T> temp = list[firstIndex];
        list[firstIndex] = list[secondIndex];
        list[secondIndex] = temp;
    }

    public override string ToString()
    {
        string result = $"{this.value.GetType().FullName}: {this.value}";
        return result;
    }
}

