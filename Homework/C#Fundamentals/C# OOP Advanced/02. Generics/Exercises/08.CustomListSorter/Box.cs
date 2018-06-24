using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

internal class Box<T>
    where T : IComparable<T>
{
    public Box()
    {
        this.List = new List<T>();
    }

    internal List<T> List { get; set; }

    public void Add(T element)
    {
        this.List.Add(element);
    }

    public T Remove(int index)
    {
        T elementToRemove = this.List[index];
        this.List.RemoveAt(index);

        return elementToRemove;
    }

    public bool Contains(T element)
    {
        if (this.List.Contains(element))
        {
            return true;
        }
        return false;
    }

    public void Swap(int index1, int index2)
    {
        T temp = List[index1];
        List[index1] = List[index2];
        List[index2] = temp;
    }

    public int CountGreaterThan(T element)
    {
        int countOfGreaterElements = 0;
        foreach (var elem in this.List)
        {
            if (elem.CompareTo(element) > 0)
            {
                countOfGreaterElements++;
            }
        }

        return countOfGreaterElements;
    }

    public T Max()
    {
        T max = this.List.Max();
        return max;
    }

    public T Min()
    {
        T min = this.List.Min();
        return min;
    }

    public void Sort()
    {
        this.List = Sorter<T>.Sort(this.List);
    }
    
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < this.List.Count; i++)
        {
            sb.AppendLine(this.List[i].ToString()); 
        }

        var result = sb.ToString().Trim();
        return result;
    }
}

