using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CustomList<T> : IEnumerable<T>
    where T : IComparable<T>
{
    public CustomList()
    {
        this.List = new List<T>();
    }

    internal List<T> List { get; private set; }

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
        
        foreach (var l in this.List)
        {
            sb.AppendLine(l.ToString());
        }

        var result = sb.ToString().Trim();
        return result;
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

