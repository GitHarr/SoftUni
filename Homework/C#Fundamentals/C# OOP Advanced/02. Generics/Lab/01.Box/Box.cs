using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Box<T>
{
    private List<T> items;

    public Box()
    {
        this.items = new List<T>();
    }

    public int Count => this.items.Count;

    public void Add(T item)
    {
        this.items.Add(item);
    }

    public T Remove()
    {
        var element = this.items.Last();
        this.items.RemoveAt(this.items.Count - 1);
        return element;
    }
}

