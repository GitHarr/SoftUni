using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

internal class Box<T>
    where T : IComparable<T>
{
    private List<T> list;

    public Box()
    {
        this.list = new List<T>();
    }

    public void Add(T element)
    {
        this.list.Add(element);
    }

    public T Remove(int index)
    {
        T elementToRemove = this.list[index];
        this.list.RemoveAt(index);

        return elementToRemove;
    }

    public bool Contains(T element)
    {
        if (this.list.Contains(element))
        {
            return true;
        }
        return false;
    }

    public void Swap(int index1, int index2)
    {
        T temp = list[index1];
        list[index1] = list[index2];
        list[index2] = temp;
    }

    public int CountGreaterThan(T element)
    {
        int countOfGreaterElements = 0;
        foreach (var elem in this.list)
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
        T max = this.list.Max();
        return max;
    }

    public T Min()
    {
        T min = this.list.Min();
        return min;
    }
    
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < this.list.Count; i++)
        {
            sb.AppendLine(this.list[i].ToString()); 
        }

        var result = sb.ToString().Trim();
        return result;
    }
}

