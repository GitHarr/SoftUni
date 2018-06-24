using System;
using System.Collections.Generic;

public class ListyIterator
{
    public ListyIterator(params string[] inputList)
    {
        this.List = inputList;
    }

    public IReadOnlyList<string> List { get; private set; }

    private int index = 0;

    public bool Move()
    {
        if (this.index == this.List.Count - 1)
        {
            return false;
        }
        this.index++;
        return true;
    }

    public bool HasNext()
    {
        if (this.index == this.List.Count - 1)
        {
            return false;
        }
        return true;
    }

    public override string ToString()
    {
        if (this.List.Count == 0)
        {
            throw new ArgumentException("Invalid Operation!");
        }
        string output = this.List[this.index];
        return output;
    }
}

