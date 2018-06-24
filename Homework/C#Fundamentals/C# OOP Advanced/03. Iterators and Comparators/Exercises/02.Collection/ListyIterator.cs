using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ListyIterator<T> : IEnumerable<T>
{
    private readonly IList<T> list;
    private int index;

    public ListyIterator()
    {
        this.list = new List<T>();
        this.index = 0;
    }

    public void Create(params T[] inputList)
    {
        foreach (T item in inputList)
        {
            this.list.Add(item);
        }
    }

    public bool Move()
    {
        if (this.index == this.list.Count - 1)
        {
            return false;
        }
        this.index++;
        return true;
    }

    public bool HasNext()
    {
        if (this.index == this.list.Count - 1)
        {
            return false;
        }
        return true;
    }

    public void PrintAll()
    {
        StringBuilder sb = new StringBuilder();
        foreach (T item in this.list)
        {
            sb.Append($"{item} ");
        }
        Console.WriteLine(sb.ToString().Trim());
    }

    public override string ToString()
    {
        if (this.list.Count == 0)
        {
            throw new ArgumentException("Invalid Operation!");
        }
        T output = this.list[this.index];
        return output.ToString();
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.list.Count; i++)
        {
            yield return this.list[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

